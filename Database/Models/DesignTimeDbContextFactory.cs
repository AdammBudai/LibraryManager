using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ManagerDbContext>
    {
        public ManagerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ManagerDbContext>();
            optionsBuilder.UseMySql("server=localhost;database=librarymanager;user=root;password=admin;",
            //optionsBuilder.UseMySql("server=192.168.1.205;database=librarymanager;user=root;password=root;",
                new MySqlServerVersion(new Version(8, 0, 21)));

            return new ManagerDbContext(optionsBuilder.Options);
        }
    }
}
