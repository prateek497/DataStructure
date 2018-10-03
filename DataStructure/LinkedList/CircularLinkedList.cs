using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class CircularLinkedList
    {
        public Node _head;

        //not yet completed
        public class Node
        {
            public int _data;
            public Node _next;
            public Node(int data)
            {
                _data = data;
            }
        }

        public Node Push(Node head, int data)
        {
            Node newNode = new Node(data);
            Node temp = head;
            var temp1 = temp;

            if (head != null)
            {
                while (temp._next != null)
                {
                    temp = temp._next; 
                }
                temp._next = newNode;
                head = temp;
            }
            else
            {
                head = newNode;
            }

            return head;
        }

        public void PrintList(Node head)
        {
            Node temp = head;
            if (head != null)
            {
                do
                {
                    Console.WriteLine(head._data);
                    temp = temp._next;
                }
                while (temp != head);
            }
        }
    }
}
