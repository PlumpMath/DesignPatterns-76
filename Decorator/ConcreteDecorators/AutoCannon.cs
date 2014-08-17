using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.ConcreteDecorators
{
    public class AutoCannon : MechaWeapon
    {
        public AutoCannon(Mecha mecha)
            : base(mecha)
        {
            Description = "AutoCannon 30";
        }

        public override double CalculateCost()
        {
            return _mecha.CalculateCost() + 5000.0;
        }

        public override string GetDescription()
        {
            return _mecha.GetDescription() + ", " + Description;
        }

    }
}
