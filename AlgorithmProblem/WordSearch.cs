using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmProblem
{
    public class WordSearch
    {
        const string PATH = @"C:\Users\dnyan\dnyana\AlgorithmProblems\AlgorithmProblem\WordSearch.txt";
        public void Search()
        {
            bool check = false;
            string list = File.ReadAllText(PATH);
            string[] words = list.Split(" ");
            Console.WriteLine("Enter the word which you want to search");
            string search = Console.ReadLine();
            foreach (string word in words)
            {
                if (word.Equals(search))
                {
                    Console.WriteLine(search + " : is present");
                    check = true;
                    break;
                }
            }
            if (check == false)
                Console.WriteLine(search + " : is not present");
        }
    }
}
