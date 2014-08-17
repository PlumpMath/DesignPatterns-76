using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethod.Autos;

namespace FactoryMethod.Factories
{
    public class ToyotaFactory : IAutoFactory
    {
        public IAuto CreateAuto()
        {
            IAuto auto = new Toyota();

            auto.SetName("Tojota");

            return auto;
        }
    }
}
