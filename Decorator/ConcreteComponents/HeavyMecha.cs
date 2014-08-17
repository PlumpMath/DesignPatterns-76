using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.ConcreteComponents
{
    public class HeavyMecha : Mecha
    {

        public HeavyMecha()
        {
            Description = "Heavy Mecha";
        }

        public override double CalculateCost()
        {
            return 10000.0;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
