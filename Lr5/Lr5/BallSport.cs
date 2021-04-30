using System;
using System.Collections.Generic;
using System.Text;

namespace Lr5
{
    class BallSport : Sportsmen
    {
        public virtual void Throw()
        {
            Energy -= 10;
            Console.WriteLine($"Вы бросили мяч в кольцо\nEnergy: {Energy}");
        }

        public override void Training()
        {
            throw new NotImplementedException();
        }
    }
}
