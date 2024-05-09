using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class ArmorDecorator : HeroDecorator
    {
        public string Armor { get; set; }

        public ArmorDecorator(Hero hero, string armor) : base(hero)
        {
            this.Armor = armor;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Захищений бронею {Armor}\n");
        }
    }
}
