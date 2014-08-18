using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClasses
{
    public class PlainTextMessage : InstantMessage
    {

        public override void InitializeMessage()
        {
            Console.WriteLine("Initializing plaintext message");
        }

        public override void SerializeMessage()
        {
            Console.WriteLine("Serializing plaintext message");
        }

        public override void SendMessage()
        {
            Console.WriteLine("Sending plaintext message");
        }
    }
}
