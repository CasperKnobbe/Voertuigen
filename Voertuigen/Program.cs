using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford ford1 = new Ford(4);
            Smart smart1 = new Smart(4);
            Landrover landrover1 = new Landrover(4);
            Bus bus1 = new Bus(8);
            Bus bus2 = new Bus(16);
            Auto BWM = new Auto(17, 4);
            Console.WriteLine("type ford1 is:" + ford1);
            Console.WriteLine("de wielen van de smart zijn:" + smart1.Wielen);
            Console.WriteLine("de wielmaat van de landrover is: " + landrover1.WielMaat);
            Console.WriteLine("de maat van de velg van het 3e wiel van bus1 is " + bus1.Wielen[2].Velg.Maat);
            Console.ReadKey();
        }
    }
}
