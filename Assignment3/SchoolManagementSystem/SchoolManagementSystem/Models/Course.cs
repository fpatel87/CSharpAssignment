using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public class Course
    {
        private readonly List<Student> enrolledStudents;

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public Course(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
            enrolledStudents = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            if (student != null && !enrolledStudents.Contains(student))
            {
                enrolledStudents.Add(student);
            }
        }

        public List<Student> GetEnrolledStudents()
        {
            return new List<Student>(enrolledStudents);
        }

        public override string ToString()
        {
            return $"{CourseId} - {CourseName}";
        }
    }
}