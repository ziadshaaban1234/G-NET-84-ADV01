using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.Question01
{
    public class Containers<T>
    {
        List<T> li = new List<T>();
        public void Add (T item)
        {
            li.Add(item);
        }
        public T Get(int index)
        {
            return li[index];
        }
        public IEnumerable<T> GetAll() => li;
        public override string ToString()
        {
            return $"All Items is : {string.Join(',',li)}";
        }
    }
}
