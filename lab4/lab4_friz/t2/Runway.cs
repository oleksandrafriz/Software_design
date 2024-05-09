using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        private Aircraft? _currentAircraft;

        public bool IsActive() => _currentAircraft != null;

        public void HighlightRed()
        {
            Console.WriteLine($"Злітно-посадкова смуга {Id} зайнята!");
        }

        public void HighlightGreen()
        {
            Console.WriteLine($"Злітно-посадкова смуга {Id} вільна!");
        }

        public void Land(Aircraft aircraft)
        {
            Console.WriteLine($"Літак {aircraft.Name} приземляється.");

            if (_currentAircraft == null)
            {
                Console.WriteLine($"Літак {aircraft.Name} приземлився.");
                _currentAircraft = aircraft;
                HighlightRed();
            }
            else
            {
                Console.WriteLine($"Не можливо приземлитися, злітно-посадкова смуга зайнята.");
            }
        }

        public void TakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Літак {aircraft.Name} злітає.");
            _currentAircraft = null;
            HighlightGreen();
            Console.WriteLine($"Літак {aircraft.Name} злетів.");
        }
    }

}
