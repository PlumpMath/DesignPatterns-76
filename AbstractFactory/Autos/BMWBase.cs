using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Autos
{
    public abstract class BMWBase : IAuto
    {

        public string Name { get; protected set; }

        public void TurnOn()
        {
            Console.WriteLine(Name + " lähti käyntiin.");
        }

        public void TurnOff()
        {
            Console.WriteLine(Name + " simahti.");
        }
    }
}
