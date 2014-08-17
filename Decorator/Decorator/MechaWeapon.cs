using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Decorator
{
    public class MechaWeapon : Mecha
    {
        protected Mecha _mecha;

        public MechaWeapon(Mecha mecha)
        {
            _mecha = mecha;
        }

        public override double CalculateCost()
        {
            return _mecha.CalculateCost();
        }

        public override string GetDescription()
        {
            return _mecha.GetDescription();
        }
    }
}
