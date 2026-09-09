using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.BaseClass_Constraint
{
    public class Cat<T> where T : Animal 
    {
        public string Speak { get; set; }
        public Cat(string speak) 
        {
            Speak = speak;
        }
    }
}
