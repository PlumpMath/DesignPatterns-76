using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.ConcreteDecorators
{
    public class HeavyLaser : MechaWeapon
    {
        public HeavyLaser(Mecha mecha)
            : base(mecha)
        {
            Description = "Heavy Laser";
        }

        public override double CalculateCost()
        {
            return _mecha.CalculateCost() + 2000.0;
        }

        public override string GetDescription()
        {
            return _mecha.GetDescription() + ", " + Description;
        }
    }
}
