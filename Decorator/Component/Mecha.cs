using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Component
{
    public abstract class Mecha
    {
        protected string Description { get; set; }

        public abstract string GetDescription();

        public abstract double CalculateCost();

    }
}
