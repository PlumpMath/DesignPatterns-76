using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public interface IAutoFactory
    {
        IAuto CreateEconomyCar();
        IAuto CreateLuxuryCar();
        IAuto CreateSportsCar();
    }
}
