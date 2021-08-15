using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem
{
    public class BalanceParanthesis
    {
        public readonly string expresion = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
        public void Check()
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(')
                {
                    stack.Push("(");
                }
                if (expresion[i] == ')')
                {
                    stack.Pop();
                }
            }

            if (stack.IsEmpty())
                Console.WriteLine("Arithmetic expression is balanced");
            else
                Console.WriteLine("Arithmetic expression is not balanced");
        }
    } 
}
