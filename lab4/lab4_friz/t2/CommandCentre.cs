using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    public class CommandCentre
    {
        private readonly List<Runway> _runways = new List<Runway>();
        private readonly List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            _runways.AddRange(runways);
            _aircrafts.AddRange(aircrafts);
        }

        public void LandAircraft(Aircraft aircraft, Runway runway)
        {
            runway.Land(aircraft);
        }

        public void TakeOffAircraft(Aircraft aircraft, Runway runway)
        {
            if (runway.IsActive())
            {
                runway.TakeOff(aircraft);
            }
            else
            {
                Console.WriteLine("Неможливо злетіти з неактивної злітно - посадкової смуги");
            }
        }
    }
}
