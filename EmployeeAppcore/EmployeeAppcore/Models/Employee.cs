using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppcore.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Qualification { get; set; }
        [Required]
        public string ContactNumber { get; set; }

        [ForeignKey("DepartmentID")]
        [Display(Name = "Department")]
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
    }
}
