using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Autos;

namespace AbstractFactory.Factories
{
    public class ToyotaFactory : IAutoFactory
    {
        public IAuto CreateEconomyCar()
        {
            var auto = new Toyota();
            auto.AddEconomyPackage();

            return auto;
        }

        public IAuto CreateLuxuryCar()
        {
            var auto = new Toyota();
            auto.AddLuxuryPackage();

            return auto;
        }

        public IAuto CreateSportsCar()
        {
            var auto = new Toyota();
            auto.AddSportsPackage();

            return auto;
        }
    }
}
