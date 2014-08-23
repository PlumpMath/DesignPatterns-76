using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Autos;

namespace AbstractFactory.Factories
{
    public class BMWFactory : IAutoFactory
    {       
        public IAuto CreateEconomyCar()
        {
            var auto = new BMWEconomy();
            return auto;
        }

        public IAuto CreateLuxuryCar()
        {
            var auto = new BMWLuxury();
            return auto;
        }

        public IAuto CreateSportsCar()
        {
            var auto = new BMWSports();
            return auto;
        }
    }
}
