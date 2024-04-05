﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeight
{
    public class ConcreteFlyweight : IFlyweight
    {
        private string intrinsicState;

        public ConcreteFlyweight(string intrinsicState)
        {
            this.intrinsicState = intrinsicState;
        }

        public void Operation()
        {
            Console.WriteLine($"ConcreteFlyweight: {intrinsicState}");
        }
    }

}
