using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Domain.Entities;

namespace Task_Management_System.Data_Connectivity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(a => a.UserID);

         

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

            builder.Property(a => a.UserProfile)
              .HasColumnType("varbinary(max)") 
              .IsRequired(false);


        }
    }
}
