using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser;
using Parser.Nodes;
using Scanner;

namespace Opgave_1
{
    public class PrintVisitor : IExpressionVisitor
    {
        public void Visit(AssignmentStatement expr)
        {
            
            Console.Write(expr.Name.Value + "=");
            expr.Expression.Accept(this);
        }

        public void Visit(NameExpr expr)
        {
            Console.Write(expr.NameToken.Value);
        }

        public void Visit(NegExpr expr)
        {
            Console.Write("-");
            expr.Expr.Accept(this);
        }

        public void Visit(NumberExpr expr)
        {
            Console.Write(expr.NumberToken.Value);
        }

        public void Visit(PlusExpr expr)
        {
            expr.Lhs.Accept(this);
            Console.Write("+");
            expr.Rhs.Accept(this);
        }

        public void Visit(DivExpr expr)
        {
            expr.Lhs.Accept(this);
            Console.Write("/");
            expr.Rhs.Accept(this);
        }

        public void Visit(MinusExpr expr)
        {
            expr.Lhs.Accept(this);
            Console.Write("-");
            expr.Rhs.Accept(this);
        }

        public void Visit(MultExpr expr)
        {
            expr.Lhs.Accept(this);
            Console.Write("*");
            expr.Rhs.Accept(this);
        }

        public void Visit(PowExpr expr)
        {
            expr.Lhs.Accept(this);
            Console.Write("^");
            expr.Rhs.Accept(this);
        }

        public void Visit(ParanExpr expr)
        {
            Console.Write("(");
            expr.Expr.Accept(this);
            Console.Write(")");
        }
    }
}
