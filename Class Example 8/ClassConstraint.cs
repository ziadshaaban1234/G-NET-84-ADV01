using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.StructExample7
{
    public  class ClassConstraint<T> where T : class
    {
        public T Value { get; set; }

        public ClassConstraint(T value)
        {
            Value = value;
        }

    }
}
