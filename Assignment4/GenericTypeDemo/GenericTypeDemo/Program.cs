using GenericTypeDemo;
using System;

namespace GenericTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Count: " + stack.Count());

            Console.WriteLine("Popped: " + stack.Pop());
            Console.WriteLine("Popped: " + stack.Pop());

            Console.WriteLine("Count: " + stack.Count());

            MyStack<string> names = new MyStack<string>();

            names.Push("Alice");
            names.Push("Bob");
            names.Push("Charlie");

            Console.WriteLine("\nString Stack:");

            Console.WriteLine("Popped: " + names.Pop());
            Console.WriteLine("Count: " + names.Count());
        }
    }
}