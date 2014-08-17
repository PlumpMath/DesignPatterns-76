using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    /*
    * Composite Pattern
    * 
    * Definition: Compose objects into tree structures to represent part-whole hierarchies. 
    * Composite lets clients treat individual objects and compositions of objects uniformly.
    */
    class Program
  {
    static void Main(string[] args)
    {
      Component<Pattern> creational = new Composite<Pattern> { Name = "Creational Patterns" };
      Component<Pattern> builder = new Leaf<Pattern> { Name = "Builder" };
      Component<Pattern> prototype = new Leaf<Pattern> { Name = "Prototype" };
      Component<Pattern> singleton = new Leaf<Pattern> { Name = "Singleton" };

      creational.Add(builder);
      creational.Add(prototype);
      creational.Add(singleton);

      Console.WriteLine(creational.Display());

      var pattern = creational.Find("Prototype");

      Console.WriteLine("Removing: {0}\n", pattern.Name);
      creational.Remove(pattern);

      Console.WriteLine("New list:");
      Console.WriteLine(creational.Display());

      Console.WriteLine("Press enter to exit.");
      Console.ReadLine();
    }

    class Pattern { }
    class Accessory { }

  }
}
