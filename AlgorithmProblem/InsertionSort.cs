using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    public class InsertionSort
    {
        public void Insertion()
        {
            Console.WriteLine("Enter the how many numbers you need to sort");
            int num = Convert.ToInt16(Console.ReadLine());
            int[] numbers = new int[num];
            Console.WriteLine("enter numbers");
            for (int i = 0; i < num; i++)
            {
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 1; i < num; ++i)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j =j - 1;
                }
                numbers[j + 1] = key;
            }

            Console.WriteLine("After Insertion sorting list is :");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
