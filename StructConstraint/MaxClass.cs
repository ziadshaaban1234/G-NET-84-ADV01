using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.StructExample7
{
    public static class Max<T> where T : struct , IComparable<T>
    {
        public static T max (T num1 , T num2)
        {
            if (num1.CompareTo( num2) >0)
                return num1;
            return num2;        
        }
    }
}
