using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.Question04
{
    public static class Search2  
    {

        public static T FindMax<T>(T[] Arr) where T: IComparable<T>
        {
            T max = Arr[0];
            foreach (var item in Arr)
            {
                if (item.CompareTo(max)>0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
