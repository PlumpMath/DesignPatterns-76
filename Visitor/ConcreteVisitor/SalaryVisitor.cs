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
    /// Salary fairy
    /// </summary>
    public class SalaryVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            Employee employee = element as Employee;

            employee.Salary += 1000;

            Console.WriteLine("Employee {0} salary raised to {1}", employee.Name, employee.Salary);
        }
    }
}
