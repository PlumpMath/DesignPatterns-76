using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public interface IAuto
    {
        string Name { get; }
        void TurnOn();
        void TurnOff();
    }
}
