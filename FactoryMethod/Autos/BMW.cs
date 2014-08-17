using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Autos
{
    public class BMW : IAuto
    {
        public BMW(string name)
        {
            SetName(name);
        }

        public void TurnOn()
        {
            Console.WriteLine(Name + " lähti käyntiin.");
        }

        public void TurnOff()
        {
            Console.WriteLine(Name + " simahti.");
        }


        public string Name
        {
            get;
            private set;
        }

        public void SetName(string name)
        {
            if (name == null)
                throw new ArgumentNullException("name");

            Name = name;
        }
    }
}
