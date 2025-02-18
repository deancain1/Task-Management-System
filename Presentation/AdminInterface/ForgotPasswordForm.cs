using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Helpers;
using Task_Management_System.Services.Contracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Task_Management_System.Presentation.AdminInterface
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly IUserServices _userServices;
        private readonly IAdminServices _adminServices;


        public ForgotPasswordForm(IUserServices userServices, IAdminServices adminServices)
        {
            InitializeComponent();
            _userServices = userServices;
            _adminServices = adminServices;
            QuestionAccountPanel.Visible = false;
            SecurityQuestionPanel.Visible = false;
            PasswordPanel.Visible = false;
        }

        private async void SearchAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailTxt.Text.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please enter your email.");
                    return;
                }

                var admin = await _adminServices.GetAdminEmailForForgotPassword(email);
                if (admin != null)
                {
                    FullNameLbl.Text = $"{admin.FirstName} {admin.MiddleName} {admin.LastName}";
                    EmailLbl.Text = admin.Email;
                    QuestionAccountPanel.Visible = true;
                    YesBtn.Visible = true;
                    NoBtn.Visible = true;

                    if (admin.ProfilePicture != null && admin.ProfilePicture.Length > 0)
                    {
                        using (var ms = new MemoryStream(admin.ProfilePicture))
                        {
                            Image originalImage = Image.FromStream(ms);
                            ProfilePicBox.Image = ResizeImage(originalImage, ProfilePicBox.Width, ProfilePicBox.Height);
                        }
                    }
                    else
                    {
                        ProfilePicBox.Image = null;
                    }
                    return;
                }
                var user = await _userServices.GetUserEmailForForgotPassword(email);
                if (user != null)
                {
                    FullNameLbl.Text = $"{user.FirstName} {user.MiddleName} {user.LastName}";
                    EmailLbl.Text = user.Email;
                    QuestionAccountPanel.Visible = true;
                    YesBtn.Visible = true;
                    NoBtn.Visible = true;

                    if (user.ProfilePicture != null && user.ProfilePicture.Length > 0)
                    {
                        using (var ms = new MemoryStream(user.ProfilePicture))
                        {
                            Image originalImage = Image.FromStream(ms);
                            ProfilePicBox.Image = ResizeImage(originalImage, ProfilePicBox.Width, ProfilePicBox.Height);
                        }
                    }
                    else
                    {
                        ProfilePicBox.Image = null;
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Account doesn't exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for the account: {ex.Message}");
            }
        }




        private async void YesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailLbl.Text.Trim();

                var admin = await _adminServices.GetAdminEmailForForgotPassword(email);
                if (admin != null)
                {
                    SecurityQuestionLbl.Text = admin.SecurityQuestions;
                    SecurityQuestionPanel.Visible = true;
                    YesBtn.Visible = false;
                    NoBtn.Visible = false;
                    return;
                }

                var user = await _userServices.GetUserEmailForForgotPassword(email);

                if (user != null)
                {
                    SecurityQuestionLbl.Text = user.SecurityQuestions;
                    SecurityQuestionPanel.Visible = true;
                    YesBtn.Visible = false;
                    NoBtn.Visible = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Error retrieving security question.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the security question: {ex.Message}");
            }
        }


        private void NoBtn_Click(object sender, EventArgs e)
        {
            QuestionAccountPanel.Visible = false;
            SecurityQuestionPanel.Visible = false;
            YesBtn.Visible = false;
            NoBtn.Visible = false;
        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailLbl.Text.Trim();
                string securityQuestion = SecurityQuestionLbl.Text;
                string answer = AnswerTxt.Text.Trim();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    MessageBox.Show("Please enter your answer.");
                    return;
                }

                var admin = await _adminServices.GetAdminEmailForForgotPassword(email);
                if (admin != null)
                {
                    if (admin.SecurityQuestions == securityQuestion && admin.Answer == answer)
                    {
                        MessageBox.Show("Answer is correct! Create your new password.");
                        PasswordPanel.Visible = true;
                        return;
                    }
                }

                var user = await _userServices.GetUserEmailForForgotPassword(email);
                if (user != null)
                {
                    if (user.SecurityQuestions == securityQuestion && user.Answer == answer)
                    {
                        MessageBox.Show("Answer is correct! Create your new password.");
                        PasswordPanel.Visible = true;
                        return;
                    }
                }

                MessageBox.Show("Incorrect answer. Please try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while verifying the answer: {ex.Message}");
            }
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = EmailLbl.Text.Trim();
                string securityQuestion = SecurityQuestionLbl.Text.Trim();
                string newPassword = NewPasswordTxt.Text.Trim();
                string confirmPassword = ConfirmPasswordTxt.Text.Trim();

                if (string.IsNullOrWhiteSpace(newPassword) || newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }
                string passwordError = GetPasswordStrengthError(newPassword);
                if (!string.IsNullOrEmpty(passwordError))
                {
                    MessageBox.Show(passwordError, "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isUpdated = false;
                var admin = await _adminServices.GetAdminEmailForForgotPassword(email);
                if (admin != null)
                {
                    isUpdated = await _adminServices.UpdateForgottenPasswordAsync(email, securityQuestion, newPassword);
                }

                var user = await _userServices.GetUserEmailForForgotPassword(email);
                if (user != null)
                {
                    isUpdated = await _userServices.UpdateForgottenPasswordAsync(email, securityQuestion, newPassword);
                }

                if (isUpdated)
                {
                    MessageBox.Show("Password updated successfully!");
                    var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
                    loginForm.Show();
                    ResetForm();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error updating password. Check your email and security question.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the password: {ex.Message}");
            }
        }

        private string GetPasswordStrengthError(string password)
        {
            if (password.Length < 8)
                return "Password must be at least 8 characters long.";
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return "Password must contain at least one uppercase letter.";
            if (!Regex.IsMatch(password, @"[a-z]"))
                return "Password must contain at least one lowercase letter.";
            if (!Regex.IsMatch(password, @"\d"))
                return "Password must contain at least one number.";
            if (!Regex.IsMatch(password, @"[@$!%*?&]"))
                return "Password must contain at least one special character (@$!%*?&).";

            return string.Empty;
        }
        private Image ResizeImage(Image img, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using (var g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();
            ResetForm();
            this.Hide();
        }
        private void BackToLoginBtn_Click(object sender, EventArgs e)
        {
            var forgotPasswordForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            forgotPasswordForm.Show();
            ResetForm();
            this.Hide();
        }
        private void LoginwithPasswordBtn_Click(object sender, EventArgs e)
        {
            var forgotPasswordForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            forgotPasswordForm.Show();
            ResetForm();
            this.Hide();
        }
     

        private void BackLogInBtn_Click(object sender, EventArgs e)
        {
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm?.Show();
            this.Hide();
        }
        private void ResetForm()
        {

            EmailTxt.Text = "";
            AnswerTxt.Text = "";
            NewPasswordTxt.Text = "";
            ConfirmPasswordTxt.Text = "";


            FullNameLbl.Text = "";
            EmailLbl.Text = "";
            SecurityQuestionLbl.Text = "";


            QuestionAccountPanel.Visible = false;
            SecurityQuestionPanel.Visible = false;
            PasswordPanel.Visible = false;


            YesBtn.Visible = false;
            NoBtn.Visible = false;


            ProfilePicBox.Image = null;
        }
        private void SearchAccountBtn_MouseMove(object sender, MouseEventArgs e)
        {
            SearchAccountBtn.BackColor = Color.FromArgb(89, 202, 90);
            SearchAccountBtn.ForeColor = Color.Black;
        }

        private void SearchAccountBtn_MouseLeave(object sender, EventArgs e)
        {

            SearchAccountBtn.BackColor = Color.FromArgb(19, 149, 87);
            SearchAccountBtn.ForeColor = Color.White;
        }

        private void ShowConfirmPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.ShowPassword(ConfirmPasswordTxt, ShowConfirmPasswordBtn, HideConfirmPasswordBtn);
        }
        private void HideConfirmPasswordBtn_Click_1(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.HidePassword(ConfirmPasswordTxt, ShowConfirmPasswordBtn, HideConfirmPasswordBtn);
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.ShowPassword(NewPasswordTxt, ShowPasswordBtn, HidePasswordBtn);
        }

        private void HidePasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordVisibilityHelper.HidePassword(NewPasswordTxt, ShowPasswordBtn, HidePasswordBtn);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
