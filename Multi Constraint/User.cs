using Assignment01Advanced.IReposatory_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.Multi_Constraint
{
    public class User <T> where T : Product , new()
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public User(int id, string? name)
        {
            Id = id;
            Name = name;
            ValuesBuy =  new T();
        }
        public T ValuesBuy { get; set; }

        public override string ToString()
        {
            return $"User Name : {Name}\n User Id : {Id}\n " +
                $"=======================\n" +
                $"ValuesBuy Id : {ValuesBuy.Id}\n ValuesBuy Name : {ValuesBuy.Name}\n " +
                $"ValuesBuy price : {ValuesBuy.Salary}  ";
        }
    }
}
