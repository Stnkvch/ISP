using System;
using System.Collections.Generic;
using System.Text;

namespace Lr5
{
    class Football : BallSport
    {
        public void Throw()
        {
            Energy -= 25;
            Console.WriteLine($"Вы ударили по воротам\nEnergy: {Energy}");

        }

        public  void Training()
        {
            Energy -= 10;
            Console.WriteLine($"You trained\nEnergy: {Energy}");
        }
    }
}
