using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Framework_Demo.Model;

namespace Entity_Framework_Demo.EntityConfigurations
{
    class EntityContext : DbContext
    {
        public DbSet<Department> Departments {get;set;}
        public DbSet<Employee> Employees { get;set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DepartmentConfiguration());
        }
    }
}
