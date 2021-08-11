using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    public class PrimePalindrom
    {
		public static  List<int> list = new List<int>();
		public static void Check(int i)
        {
			if (CheckPalindrome(i) == true)
			{
				list.Add(i);
			}
			
		}
		public void Display()
        {
            Console.WriteLine("\n\nThe numbers which are prime as well as palindrom are: ");
			foreach (int numbers in list)
			{
				Console.Write(numbers + " ");
			}
			Console.WriteLine();
		}
		public static bool CheckPalindrome(int n)
		{
			int r, sum = 0, temp = n;
			while (n > 0)
			{
				r = n % 10;
				sum = (sum * 10) + r;
				n = n / 10;
			}
			if (sum == temp)
			{
				return true;
			}
			return false;
		}

	}
}
