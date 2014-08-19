using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.Element;
using Visitor.Visitor;

namespace Visitor.ConcreteElement
{
    public class Employee : IElement
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public int VacationDays { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
