using System;
using System.IO;

namespace AlgorithmProblem
{
    class Program
    {
        const string PATH = @"C:\Users\dnyan\dnyana\AlgorithmProblems\AlgorithmProblem\WordSearch.txt";
        static string list = File.ReadAllText(PATH);
        static string[] words = list.Split(" ");
        public static int choice;
        static void Main(string[] args)
        {
            while (choice != 9)
            {
                Console.WriteLine("\n1: Iteration And Recursion\n2: SearchWord\n3: Bubble Sort\n4: Insertion Sort\n5: Merge Sort\n6: Anagram Detection\n7: Prime Number\n8: Prime Palindrome\n9: Exit\nEnter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("using recursion");
                        IterationAndRecursion.FibonacciRecursion(5);
                        Console.WriteLine("using  Loop");
                        IterationAndRecursion.FibonacciLoop(5);
                        break;
                    case 2:
                        WordSearch wordSearch = new WordSearch();
                        wordSearch.Search();
                        break;
                    case 3:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.Bubble();
                        break;
                    case 4:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Insertion();
                        break;
                    case 5:
                        MergeSort mergeSort = new MergeSort();
                        mergeSort.Sort(words, 0, words.Length - 1);
                        mergeSort.Display(words);
                        break;
                    case 6:
                        Anagrams.AnagramDetection();
                        break;
                    case 7:
                        PrimeNumbers.Prime();
                        break;
                    case 8:
                        PrimePalindrom primePalindrom = new PrimePalindrom();
                        PrimeNumbers.Prime();
                        primePalindrom.Display();
                        break;
                    default:
                        Console.WriteLine("Oops! You select wrong input.");
                        break;
                }
            }
        }
    }
}
