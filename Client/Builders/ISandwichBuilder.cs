using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    /// <summary>
    /// IBuilder
    /// </summary>
    public interface ISandwichBuilder
    {
        void AddBread();
        void AddFillings();
        void AddSauce();

        Sandwich GetSandwich();
    }
}
