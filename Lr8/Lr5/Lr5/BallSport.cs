using System;
using System.Collections.Generic;
using System.Text;

namespace Lr5
{
    class BallSport : Sportsmen , ISport
    {
        public virtual void Throw()
        {
            Energy -= 10;
            Console.WriteLine($"Вы бросили мяч в кольцо\nEnergy: {Energy}");
        }

        public void Training()
        {
            throw new NotImplementedException();
        }
    }
}
