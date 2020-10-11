using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine.EntityFramework
{
    public class CashMachineDbContextFactory : IDesignTimeDbContextFactory<CashMachineDbContext>
    {
        public CashMachineDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<CashMachineDbContext>();

            //options.UseMySQL("server=localhost;port=3306;database=db_reg;user=root;password=NITRO");
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=CashMachineDB;Trusted_Connection=True;");

            return new CashMachineDbContext(options.Options);
        }
    }
}
