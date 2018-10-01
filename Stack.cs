using System;

namespace DataStructures
{
    public class Stack<T>
    {
        private const int INITIAL_SIZE = 2;
        private int size;
        private T[] stack;

        public Stack()
        {
            size = 0;
            stack = new T[INITIAL_SIZE];
        }

        // method that resizes the array
        private void Resize(int newSize)
        {
            
        }

        // method to push an item T onto the stack
        public void Push(T item)
        {
            if (size == stack.Length)
                Resize(stack.Length * 2);

            stack[size++] = item;
        }

        // add private method to check if stack is empty
        private bool IsEmpty() 
            => size == 0;

        // method to return size int of stack
        public int Size() 
            => size;
    }
}