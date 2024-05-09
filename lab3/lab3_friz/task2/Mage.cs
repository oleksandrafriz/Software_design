using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Mage : Hero
    {
        public override void Display()
        {
            Console.WriteLine($"Маг {Name} чаклує з мудрістю");
        }
    }
}
