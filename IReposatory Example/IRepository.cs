using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.IReposatory_Example
{
    public interface IRepository<T>
    {
        void Add (T item);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Delete(int id);
    }
}
