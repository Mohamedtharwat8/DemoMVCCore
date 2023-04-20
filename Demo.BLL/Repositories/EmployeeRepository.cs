using Demo.BLL.Interfaces;
using Demo.DAL.Context;
using Demo.DAL.Entities;
using Demo.PL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee> , IEmployeeRepository
    {




        #region OLd Repository

        // private readonly DemoContext context;

        // public EmployeeRepository(DemoContext _context)
        // {
        //     context = _context;
        // }
        // public int Add(Employee employee)
        // {
        //     context.Employees.Add(employee);
        //     return context.SaveChanges();
        // }

        // public int Delete(Employee employee)
        // {
        //     context.Employees.Remove(employee);
        //     return context.SaveChanges();
        // }

        // public Employee Get(int? id)
        //=> context.Employees.FirstOrDefault(x => x.Id == id);

        // public IEnumerable<Employee> GetAll()
        //        => context.Employees.ToList();

        // public int Update(Employee employee)
        // {
        //     context.Employees.Update(employee);
        //     return context.SaveChanges();
        // }
        #endregion
        public EmployeeRepository(DemoContext _context) : base(_context)
        {
            Context = _context;
        }

        public DemoContext Context { get; }

        public IEnumerable<Employee> GetEmployeesByDepartmentName(string departmentName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> SearchEmployee(string value)
        =>await Context.Employees.Where(E=>E.Name.Contains(value)).ToListAsync();
    }
}
