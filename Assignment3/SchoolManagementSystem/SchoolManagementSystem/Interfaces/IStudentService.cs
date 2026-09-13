using System.Collections.Generic;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Interfaces
{
    public interface IStudentService : IPersonService
    {
        void EnrollCourse(Course course, char grade);

        double CalculateGPA();

        List<Course> GetCourses();
    }
}