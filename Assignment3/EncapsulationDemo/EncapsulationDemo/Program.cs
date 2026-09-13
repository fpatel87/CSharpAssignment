using System;

namespace EncapsulationDemo
{
    class Student
    {
        // Private fields - implementation details are hidden
        private int studentId;
        private string name;
        private string email;
        private double gpa;

        public Student(int studentId, string name, string email, double gpa)
        {
            this.studentId = studentId;
            this.name = name;
            this.email = email;
            this.GPA = gpa;
        }

        // Public properties provide controlled access
        public int StudentId
        {
            get { return studentId; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Contains("@"))
                    email = value;
            }
        }

        public double GPA
        {
            get { return gpa; }
            private set
            {
                if (value >= 0 && value <= 4.0)
                    gpa = value;
                else
                    throw new ArgumentException("GPA must be between 0 and 4.0.");
            }
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"GPA: {GPA}");
        }
    }

    class Instructor
    {
        // Private fields
        private int instructorId;
        private string name;
        private string subject;
        private double salary;

        public Instructor(int instructorId, string name, string subject, double salary)
        {
            this.instructorId = instructorId;
            this.name = name;
            this.subject = subject;
            Salary = salary;
        }

        public int InstructorId
        {
            get { return instructorId; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public string Subject
        {
            get { return subject; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    subject = value;
            }
        }

        // Salary can be read publicly but changed only inside the class
        public double Salary
        {
            get { return salary; }
            private set
            {
                if (value > 0)
                    salary = value;
            }
        }

        public void DisplayInstructorDetails()
        {
            Console.WriteLine($"Instructor ID: {InstructorId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(
                101,
                "John",
                "john@example.com",
                3.7
            );

            Instructor instructor = new Instructor(
                201,
                "David",
                "C# Programming",
                75000
            );

            Console.WriteLine("Student Details");
            student.DisplayStudentDetails();

            Console.WriteLine();

            Console.WriteLine("Instructor Details");
            instructor.DisplayInstructorDetails();
        }
    }
}