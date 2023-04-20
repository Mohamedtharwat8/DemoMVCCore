using Demo.PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public  interface IGenericRepository<T>
    {
        Task<T> Get(int? id);
        Task<IEnumerable<T>> GetAll();

        Task<int> Add(T t);
        Task<int> Update(T t);
        Task<int> Delete(T t);
    }
}
