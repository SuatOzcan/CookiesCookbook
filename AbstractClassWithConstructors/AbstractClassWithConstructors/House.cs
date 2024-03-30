using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassWithConstructors
{
    internal class House : Home
    {
        public House(int id, string name) : base(id, name) { }
    }
}
