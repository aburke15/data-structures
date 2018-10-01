using System;

namespace DataStructures
{
    public class Stack<T>
    {
        private const int INITIAL_SIZE = 5;
        private int _size;
        private T[] _stack;

        public Stack()
        {
            _size = 0;
            _stack = new T[INITIAL_SIZE];
        }

        // add private method to check if stack is empty
        private bool IsEmpty() 
            => _size == 0;

        // method to return size int of stack
        public int Size() 
            => _size;
    }
}