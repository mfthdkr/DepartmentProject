using System.Linq;
using DepartmentProject.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentProject.Controllers
{
    public class DepartmentsController : Controller
    {
        DepartmentContext departmentContext = new DepartmentContext();
        public IActionResult Index()
        {
            var result = departmentContext.Departments.ToList();
            return View(result);
        }
    }
}
