using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarMission
{
    class Mars : PlanetMission
    {
        public Mars()
        {
            kmToPlanet = 92_000_000;
            fuelPerKm = 1.73f;
            kmPerHour = 37000;
        }
    }
}
