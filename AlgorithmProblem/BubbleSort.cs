using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    public class BubbleSort
    {
        public void Bubble()
        {
            Console.WriteLine("Enter the how many numbers you need to sort");
            int num = Convert.ToInt16(Console.ReadLine());
            int [] numbers=new int[num];
            for (int i=0; i < num; i++)
            {
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }
            
            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After bubble sorting list is :");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
