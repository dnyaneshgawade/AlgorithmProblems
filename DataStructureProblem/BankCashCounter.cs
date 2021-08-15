using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem
{
    public class BankCashCounter
    {
        readonly Queue<string> queue = new Queue<string>();
        double Amount = 100000;
        public static int choice;
        public void CashCounter()
        {
            Console.WriteLine("Enter Number of People");
            int number = Convert.ToInt16(Console.ReadLine());
            string[] Name = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter Person Name");
                string customer = Console.ReadLine();
                queue.Enqueue(customer);
                Name[i] = customer;
            }
            while (choice != 3)
            {
                if (queue.Size() == 0)
                {
                    Console.WriteLine("Queue is empty");
                }
                Console.WriteLine("\n1 : Deposite Money\n2 : Withdraw Money\n3 : Exit\nEnter your choice");
                double choice = Convert.ToInt16(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Deposite Amount");
                        double deposite = Convert.ToDouble(Console.ReadLine());
                        Amount += deposite;
                        Console.WriteLine("Bank Has :" +Amount);
                        queue.Dequeue();
                        break;
                    case 2:
                        Console.WriteLine("Enter Withdraw Amount");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        if (withdraw > Amount)
                        {
                            Console.WriteLine("Balance is not eficient.....");
                        }
                        else
                        {
                            Amount -= withdraw;
                            Console.WriteLine("Bank Has :" + Amount);
                            queue.Dequeue();
                        }
                        break;
                    default:
                        Console.WriteLine("Oops!!! You select wrong input.");
                        break;
                }
            }
        }
    }
}
