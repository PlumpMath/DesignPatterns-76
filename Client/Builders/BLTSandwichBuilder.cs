using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    /// <summary>
    /// Concrete Builder
    /// </summary>
    public class BLTSandwichBuilder : ISandwichBuilder
    {
        private Sandwich _bltSandwich = new Sandwich();

        public void AddBread()
        {
            _bltSandwich.Add("Rye Bread");
        }

        public void AddFillings()
        {
            _bltSandwich.Add("Bacon");
            _bltSandwich.Add("Lettuce");
            _bltSandwich.Add("Tomato");

        }

        public void AddSauce()
        {
            _bltSandwich.Add("Mustard Sauce");
        }

        public Sandwich GetSandwich()
        {
            return _bltSandwich;
        }
    }
}
