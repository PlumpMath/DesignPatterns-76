using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.ConcreteElement;
using Visitor.Element;
using Visitor.Visitor;

namespace Visitor.ObjectStructure
{
    public class ElementStructure
    {
        private List<IElement> _elements = new List<IElement>();

        public void Attach(IElement element)
        {
            _elements.Add(element);
        }

        public void Detach(IElement element)
        {
            _elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IElement element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
