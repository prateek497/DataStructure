using DataStructure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CircularLinkedList circularLinkedList = new CircularLinkedList();
            CircularLinkedList.Node head = null;
            head = circularLinkedList.Push(head, 12);
            head = circularLinkedList.Push(head, 56);
            head = circularLinkedList.Push(head, 2);
            head = circularLinkedList.Push(head, 11);

            circularLinkedList.PrintList(head);

            //LinkedList.DoubleLinledList linkedList = new LinkedList.DoubleLinledList();
            //linkedList.Append(6);
            //linkedList.Push(7);
            //linkedList.Push(1);
            //linkedList.Append(4);

            //linkedList.InsertAfter(linkedList._headNode._nextNode, 8);

            //linkedList.InsertBefore(linkedList._headNode._nextNode, 9);

            //Console.WriteLine("Created DLL is: ");
            //linkedList.Printlist(linkedList._headNode);

            //linkedList.Delete(linkedList._headNode, linkedList._headNode._nextNode);

            //linkedList.Printlist(linkedList._headNode);

            Console.ReadLine();
        }
    }
}
