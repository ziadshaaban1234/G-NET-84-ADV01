using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.Question03
{
    public class Pair<TKey, TValue> 
    {        
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Pair(TKey key , TValue value)
        {
            Key = key;
            Value = value;
        }

    }
}
