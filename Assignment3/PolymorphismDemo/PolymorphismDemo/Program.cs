using System;

namespace PolymorphismDemo
{
    // Base class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Virtual method that can be overridden by derived classes
        public virtual double CalculateSalary()
        {
            return 0;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    // Derived class
    class Student : Person
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Student(
            string name,
            int age,
            double hourlyRate,
            int hoursWorked)
            : base(name, age)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        // Override salary calculation for Student
        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Student Salary: {CalculateSalary():C}");
        }
    }

    // Derived class
    class Instructor : Person
    {
        public double MonthlySalary { get; set; }
        public double Bonus { get; set; }

        public Instructor(
            string name,
            int age,
            double monthlySalary,
            double bonus)
            : base(name, age)
        {
            MonthlySalary = monthlySalary;
            Bonus = bonus;
        }

        // Override salary calculation for Instructor
        public override double CalculateSalary()
        {
            return MonthlySalary + Bonus;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Instructor Salary: {CalculateSalary():C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            Person student = new Student(
                "John",
                22,
                25,
                80
            );

            Person instructor = new Instructor(
                "David",
                40,
                6000,
                1000
            );

            Console.WriteLine("Student Details");
            student.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("Instructor Details");
            instructor.DisplayDetails();
        }
    }
}