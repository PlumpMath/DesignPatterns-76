using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    /// <summary>
    /// Originator
    /// </summary>
    public class SalesProspect
    {
        public string Name { get; set; }
        public int CustomerNumber { get; set; }
        public string Address { get; set; }
        public string CustomerType { get; set; }

        public IMemento SaveMemento()
        {
            var memento = new Memento();

            memento.State = this.MemberwiseClone();

            return memento;
        }

        public void RestoreMemento(IMemento memento)
        {
            var m = (SalesProspect)memento.State;

            this.Name = m.Name;
            this.CustomerNumber = m.CustomerNumber;
            this.Address = m.Address;
            this.CustomerType = m.CustomerType;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + this.Name);
            sb.AppendLine("CustomerNumber: " + this.CustomerNumber);
            sb.AppendLine("Address: " + this.Address);
            sb.AppendLine("CustomerType: " + this.CustomerType);

            return sb.ToString();
        }
    }
}
