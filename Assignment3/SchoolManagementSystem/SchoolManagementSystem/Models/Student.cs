using System;
using System.Collections.Generic;
using SchoolManagementSystem.Interfaces;

namespace SchoolManagementSystem.Models
{
    public class Student : Person, IStudentService
    {
        private readonly List<Course> courses;
        private readonly Dictionary<int, char> grades;

        public Student(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            decimal salary)
            : base(firstName, lastName, dateOfBirth, salary)
        {
            courses = new List<Course>();
            grades = new Dictionary<int, char>();
        }

        public void EnrollCourse(Course course, char grade)
        {
            if (course == null)
            {
                throw new ArgumentNullException(nameof(course));
            }

            grade = char.ToUpper(grade);

            if (grade < 'A' || grade > 'F')
            {
                throw new ArgumentException("Grade must be between A and F.");
            }

            if (!courses.Contains(course))
            {
                courses.Add(course);
                grades[course.CourseId] = grade;

                course.EnrollStudent(this);
            }
        }

        public double CalculateGPA()
        {
            if (grades.Count == 0)
            {
                return 0.0;
            }

            double totalPoints = 0;

            foreach (char grade in grades.Values)
            {
                totalPoints += GetGradePoint(grade);
            }

            return totalPoints / grades.Count;
        }

        private double GetGradePoint(char grade)
        {
            switch (grade)
            {
                case 'A':
                    return 4.0;

                case 'B':
                    return 3.0;

                case 'C':
                    return 2.0;

                case 'D':
                    return 1.0;

                case 'F':
                    return 0.0;

                default:
                    return 0.0;
            }
        }

        public List<Course> GetCourses()
        {
            return new List<Course>(courses);
        }
    }
}