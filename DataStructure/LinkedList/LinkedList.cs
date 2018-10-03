using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class LinkedList
    {
        public Node _head;

        public class Node
        {
            public int _data;
            public Node _next;
            public Node(int d)
            {
                _data = d;
                _next = null;

            }
        }

        public void Push(int newData)
        {
            //Push at front
            var newNode = new Node(newData);
            newNode._next = _head;
            _head = newNode;
        }

        public void InsertAfter(Node prevNode, int newData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            //Insert after an array
            Node newNode = new Node(newData);
            newNode._next = prevNode._next;
            prevNode._next = newNode;
        }

        public void Append(int newData)
        {
            //Append at last
            Node newNode = new Node(newData)
            {
                _next = null
            };

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            var lastNode = _head;

            while (lastNode._next != null)
            {
                // var nextNode = lastNode._next;
                lastNode = lastNode._next;
            }

            lastNode._next = newNode;
            return;
        }

        public void DeleteNode(int key)
        {
            Node nodeToDel, prev = null;
            var temp = _head;

            if (temp != null && temp._data == key)
            {
                _head = temp._next; // Changed head 
                return;
            }

            while (temp != null && temp._data != key)
            {
                prev = temp;
                temp = temp._next; 
            }

            if (temp == null) return;

            prev._next = temp._next;
        }

        /* This function prints contents of linked list starting from head */
        public void PrintList()
        {
            Node n = _head;
            while (n != null)
            {
                Console.WriteLine(n._data + " ");
                n = n._next;
            }
        }
    }
}
