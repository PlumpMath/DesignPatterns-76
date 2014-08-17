using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Autos
{
    public class Toyota : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine(Name + " lähti käyntiin. TORA TORA TORA!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Hajosiko " + Name + "si");
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
