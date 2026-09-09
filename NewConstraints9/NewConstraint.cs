using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.NewConstraints9
{
    public class NewConstraint<T> where T: new()
    {
        public T New() 
        {
            return  new T();
            
        }
    }
}
