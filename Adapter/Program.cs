using Adapter.Adapter;
using Adapter.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{

    /*
    * Adapter Pattern
    * 
    * Definition: Convert the interface of a class into another interface clients expect. 
    * Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
    */

    class Program
    {
        static void Main(string[] args)
        {
            IAnimalSounds adapter = new CatSoundAdapter();
            var catLevel = adapter.GetAnimalSoundCatLevel();

            Console.WriteLine("Dog's sound cat level is: {0}", catLevel);

            Console.ReadLine();
        }
    }
}
