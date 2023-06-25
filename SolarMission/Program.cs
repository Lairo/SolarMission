using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarMission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new Venus().MissionInfo());
            Console.WriteLine(new Mars().MissionInfo());
            Console.WriteLine(new PlanetMission().MissionInfo());

        }
    }
}
