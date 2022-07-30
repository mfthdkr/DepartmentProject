using System.Linq;
using DepartmentProject.Entities;
using DepartmentProject.Entities.Concrete;
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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {   
            departmentContext.Departments.Add(department);
            departmentContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int departmentId)
        {   
            var entityToDelete = departmentContext.Departments.Find(departmentId);
            departmentContext.Departments.Remove(entityToDelete);
            departmentContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int departmentId)
        {
            var departmentToUpdate = departmentContext.Departments.Find(departmentId);
            return View(departmentToUpdate);
        }
        [HttpPost]
        public IActionResult Update(Department department)
        {
            var entityToUpdate =
                departmentContext.Departments.FirstOrDefault(p => p.DepartmentId == department.DepartmentId);
            entityToUpdate.DepartmentName = department.DepartmentName;
            departmentContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
