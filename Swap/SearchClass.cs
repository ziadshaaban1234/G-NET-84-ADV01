using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.Swap
{
    public static class SearchClass
    {
        public static void  Swap<T> (ref T x,ref T y )
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
