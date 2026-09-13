using System;

namespace InheritanceDemo
{
    // Base class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }

        public void DisplayBasicInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    // Student inherits from Person
    class Student : Person
    {
        public int StudentId { get; set; }
        public string Major { get; set; }

        public Student(
            int studentId,
            string name,
            int age,
            string email,
            string major)
            : base(name, age, email)
        {
            StudentId = studentId;
            Major = major;
        }

        public void DisplayStudentDetails()
        {
            DisplayBasicInformation();
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Major: {Major}");
        }
    }

    // Instructor inherits from Person
    class Instructor : Person
    {
        public int InstructorId { get; set; }
        public string Subject { get; set; }

        public Instructor(
            int instructorId,
            string name,
            int age,
            string email,
            string subject)
            : base(name, age, email)
        {
            InstructorId = instructorId;
            Subject = subject;
        }

        public void DisplayInstructorDetails()
        {
            DisplayBasicInformation();
            Console.WriteLine($"Instructor ID: {InstructorId}");
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(
                101,
                "John",
                22,
                "john@example.com",
                "Information Technology"
            );

            Instructor instructor = new Instructor(
                201,
                "David",
                40,
                "david@example.com",
                "C# Programming"
            );

            Console.WriteLine("Student Details");
            student.DisplayStudentDetails();

            Console.WriteLine();

            Console.WriteLine("Instructor Details");
            instructor.DisplayInstructorDetails();
        }
    }
}