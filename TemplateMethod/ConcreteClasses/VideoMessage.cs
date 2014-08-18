using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClasses
{
    public class VideoMessage : InstantMessage
    {
        public override void InitializeMessage()
        {
            Console.WriteLine("Initializing video message");
        }

        public override void SerializeMessage()
        {
            Console.WriteLine("Serializing video message");
        }

        public override void SendMessage()
        {
            Console.WriteLine("Sending video message");
        }
    }
}
