﻿using Microsoft.EntityFrameworkCore;
using MyLittleChatDL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLittleChatDL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<UserDL> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ChatDB;Username=postgres;Password=isa");
        }
    }
}
