using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    /// <summary>
    /// Concrete Builder
    /// </summary>
    public class ChickenSandwichBuilder : ISandwichBuilder
    {
        Sandwich _chickenSandwich = new Sandwich();
        
        public void AddBread()
        {
            _chickenSandwich.Add("White bread");
        }

        public void AddFillings()
        {
            _chickenSandwich.Add("Chicken");
            _chickenSandwich.Add("Parmesan Cheese");
            _chickenSandwich.Add("Mustard");
        }

        public void AddSauce()
        {
            _chickenSandwich.Add("Cream Sauce");
        }

        public Sandwich GetSandwich()
        {
            return _chickenSandwich;
        }
    }
}
