using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    public class PrimeNumbers
    {
        public static void Prime()
        {
            int a, b, i, j, flag;
            Console.WriteLine("Enter Start point");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nEnter End point");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nPrime numbers between " +
                              "{0} and {1} are: ", a, b );
            for (i = a; i <= b; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.Write(i + " ");
                    PrimePalindrom.Check(i);
                }

            }
        }
    }
}
