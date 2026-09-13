using System;
using System.Collections.Generic;
using SchoolManagementSystem.Interfaces;

namespace SchoolManagementSystem.Models
{
    public class Department : IDepartmentService
    {
        private readonly List<Course> courses;

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public Instructor Head { get; private set; }

        public decimal Budget { get; private set; }

        public DateTime BudgetStartDate { get; private set; }

        public DateTime BudgetEndDate { get; private set; }

        public Department(
            int departmentId,
            string departmentName,
            decimal budget,
            DateTime budgetStartDate,
            DateTime budgetEndDate)
        {
            if (budget < 0)
            {
                throw new ArgumentException("Budget cannot be negative.");
            }

            if (budgetEndDate < budgetStartDate)
            {
                throw new ArgumentException(
                    "Budget end date cannot be before the start date.");
            }

            DepartmentId = departmentId;
            DepartmentName = departmentName;
            Budget = budget;
            BudgetStartDate = budgetStartDate;
            BudgetEndDate = budgetEndDate;

            courses = new List<Course>();
        }

        public void AssignHead(Instructor instructor)
        {
            if (instructor == null)
            {
                throw new ArgumentNullException(nameof(instructor));
            }

            Head = instructor;

            instructor.AssignDepartment(this);
            instructor.IsHeadOfDepartment = true;
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(nameof(course));
            }

            if (!courses.Contains(course))
            {
                courses.Add(course);
            }
        }

        public Instructor GetHead()
        {
            return Head;
        }

        public List<Course> GetCourses()
        {
            return new List<Course>(courses);
        }

        public decimal GetBudget()
        {
            return Budget;
        }

        public override string ToString()
        {
            return $"{DepartmentId} - {DepartmentName}";
        }
    }
}