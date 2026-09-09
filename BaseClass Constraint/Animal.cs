using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.BaseClass_Constraint
{
    public class Animal
    {
        public string? Name { get; set; }
        public string? Speak { set; get; }
        public Animal(string? name, string? speak)
        {
            Name = name;
            Speak = speak;
        }
       
    }
}
