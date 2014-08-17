using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethod.Autos;

namespace FactoryMethod.Factories
{
    public class BMWFactory : IAutoFactory
    {       
        public IAuto CreateAuto()
        {
            IAuto auto;

            auto = new BMW("Bemari");

            return auto;
        }
    }
}
