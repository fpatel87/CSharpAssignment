using System.Collections.Generic;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Interfaces
{
    public interface ICourseService
    {
        void EnrollStudent(Student student);

        List<Student> GetEnrolledStudents();
    }
}