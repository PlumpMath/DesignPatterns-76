using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Autos
{
    public class NullAuto : IAuto
    {
        #region IAuto Members

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
            get
            {
                return "This name is NULL!";
            }
            protected set
            {
                Console.WriteLine("Can't set name to NULL!");
            }
        }

        #endregion
    }
}
