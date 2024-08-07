using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EFCore.Data
{
   
    internal class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Workstattion> workstattions { get; set; }

        public DbSet<Department> departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["connectionString"]);
        }
    }
}
