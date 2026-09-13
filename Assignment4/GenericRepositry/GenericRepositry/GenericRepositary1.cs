using System;
using System.Collections.Generic;

namespace GenericRepository
{
    public class GenericRepository<T> : IRepository<T>
        where T : Entity
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void Save()
        {
            Console.WriteLine("Data saved successfully.");
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }

        public T GetById(int id)
        {
            foreach (T item in items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}