using CashMachine.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine.EntityFramework
{
    public class CashMachineDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        public CashMachineDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
