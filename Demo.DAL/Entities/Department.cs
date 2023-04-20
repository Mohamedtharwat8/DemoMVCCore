using Demo.DAL.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Demo.PL.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
