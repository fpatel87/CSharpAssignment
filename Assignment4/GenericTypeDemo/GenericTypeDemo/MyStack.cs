using System;
using System.Collections.Generic;

namespace GenericTypeDemo
{
    public class MyStack<T>
    {
        private List<T> items = new List<T>();

        public int Count()
        {
            return items.Count;
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);

            return item;
        }

        public void Push(T item)
        {
            items.Add(item);
        }
    }
}