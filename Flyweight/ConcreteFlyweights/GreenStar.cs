using Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight.ConcreteFlyweights
{
    public class GreenStar : IStar
    {
        public static int objectCount = 0;

        public GreenStar()
        {
            objectCount++;
        }

        public string Color
        {
            get
            {
                return "Green";
            }
        }
    }
}
