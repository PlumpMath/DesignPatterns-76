using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    /*
     * Singleton Pattern
     * 
     * Definition: Ensure a class has only one instance and provide a global point of access to it.
     */
    class Program
    {
        static void Main(string[] args)
        {           
            Singleton instance = Singleton.Instance;

            Console.WriteLine();
        }
    }
}
