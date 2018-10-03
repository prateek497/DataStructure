using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class DoubleLinledList
    {
        public Node _headNode;
        public Node _lastNode;

        public void Push(int data)
        {
            Node newNode = new Node(data);

            //If head is null
            if (_headNode == null)
                _headNode = newNode;

            var tempHead = _headNode;
            tempHead._prevNode = newNode;
            newNode._nextNode = tempHead;
            _headNode = newNode;

        }

        public void InsertAfter(Node prevNode, int data)
        {
            Node newNode = new Node(data);

            if (prevNode == null)
            {
                Console.WriteLine("The previous node cannot be null");
                return;
            }

            newNode._prevNode = prevNode;
            newNode._nextNode = prevNode._nextNode;
            prevNode._nextNode = newNode;

            if (newNode._nextNode != null)
                newNode._nextNode._prevNode = newNode;
        }

        public void Append(int data)
        {
            Node newNode = new Node(data);

            if (_headNode == null)
            {
                _headNode = newNode;
                return;
            }

            var tempNode = _headNode;

            while (tempNode._nextNode != null)
            {
                tempNode = tempNode._nextNode;
            }

            tempNode._nextNode = newNode;
            newNode._prevNode = tempNode;
        }

        public void InsertBefore(Node nextNode, int data)
        {
            Node newNode = new Node(data);

            if (nextNode == null)
            {
                Console.WriteLine("The next node should not be null");
            }

            newNode._nextNode = nextNode;
            newNode._prevNode = nextNode._prevNode;
            nextNode._prevNode = newNode;

            if (newNode._prevNode != null)
                newNode._prevNode._nextNode = newNode;
        }

        public void Delete(Node headNode, Node delNode)
        {
            if (delNode == null || headNode == null)
            {
                Console.WriteLine("Delete node should be null");
            }

            if (headNode == delNode)
            {
                _headNode = delNode._nextNode;
            }

            if (delNode._nextNode != null)
            {
                delNode._nextNode._prevNode = delNode._prevNode;
            }

            if (delNode._prevNode != null)
            {
                delNode._prevNode._nextNode = delNode._nextNode;
            }
        }

        public class Node
        {
            public int _data;
            public Node _prevNode;
            public Node _nextNode;

            public Node(int data)
            {
                _data = data;
            }
        }

        // This function prints contents of linked list starting from the given node 
        public void Printlist(Node node)
        {
            Node last = null;
            Console.WriteLine("Traversal in forward Direction");
            while (node != null)
            {
                Console.WriteLine(node._data + " ");
                last = node;
                node = node._nextNode;
            }
            Console.WriteLine("");
            Console.WriteLine("Traversal in reverse direction");
            while (last != null)
            {
                Console.WriteLine(last._data + " ");
                last = last._prevNode;
            }
        }

    }
}
