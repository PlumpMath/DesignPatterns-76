using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    /// <summary>
    /// Product
    /// </summary>
    public class Sandwich
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public override string ToString()
        {
            return String.Join(", ", _parts);
        }
    }
}
