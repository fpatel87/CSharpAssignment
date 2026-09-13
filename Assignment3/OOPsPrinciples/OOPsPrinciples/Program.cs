using System;

namespace OOPsPrinciples
{
    // Abstraction
    abstract class Employee
    {
        // Encapsulation
        private int id;
        private string name;
        private double salary;

        protected Employee(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        // Encapsulation using properties
        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
            }
        }

        // Abstract method
        public abstract double CalculateBonus();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID     : {Id}");
            Console.WriteLine($"Name   : {Name}");
            Console.WriteLine($"Salary : {Salary}");
        }
    }

    // Inheritance
    class Developer : Employee
    {
        public Developer(int id, string name, double salary)
            : base(id, name, salary)
        {
        }

        // Polymorphism - method overriding
        public override double CalculateBonus()
        {
            return Salary * 0.10;
        }
    }

    // Inheritance
    class Manager : Employee
    {
        public Manager(int id, string name, double salary)
            : base(id, name, salary)
        {
        }

        // Polymorphism - method overriding
        public override double CalculateBonus()
        {
            return Salary * 0.20;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            Employee developer = new Developer(101, "John", 70000);
            Employee manager = new Manager(102, "David", 90000);

            Console.WriteLine("Developer Details");
            developer.DisplayDetails();
            Console.WriteLine($"Bonus  : {developer.CalculateBonus()}");

            Console.WriteLine();

            Console.WriteLine("Manager Details");
            manager.DisplayDetails();
            Console.WriteLine($"Bonus  : {manager.CalculateBonus()}");
        }
    }
}