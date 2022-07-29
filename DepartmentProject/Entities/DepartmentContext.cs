using DepartmentProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DepartmentProject.Entities
{
    public class DepartmentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=DepartmentDb;integrated security =true");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
