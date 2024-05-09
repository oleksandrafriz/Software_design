using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class WeaponDecorator : HeroDecorator
    {
        public string Weapon { get; set; }

        public WeaponDecorator(Hero hero, string weapon) : base(hero)
        {
            this.Weapon = weapon;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Володіє могутньою {Weapon}");
        }
    }

}
