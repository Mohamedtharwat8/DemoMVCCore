using Demo.BLL.Interfaces;
using Demo.DAL.Context;
using Demo.PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class DepartmentRepository : GenericRepository<Department> , IDepartmentRepository
    {
         

        private readonly DemoContext _context;

        public DepartmentRepository(DemoContext context)
            : base(context)
        {
            _context = context;
        }

        public IQueryable<Department> SearchByDepartmentName(string departmentName)
            => _context.Departmens.Where(d => d.Name.ToLower().Contains(departmentName.ToLower()));
        #region OLd One

        // private readonly DemoContext context;

        // public DepartmentRepository(DemoContext  _context)
        // {
        //     context = _context;
        // }
        // public int Add(Department department)
        // {
        //     context.Departmens.Add(department);
        //    return  context.SaveChanges();
        // }

        // public int Delete(Department department)
        // {
        //     context.Departmens.Remove(department);
        //     return context.SaveChanges();
        // }

        // public Department Get(int? id)
        //=> context.Departmens.FirstOrDefault(x => x.Id == id);

        // public IEnumerable<Department> GetAll()
        //        => context.Departmens.ToList();

        // public int Update(Department department)
        // {
        //     context.Departmens.Update(department);
        //     return context.SaveChanges();
        // }
        #endregion
    }
}
