using Demo.DAL.Entities;
using Demo.PL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Context
{
    public  class DemoContext : DbContext
    {
        public DemoContext( DbContextOptions<DemoContext> options) : base(options)
        {
        }
       public  DbSet<Department> Departmens { get; set; }
       public  DbSet<Employee> Employees { get; set; }
    }
}
