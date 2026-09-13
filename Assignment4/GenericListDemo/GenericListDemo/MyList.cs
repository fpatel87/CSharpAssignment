using System;
using System.Collections.Generic;

namespace GenericListDemo
{
    public class MyList<T>
    {
        private List<T> items = new List<T>();

        // 1. Add
        public void Add(T element)
        {
            items.Add(element);
        }

        // 2. Remove
        public T Remove(int index)
        {
            T element = items[index];
            items.RemoveAt(index);

            return element;
        }

        // 3. Contains
        public bool Contains(T element)
        {
            return items.Contains(element);
        }

        // 4. Clear
        public void Clear()
        {
            items.Clear();
        }

        // 5. InsertAt
        public void InsertAt(T element, int index)
        {
            items.Insert(index, element);
        }

        // 6. DeleteAt
        public void DeleteAt(int index)
        {
            items.RemoveAt(index);
        }

        // 7. Find
        public T Find(int index)
        {
            return items[index];
        }
    }
}