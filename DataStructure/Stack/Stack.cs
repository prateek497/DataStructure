using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Stack
{
    public class Stack
    {
        private int[] _array;
        private int _lastIndex;
        private int _arraySize;
        public Stack(int arraySize)
        {
            _lastIndex = 0;
            _array = new int[arraySize];
            _arraySize = arraySize;
        }

        public void Push(int item)
        {
            if (_lastIndex == _arraySize)
            {
                Console.WriteLine("Overflow condition");
                return;
            }
            Console.WriteLine(item + " pushed to the stack");
            _array[_lastIndex] = item;
            _lastIndex += 1;
        }

        public int Pop()
        {
            if (_array.Length < 1)
            {
                Console.WriteLine("Underflow condition");
                return 0;
            }

            if (_lastIndex == _arraySize)
                _lastIndex = _lastIndex - 1;
            int removedItem = _array[_lastIndex];
            _array.ToList().RemoveAt(_lastIndex);
            _lastIndex = _lastIndex - 1;
            return removedItem;
        }

        public int Top()
        {
            return _array[_lastIndex];
        }

        public bool IsEmpty()
        {
            if (_array.Length < 1) return true;
            else return false;
        }
    }
}
