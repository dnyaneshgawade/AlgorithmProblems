using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AlgorithmProblem
{
    public class MergeSort
    {
        
        public void Merge(string[] words, int begin, int mid, int end)
        {

            int l = mid - begin + 1;
            int r = end - mid;
            int i, j;

            string[] LeftArray = new string[l];
            string[] RightArray = new string[r];

            for (i = 0; i < l; ++i)
                LeftArray[i] = words[begin + i];

            for (j = 0; j < r; ++j)
                RightArray[j] = words[mid + 1 + j];


            i = 0; j = 0;
            int k = begin;
            while (i < l && j < r)
            {
                if (LeftArray[i].CompareTo(RightArray[j])<=0)
                {
                    words[k] = LeftArray[i];
                    i++;
                }
                else
                {
                    words[k] = RightArray[j];
                    j++;
                }
                k++;
            }
            while (i < l)
            {
                words[k] = LeftArray[i];
                i++;
                k++;
            }

            while (j < r)
            {
                words[k] = RightArray[j];
                j++;
                k++;
            }
        }

        public void Sort(string[] words, int begin, int end)
        {
            if (begin < end)
            {
                int mid = (begin + end) / 2;
                Sort(words, begin, mid);
                Sort(words, mid + 1, end);
                Merge(words, begin, mid, end);
            }
        }
        public void Display(string[] words)
        {
            Console.WriteLine("\nSorted array");
            foreach (string sort in words)
            {
                Console.Write(sort + " ");
            }
        }
    }
}

