using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Task_Management_System.Domain.Entities;

namespace Task_Management_System.Data_Connectivity.Configurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<AdminEntity>
    {
        public void Configure(EntityTypeBuilder<AdminEntity> builder)
        {
            
            builder.HasKey(a => a.AdminID);

         
            builder.Property(a => a.LastName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(a => a.FirstName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(a => a.MiddleName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(a => a.Email)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(a => a.Username)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(a => a.SecurityQuestions)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(a => a.Answer)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(a => a.PasswordHash)
                   .IsRequired()
                   .HasColumnType("VARBINARY(MAX)"); 

            builder.Property(a => a.PasswordSalt)
                  .IsRequired()
                  .HasColumnType("VARBINARY(MAX)");

            builder.Property(a => a.Role)
                   .IsRequired()
                   .HasMaxLength(50);


        }
    }
}
