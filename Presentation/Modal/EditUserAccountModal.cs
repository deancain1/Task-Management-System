using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Management_System.Domain.Entities;

namespace Task_Management_System.Presentation.Modal
{
    public partial class EditUserAccountModal : Form
    {
        public EditUserAccountModal()
        {
            InitializeComponent();
        }

        public void EditUserAccount(UserEntity userEntity)
        {
            UserIDLbl.Text = userEntity.UserID.ToString();
            LastNameTxt.Text = userEntity.LastName;
            FirstNameTxt.Text = userEntity.FirstName;
            MiddleNameTxt.Text = userEntity.MiddleName;
            EmailTxt.Text = userEntity.Email;

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
