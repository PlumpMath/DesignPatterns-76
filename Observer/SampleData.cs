using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Observer
{
    public class SampleData
    {
        private static decimal[] samplePrices = new decimal[] { 10.00m, 10.25m, 550.0m, 560.0m, 4.38m, 7.9m};
        private static string[] sampleStocks = new string[] { "MSFT", "MSFT", "GOOG", "GOOG", "NOK1", "NOK1"};

        public static IEnumerable<Stock> getNext()
        {
            for (int i = 0; i < samplePrices.Length; i++)
            {
                Stock s = new Stock();
                s.Symbol = sampleStocks[i];
                s.Price = samplePrices[i];
                yield return s;
            }
        }
    }
}
