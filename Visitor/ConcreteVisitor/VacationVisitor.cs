using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.ConcreteElement;
using Visitor.Element;
using Visitor.Visitor;

namespace Visitor.ConcreteVisitor
{
    /// <summary>
    /// Holiday fairy
    /// </summary>
    public class VacationVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            Employee employee = element as Employee;

            employee.VacationDays += 3;

            Console.WriteLine("Employee {0} holidays increased to {1}", employee.Name, employee.VacationDays);
        }
    }
}
