using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructureProblem
{
    public class UnorderList
    {
        static readonly string textFile = @"C:\Users\dnyan\dnyana\AlgorithmProblems\DataStructureProblem\TextFile1.txt";
        public LinkedList<string> list = new LinkedList<string>();
        public void Unorder()
        {  
            if (File.Exists(textFile))
            {
                string text = File.ReadAllText(textFile);
                String[] words = text.Split(" ");
                for (int i = 0; i < words.Length; i++)
                {
                    list.Add(words[i]);
                }
                Console.WriteLine("Enter a word to search :");
                string search = Console.ReadLine();
                int count = 0;
                while (count < words.Length)
                {
                    if (search == words[count])
                    {
                        Console.WriteLine("Word Found");
                        list.Delete(words[count]);
                        list.Display();
                        return;
                    }
                    count++;
                }
                list.Add(search);
                list.Display();
            }
        }
    }
}
