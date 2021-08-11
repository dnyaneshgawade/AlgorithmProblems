using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    public class InsertionSort
    {
        public void Insertion()
        {
            Console.WriteLine("Enter the how many strings you need to sort");
            int num = Convert.ToInt16(Console.ReadLine());
            string[] words = new string[num];
            Console.WriteLine("enter string");
            for (int i = 0; i < num; i++)
            {
                words[i] = Console.ReadLine();
            }
            for (int i = 1; i < num; ++i)
            {
                string key = words[i];
                int j = i - 1;
                while (j >= 0 && (words[j].CompareTo(key)>0))
                {
                    words[j + 1] = words[j];
                    j--;
                }
                words[j + 1] = key;
            }

            Console.WriteLine("After Insertion sorting list is :");
            foreach (string number in words)
            {
                Console.Write(number + " ");
            }
        }
    }
}
