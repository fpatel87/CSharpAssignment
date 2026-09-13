using System;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create courses
            Course csharp = new Course(101, "C# Programming");
            Course database = new Course(102, "Database Systems");
            Course webApi = new Course(103, "Web API Development");

            // Create a student
            Student student = new Student(
                "John",
                "Smith",
                new DateTime(2000, 5, 15),
                0
            );

            // Add addresses
            student.AddAddress(
                new Address(
                    "123 Main Street",
                    "College Station",
                    "Texas",
                    "77840"
                )
            );

            student.AddAddress(
                new Address(
                    "456 Oak Avenue",
                    "Houston",
                    "Texas",
                    "77001"
                )
            );

            // Enroll student in courses
            student.EnrollCourse(csharp, 'A');
            student.EnrollCourse(database, 'B');
            student.EnrollCourse(webApi, 'A');

            // Create instructor
            Instructor instructor = new Instructor(
                "David",
                "Johnson",
                new DateTime(1985, 3, 10),
                70000m,
                new DateTime(2015, 6, 1)
            );

            instructor.ExperienceBonus = 1000m;

            // Create department
            Department department = new Department(
                1,
                "Computer Science",
                500000m,
                new DateTime(2026, 1, 1),
                new DateTime(2026, 12, 31)
            );

            // Assign instructor as department head
            department.AssignHead(instructor);

            // Add courses to department
            department.AddCourse(csharp);
            department.AddCourse(database);
            department.AddCourse(webApi);

            // Display student information
            Console.WriteLine("===== STUDENT INFORMATION =====");
            Console.WriteLine($"Name: {student.GetFullName()}");
            Console.WriteLine($"Age: {student.CalculateAge()}");
            Console.WriteLine($"GPA: {student.CalculateGPA():F2}");

            Console.WriteLine("\nCourses:");
            foreach (Course course in student.GetCourses())
            {
                Console.WriteLine($"- {course}");
            }

            Console.WriteLine("\nAddresses:");
            foreach (Address address in student.GetAddresses())
            {
                Console.WriteLine($"- {address}");
            }

            // Display instructor information
            Console.WriteLine("\n===== INSTRUCTOR INFORMATION =====");
            Console.WriteLine($"Name: {instructor.GetFullName()}");
            Console.WriteLine($"Age: {instructor.CalculateAge()}");
            Console.WriteLine(
                $"Years of Experience: {instructor.CalculateYearsOfExperience()}"
            );
            Console.WriteLine(
                $"Salary with Bonus: {instructor.CalculateSalary():C}"
            );
            Console.WriteLine(
                $"Department: {instructor.Department.DepartmentName}"
            );
            Console.WriteLine(
                $"Head of Department: {instructor.IsHeadOfDepartment}"
            );

            // Display department information
            Console.WriteLine("\n===== DEPARTMENT INFORMATION =====");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Head: {department.GetHead().GetFullName()}");
            Console.WriteLine($"Budget: {department.GetBudget():C}");
            Console.WriteLine(
                $"Budget Start: {department.BudgetStartDate:d}"
            );
            Console.WriteLine(
                $"Budget End: {department.BudgetEndDate:d}"
            );

            Console.WriteLine("\nCourses Offered:");
            foreach (Course course in department.GetCourses())
            {
                Console.WriteLine($"- {course}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}