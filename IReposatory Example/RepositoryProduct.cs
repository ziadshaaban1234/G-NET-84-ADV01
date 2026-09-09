using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.IReposatory_Example
{
    public class RepositoryProduct : IRepository<Product>
    {
        List<Product> li = new List<Product>();
        public void Add(Product item)
        {
            li.Add(item);
        }

        public void Delete(int id)
        {
            li.RemoveAll(x => x.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return li;
        }

        public Product GetById(int id)
        {
            return li.Find(x => x.Id == id)!;
        }
 
    }
}
