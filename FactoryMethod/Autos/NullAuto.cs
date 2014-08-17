using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Autos
{
    public class NullAuto : IAuto
    {
        public void TurnOn()
        {
            Console.WriteLine("This auto is NULL. It cannot start.");
        }

        public void TurnOff()
        {
            Console.WriteLine("This auto is NULL. It cannot stop.");
        }

        public string Name
        {
            get { return "NULL name"; }
        }

        public void SetName(string name)
        {
            Console.WriteLine("Can't set name for NULL!");
        }
    }
}
