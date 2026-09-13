using System;

namespace AbstractionDemo
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void DisplayRole();
    }

    class Student : Person
    {
        public string Major { get; set; }

        public Student(string name, int age, string major)
            : base(name, age)
        {
            Major = major;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"{Name} is a Student studying {Major}.");
        }

        public void AttendClass()
        {
            Console.WriteLine($"{Name} is attending a class.");
        }
    }

    class Instructor : Person
    {
        public string Subject { get; set; }

        public Instructor(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"{Name} is an Instructor teaching {Subject}.");
        }

        public void TeachClass()
        {
            Console.WriteLine($"{Name} is teaching a class.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(
                "John",
                22,
                "Information Technology"
            );

            Instructor instructor = new Instructor(
                "David",
                40,
                "C# Programming"
            );

            student.DisplayRole();
            student.AttendClass();

            Console.WriteLine();

            instructor.DisplayRole();
            instructor.TeachClass();
        }
    }
}