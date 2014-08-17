using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class GoogleObserver : StockObserver
    {
        private StockTicker DataSource { get; set; }

        public GoogleObserver(StockTicker subject)
        {
            DataSource = subject;
            subject.Register(this);
        }

        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;

            if(symbol.Equals("GOOG"))
                Console.WriteLine("Google's new price is: {0}", price);
        }
    }
}
