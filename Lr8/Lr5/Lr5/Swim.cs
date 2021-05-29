using System;
using System.Collections.Generic;
using System.Text;

namespace Lr5
{
    class Swim : Sportsmen, ISport
    {
        public void Training()
        {
            Energy -= 5;
            Console.WriteLine($"You trained\nEnergy: {Energy}");
        }
    }
}
