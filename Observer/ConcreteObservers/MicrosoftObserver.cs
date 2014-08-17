using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class MicrosoftObserver : StockObserver
    {
        private StockTicker DataSource { get; set; }

        public MicrosoftObserver(StockTicker subject)
        {
            DataSource = subject;
            subject.Register(this);
        }

        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;

            if (symbol.Equals("MSFT") && price > 10.00m)
                Console.WriteLine("Microsoft has reached the target price: {0}", price);
        }
    }
}
