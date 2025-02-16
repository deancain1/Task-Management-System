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
    public class TaskConfiguration : IEntityTypeConfiguration<TaskEntity>

    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.HasKey(t => t.TaskID);

            builder.Property(t => t.TaskTitle)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.TaskDescription)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.StartTime)
           .IsRequired()
           .HasColumnType("datetime");

            builder.Property(t => t.EndTime)
                .IsRequired()
               .HasColumnType("datetime");

            builder.Property(t => t.AssignTo)
             .IsRequired()
             .HasMaxLength(255);

            builder.Property(t => t.Status)
             .IsRequired()
             .HasMaxLength(255);

            builder.HasOne(t => t.Users)
            .WithMany(u => u.Tasks)
            .HasForeignKey(t => t.UserID)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
