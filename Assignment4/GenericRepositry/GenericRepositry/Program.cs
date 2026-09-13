using System;

namespace GenericRepository
{
    public class Student : Entity
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericRepository<Student> repository =
                new GenericRepository<Student>();

            // Add students
            repository.Add(new Student
            {
                Id = 1,
                Name = "John"
            });

            repository.Add(new Student
            {
                Id = 2,
                Name = "Alice"
            });

            repository.Add(new Student
            {
                Id = 3,
                Name = "Bob"
            });

            // Get all students
            Console.WriteLine("All Students:");

            foreach (Student student in repository.GetAll())
            {
                Console.WriteLine(student.Id + " - " + student.Name);
            }

            // Get student by ID
            Student foundStudent = repository.GetById(2);

            Console.WriteLine("\nStudent with ID 2:");

            if (foundStudent != null)
            {
                Console.WriteLine(foundStudent.Name);
            }

            // Remove student
            repository.Remove(foundStudent);

            Console.WriteLine("\nAfter removing Alice:");

            foreach (Student student in repository.GetAll())
            {
                Console.WriteLine(student.Id + " - " + student.Name);
            }

            // Save
            repository.Save();
        }
    }
}