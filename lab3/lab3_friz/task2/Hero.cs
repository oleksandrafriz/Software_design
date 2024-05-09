using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public abstract void Display();
    }
}
