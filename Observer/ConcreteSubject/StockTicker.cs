using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class StockTicker : Ticker
    {
        private Stock _stock;
        public Stock Stock { get { return _stock; } set { _stock = value; this.Notify(); } }
    }
}
