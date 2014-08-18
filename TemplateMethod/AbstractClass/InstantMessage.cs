using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.AbstractClass
{
    public abstract class InstantMessage
    {
        // primitive operations
        public abstract void InitializeMessage();
        public abstract void SerializeMessage();
        public abstract void SendMessage();

        // template method
        public void ProcessMessage()
        {
            InitializeMessage();
            SerializeMessage();
            SendMessage();
        }
    }
}
