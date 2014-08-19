using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.Visitor;

namespace Visitor.Element
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
