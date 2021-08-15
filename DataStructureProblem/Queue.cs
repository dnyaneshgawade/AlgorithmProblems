using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem
{
    class Queue<T> where T : IComparable
    {
        Node<T> head;
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("{0} inserted into queue", node.data);
            }
        }
        public T Dequeue()
        {
            T temp = default(T);
            if (this.head == null)
            {
                return default(T);
            }
            else
            {
                while (this.head != null)
                {
                    temp = this.head.data;
                    this.head = this.head.next;
                    return temp;
                }
            }
            return temp;
        }
        
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public bool IsEmpty()
        {
            Node<T> temp = this.head;
            if (temp == null)
                return true;
            return false;
        }
        public int Size()
        {
            int count = 0;
            Node<T> temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
}
