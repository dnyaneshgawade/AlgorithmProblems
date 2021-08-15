using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructureProblem
{
    public class OrderedList
    {
        static readonly string numFile = @"C:\Users\dnyan\dnyana\AlgorithmProblems\DataStructureProblem\OrderedList.txt";
        public LinkedList<int> list = new LinkedList<int>();
        public void Ordered()
        {
            List<int> numbers = new List<int>();
            string text = File.ReadAllText(numFile);
            String[] num = text.Split(" ");
            for (int i = 0; i < num.Length; i++)
            {
                numbers.Add(int.Parse(num[i]));
            }
            numbers.Sort();
            foreach (var item in numbers)
            {
                list.Add(item);
            }
            Console.WriteLine("Enter a number to Add in the list :");
            int search = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (count < num.Length)
            {
                if (search == numbers[count])
                {
                    Console.WriteLine("Word Found");
                    list.Delete(numbers[count]);
                    list.Display();
                    return;
                }
                count++;
            }
            list.Add(search);
            numbers.Sort();
            list.Display();
        }
    }
}
