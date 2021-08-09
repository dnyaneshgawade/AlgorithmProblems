using System;

namespace AlgorithmProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("using recursion");
            IterationAndRecursion.FibonacciRecursion(5);
            Console.WriteLine("using  Loop");
            IterationAndRecursion.FibonacciLoop(5);
            WordSearch wordSearch = new WordSearch();
            wordSearch.Search();
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Bubble();
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Insertion();
        }
    }
}
