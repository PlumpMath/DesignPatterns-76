using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    /*
    * Proxy Pattern
    * 
    * Definition: Provide a surrogate or placeholder for another object to control access to it.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading 3 hi-res (proxy) images");

            ProxyImage image1 = new ProxyImage("jotain");
            ProxyImage image2 = new ProxyImage("jotain");
            ProxyImage image3 = new ProxyImage("jotain");

            Console.WriteLine("Calling show to image1");
            image1.ShowImage();

            Console.ReadLine();
        }
    }
}
