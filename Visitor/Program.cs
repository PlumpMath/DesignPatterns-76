using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.ConcreteElement;
using Visitor.ConcreteVisitor;
using Visitor.ObjectStructure;
using Visitor.Visitor;

namespace Visitor
{
    /*
    * Visitor Pattern
    * 
    * Definition: Represent an operation to be performed on the elements of an object structure. 
    * Visitor lets you define a new operation without changing the classes of the elements on which it operates.
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Setup structure
            ElementStructure structure = new ElementStructure();
            structure.Attach(new Employee { Name = "Risto Reipas", Salary = 3000, VacationDays = 20 });
            structure.Attach(new Employee { Name = "Erno Perälä", Salary = 3200, VacationDays = 40 });
            structure.Attach(new Employee { Name = "Sauli Niinistö", Salary = 13000, VacationDays = 2 });

            // Create visitor objects
            IVisitor salaryFairy = new SalaryVisitor();
            IVisitor vacationFairy = new VacationVisitor();

            // Structure accepting visitors
            structure.Accept(salaryFairy);
            structure.Accept(vacationFairy);

            // Wait for user
            Console.ReadLine();
        }
    }
}
