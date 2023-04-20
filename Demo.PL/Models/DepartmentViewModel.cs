using Demo.DAL.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Demo.PL.Models
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code Is Required")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Name LEngth Must be Between 5 and 100 Chars")]
        public string Name { get; set; }
        public DateTime DateOFCreation { get; set; }

        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
