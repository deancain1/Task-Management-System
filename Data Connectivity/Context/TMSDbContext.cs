using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_System.Data_Connectivity.Configurations;
using Task_Management_System.Domain.DTO;
using Task_Management_System.Domain.Entities;

namespace Task_Management_System.Data_Connectivity.Context
{
    public class TMSDbContext : DbContext
    {

   

        public TMSDbContext(DbContextOptions<TMSDbContext> options) : base(options) { }
        public DbSet<AdminEntity> Admin { get; set; } = null!;
        public DbSet<UserEntity> Users { get; set; } = null!;
        public DbSet<TaskEntity> Tasks { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
          
        }
   
    }
}
