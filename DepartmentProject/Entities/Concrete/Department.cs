﻿using System.ComponentModel.DataAnnotations;

namespace DepartmentProject.Entities.Concrete
{
    public class Department
    {
        [Key]
        public int DepartmentId  { get; set; }
        public string DepartmentName { get; set; }
    }
}
