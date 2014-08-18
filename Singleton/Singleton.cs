using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public sealed class Singleton
    {
        // Thread safe Singleton with fully lazy instantiation á la Jon Skeet:
        // http://csharpindepth.com/Articles/General/Singleton.aspx
        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}
