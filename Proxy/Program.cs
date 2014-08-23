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
     * 
     * Types of proxies:
     * 1. Virtual proxy
     * - for lazy initialization of (resource-heavy) objects
     * 2. Remote proxy
     * - used to hide communication mechanism between remote objects
     * 3. Access proxy
     * - used to provide control over sensitive master object
     * 4. Cache proxy
     * - seldom-changing results, probably long-running tasks
     * 5. Smart proxy
     * - add extra functionality (like logging)
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
