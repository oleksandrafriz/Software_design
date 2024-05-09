using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Paladin : Hero
    {
        public override void Display()
        {
            Console.WriteLine($"Паладин {Name} виступає за справедливість");
        }
    }

}
