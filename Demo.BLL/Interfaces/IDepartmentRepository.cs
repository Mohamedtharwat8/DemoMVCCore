using Demo.PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public  interface IDepartmentRepository:IGenericRepository<Department>
    {
        IQueryable<Department> SearchByDepartmentName(string departmentName);


        //Department Get(int? id);
        //IEnumerable<Department> GetAll();

        //int Add(Department department);
        //int Update(Department department);
        //int Delete(Department department);

    }
}
