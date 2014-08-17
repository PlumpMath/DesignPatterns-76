using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    /// <summary>
    /// Abstract Observer
    /// </summary>
    public abstract class StockObserver
    {
        public abstract void Update();
    }
}
