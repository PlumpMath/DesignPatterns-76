using Interpreter.AbstractExpression;
using Interpreter.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    /*
     * Interpreter Pattern
     * 
     * Definition: Given a language, define a representation for its grammar along with an interpreter 
     * that uses the representation to interpret sentences in the language.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "MCMXXVIII";
            Context.Context context = new Context.Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}",
              roman, context.Output);

            // Wait for user
            Console.ReadLine();
        }
    }
}
