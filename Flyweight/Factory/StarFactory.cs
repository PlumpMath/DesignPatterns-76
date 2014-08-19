using Flyweight.ConcreteFlyweights;
using Flyweight.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight.Factory
{
    public class StarFactory
    {
        private Dictionary<string, IStar> _stars = new Dictionary<string, IStar>();

        public IStar GetStar(string star)
        {
            switch (star)
            {
                case "Red":
                    if (!_stars.ContainsKey("Red"))
                        _stars["Red"] = new RedStar();
                    return _stars["Red"];
                case "Green":
                    if (!_stars.ContainsKey("Green"))
                        _stars["Green"] = new GreenStar();
                    return _stars["Green"];
                default:
                    throw new ArgumentException("Unknown star type");
            }
        }
    }
}
