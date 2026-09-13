using System;
using System.Collections.Generic;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Interfaces
{
    public interface IDepartmentService
    {
        void AssignHead(Instructor instructor);

        void AddCourse(Course course);

        Instructor GetHead();

        List<Course> GetCourses();

        decimal GetBudget();
    }
}