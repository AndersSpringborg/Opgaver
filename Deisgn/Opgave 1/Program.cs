using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scanner;
using Parser;
using Parser.Nodes;

namespace Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            ResultVisitor print = new ResultVisitor();

            ExpressionParser parser = new ExpressionParser();

            while("" != (line = Console.ReadLine()))
            {
                try
                {
                    IEnumerable<IExpr> expressions = parser.Parse(line);
                    foreach (IExpr item in expressions)
                    {
                        item.Accept(print);
                        Console.WriteLine(print.Value);
                    }

                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
                Console.Write("\n: ");
            }
            
        }
    }

    public class ResultVisitor : IExpressionVisitor
    {
        public readonly Dictionary<string, double> Names = new Dictionary<string, double>();
        public double Value { get; private set; }

        public void Visit(AssignmentStatement assignmentStatement)
        {

            assignmentStatement.Expression.Accept(this);
            double newValue = Value;
            Names[assignmentStatement.Name.Value] = newValue;
        }

        public void Visit(NameExpr nameExpression)
        {
            try
            {
                Value = Names[nameExpression.NameToken.Value];
            }
            catch (KeyNotFoundException)
            {
                throw new UndefinedVariableException(nameExpression.NameToken.Value);
            }
        }

        public void Visit(NegExpr negExpression)
        {
            negExpression.Expr.Accept(this);
            Value = -1.0 * Value;
        }

        public void Visit(NumberExpr numberExpression)
        {
            Value = numberExpression.NumberToken.Value;
        }

        public void Visit(PlusExpr plusExpr)
        {
            plusExpr.Lhs.Accept(this);
            double a = Value;
            plusExpr.Rhs.Accept(this);
            double b = Value;
            Value = a + b;
        }

        public void Visit(DivExpr divisionExpr)
        {
            divisionExpr.Lhs.Accept(this);
            double a = Value;
            divisionExpr.Rhs.Accept(this);
            double b = Value;
            Value = a / b;
        }

        public void Visit(MinusExpr minusExpr)
        {
            minusExpr.Lhs.Accept(this);
            double a = Value;
            minusExpr.Rhs.Accept(this);
            double b = Value;
            Value = a - b;
        }

        public void Visit(MultExpr multExpr)
        {
            multExpr.Lhs.Accept(this);
            double a = Value;
            multExpr.Rhs.Accept(this);
            double b = Value;
            Value = a * b;
        }

        public void Visit(PowExpr powExpr)
        {
            powExpr.Lhs.Accept(this);
            double a = Value;
            powExpr.Rhs.Accept(this);
            double b = Value;
            Value = Math.Pow(a, b);
        }

        public void Visit(ParanExpr expr)
        {
            expr.Expr.Accept(this);
        }
    }
}
