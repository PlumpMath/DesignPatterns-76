using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    /// <summary>
    /// Director
    /// </summary>
    public class Director
    {
        public void Construct(ISandwichBuilder builder)
        {
            builder.AddBread();
            builder.AddFillings();
            builder.AddSauce();
        }
    }
}
