using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.Element;

namespace Visitor.Visitor
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
