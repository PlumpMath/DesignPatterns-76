using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    /// <summary>
    /// Abstract Subject
    /// </summary>
    public abstract class Ticker
    {
        private List<StockObserver> observers = new List<StockObserver>();

        public void Register(StockObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(StockObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (StockObserver o in observers)
            {
                o.Update();
            }
        }
    }
}
