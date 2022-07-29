using DepartmentProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DepartmentProject.Entities
{
    public class DepartmentContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
