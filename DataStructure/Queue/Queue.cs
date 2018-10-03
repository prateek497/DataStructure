using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Queue
{
    public class Queue
    {
        private int[] _array;
        private int _arraySize;
        private int _front, _rear = 0;

        public Queue(int arraySize)
        {
            _array = new int[arraySize];
            _arraySize = arraySize;
        }

        public void Enqueue(int item)
        {
            if (_rear == _arraySize - 1 && _array[_arraySize - 1] > 0)
            {
                Console.WriteLine("Overflow condition");
                return;
            }

            Console.WriteLine(item + " enqueue to the queue");
            _array[_rear] = item;
            if (_arraySize != _rear + 1)
                _rear += 1;
        }

        public int Dequeue()
        {
            if (_front == _arraySize - 1 && _array[_arraySize - 1] == 0)
            {
                Console.WriteLine("Underflow condition");
                return 0;
            }

            var removedItem = _array[_front];
            _array[_front] = 0;
            if (_arraySize != _front + 1)
                _front += 1;
            return removedItem;
        }

        public int Front()
        {
            return _array[_front];
        }

        public int Rear()
        {
            return _array[_rear];
        }
    }
}
