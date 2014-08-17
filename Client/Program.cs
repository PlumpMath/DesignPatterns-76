using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    /*
     * Builder Pattern
     * 
     * Definition: Separate the construction of a complex object from its representation 
     * so that the same construction process can create different representations.
     */


    /// <summary>
    /// Fancy sandwich builder. Build various sandwiches with different recipes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            ISandwichBuilder bltSandwichBuilder = new BLTSandwichBuilder();
            ISandwichBuilder chickenSandwichBuilder = new BLTSandwichBuilder();

            director.Construct(bltSandwichBuilder);
            var bltSandwich = bltSandwichBuilder.GetSandwich();

            director.Construct(chickenSandwichBuilder);
            var chickenSandwich = chickenSandwichBuilder.GetSandwich();

            Console.WriteLine("Sandwiches:");
            Console.WriteLine("Chicken: {0}", chickenSandwich.ToString());
            Console.WriteLine("BLT: {0}", bltSandwich.ToString());

            Console.ReadLine();
        }
    }
}
