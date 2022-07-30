using System.Collections.Generic;
using System.Linq;
using DepartmentProject.Entities;
using DepartmentProject.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DepartmentProject.Controllers
{
    public class EmployeeController : Controller
    {
        private DepartmentContext departmentContext = new DepartmentContext();
        [Authorize]
        public IActionResult Index()
        {   

            var entity = departmentContext.Employees.Include(x=>x.Department).ToList();
            return View(entity);
        }

        public IActionResult Create()
        {
            ViewBag.listOfDepartments = departmentContext.Departments.Select(p=> new SelectListItem()
            {
                Text = p.DepartmentName,
                Value = p.DepartmentId.ToString()
            }).ToList();
            

            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            var entity = departmentContext.Departments.Where(p => p.DepartmentId == employee.Department.DepartmentId)
                .FirstOrDefault();
            employee.Department = entity;
            departmentContext.Employees.Add(employee);
            departmentContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
