using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Warrior : Hero
    {
        public override void Display()
        {
            Console.WriteLine($"Воїн {Name} готовий до бою");
        }
    }
}
