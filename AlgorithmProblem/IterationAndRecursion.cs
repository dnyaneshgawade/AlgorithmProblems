using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    public class IterationAndRecursion
    {
        public static int FibonacciRecursion(int n)
        {
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
                }
            }
        }
        public static void FibonacciLoop(int number)
        {
            int n1 = 0, n2 = 1, n3, i;
            Console.Write("{0} \n{1}\n", n1, n2);
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.WriteLine("{0}",n3);
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
