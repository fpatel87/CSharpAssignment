using GenericListDemo;
using System;

namespace GenericListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine("Element at index 1: " + numbers.Find(1));

            Console.WriteLine("Contains 20: " + numbers.Contains(20));

            numbers.InsertAt(15, 1);

            Console.WriteLine("After InsertAt:");
            Console.WriteLine(numbers.Find(0));
            Console.WriteLine(numbers.Find(1));
            Console.WriteLine(numbers.Find(2));
            Console.WriteLine(numbers.Find(3));

            numbers.DeleteAt(2);

            Console.WriteLine("After DeleteAt:");
            Console.WriteLine(numbers.Find(0));
            Console.WriteLine(numbers.Find(1));
            Console.WriteLine(numbers.Find(2));

            int removed = numbers.Remove(0);
            Console.WriteLine("Removed: " + removed);

            numbers.Clear();

            Console.WriteLine("List cleared.");
        }
    }
}