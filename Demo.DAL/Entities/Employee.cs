using Demo.PL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{
    public  class Employee
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int? Age { get; set; }

        //[Range(10,100, ErrorMessage = "Address must be between 10 and 60")]
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string ImageName { get; set; }

    }
}
