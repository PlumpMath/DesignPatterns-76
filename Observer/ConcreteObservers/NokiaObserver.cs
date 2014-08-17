using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class NokiaObserver : StockObserver
    {
        private StockTicker DataSource { get; set; }

        public NokiaObserver(StockTicker subject)
        {
            DataSource = subject;
            subject.Register(this);
        }

        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;

            if(symbol.Equals("NOK1"))
                Console.WriteLine("Nokia's new price is: {0}", price);
        }
    }
}
