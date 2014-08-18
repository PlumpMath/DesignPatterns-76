using Prototype.ConcretePrototype;
using Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    /*
     * Prototype Pattern
     * 
     * Definition: Specify the kind of objects to create using a prototypical instance, 
     * and create new objects by copying this prototype.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Machine deusExMachina = new DeusExMachina();
            deusExMachina.Name = "Deus";
            Machine superComputer = new SuperComputer();
            superComputer.Name = "SuperComputer";

            var clonedMachina = deusExMachina.Clone();
            clonedMachina.Name = "ClonedDeus";
            var clonedSuperComputer = superComputer.Clone();
            clonedSuperComputer.Name = "ClonedSuperComputer";

            Console.WriteLine("{0}", deusExMachina.Name);
            Console.WriteLine("{0}", clonedMachina.Name);

            Console.WriteLine("{0}", superComputer.Name);
            Console.WriteLine("{0}", clonedSuperComputer.Name);


            Console.ReadLine();
        }
    }
}
