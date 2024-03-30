using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassWithConstructors
{
    internal abstract class Home
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Home(int id, string name) {
            ID = id;
            Name = name;
        }

        public Home(int id, string name, int rank)
        {
            ID = id;
            Name = name;
            int goal = rank * 2;
        }
    }
}
