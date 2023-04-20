using Demo.DAL.Entities;
using Demo.PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public  interface IEmployeeRepository : IGenericRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesByDepartmentName(string departmentName);
         Task<IEnumerable<Employee>> SearchEmployee(string value);

        #region Old One
        //Employee Get(int? id);
        //IEnumerable<Employee> GetAll();

        //int Add(Employee employee);
        //int Update(Employee employee);
        //int Delete(Employee employee);
        #endregion

    }
}
