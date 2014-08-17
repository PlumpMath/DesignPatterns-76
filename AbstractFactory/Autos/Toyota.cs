using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Autos
{
    public class Toyota : IAuto
    {
        public void AddLuxuryPackage()
        {
            Name = "Toyota Super Lux 5000";
        }

        public void AddEconomyPackage()
        {
            Name = "Toyota Corolla";
        }

        public void AddSportsPackage()
        {
            Name = "Toyota Celica";
        }

        #region IAuto Members

        public void TurnOn()
        {
            Console.WriteLine(Name + " lähti käyntiin.");
        }

        public void TurnOff()
        {
            Console.WriteLine(Name + " sammui.");
        }

        public string Name
        {
            get;
            private set;
        }

        #endregion

    }
}
