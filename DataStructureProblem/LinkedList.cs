using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem
{
    public class LinkedList<T> where T : IComparable
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void Display()
        {
            Node<T> temp = head;
            if (temp == null)
            {
                Console.WriteLine("linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        
        public int Search(T value)
        {
            Node<T> node = this.head;
            int count = 0;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    return count;
                }
                node = node.next;
                count++;

            }
            return count;
        }
        public void Delete(T data)
        {
            Node<T> temp = head;
            Node<T> prev = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else if (temp.data.Equals(data))
            {
                head = temp.next;
                return;
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data.Equals(data))
                    {
                        prev.next = temp.next;
                        Console.WriteLine("Deleted " + temp.data);
                        return;
                    }
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("Empty");
                }
            }
        }
            
    }
    /*public class LinkedList<T> where T : IComparable
    {
        static readonly string textFile = @"E:\Bridglabz\Algorithm_Programs\Algorithm_Programs\UnorderedText.txt";
        static readonly string textFile2 = @"E:\Bridglabz\Algorithm_Programs\Algorithm_Programs\OrderedNumbers.txt";
        Node<T> head = null;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("Inserted " + node.data);
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Inserted " + node.data);
            }
        }

        public void DisplayUnordered()
        {
            Node<T> temp = head;
            File.WriteAllText(textFile, String.Empty);
            while (temp != null)
            {
                using (StreamWriter stream = new StreamWriter(textFile, true))
                    stream.Write(temp.data + ",");
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public void DisplayOrdered()
        {
            Node<T> temp = head;
            File.WriteAllText(textFile2, String.Empty);
            while (temp != null)
            {
                using (StreamWriter stream = new StreamWriter(textFile2, true))
                    stream.Write(temp.data + ",");
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public void Delete(T data)
        {
            Node<T> temp = head;
            Node<T> prev = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else if (temp.data.Equals(data))
            {
                head = temp.next;
                return;
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data.Equals(data))
                    {
                        prev.next = temp.next;
                        Console.WriteLine("Deleted " + temp.data);
                        return;
                    }
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("Empty");
                }
            }
        }
    }*/
}
