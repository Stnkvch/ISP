﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lr5
{
    class Bascet : BallSport 
    {
        public  void Training()
        {
            Energy -= 20;
            Console.WriteLine($"You trained\nEnergy: {Energy}");
        }
    }
}
