using Microsoft.EntityFrameworkCore;
using MyLittleChatDL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLittleChatDL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserDL> Users { get; set; }
        private readonly string connectionString;

        public ApplicationContext(string connectionString)
        {
            this.connectionString = connectionString;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
