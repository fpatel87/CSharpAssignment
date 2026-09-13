using System;
using SchoolManagementSystem.Interfaces;

namespace SchoolManagementSystem.Models
{
    public class Instructor : Person, IInstructorService
    {
        public DateTime JoinDate { get; set; }

        public Department Department { get; private set; }

        public bool IsHeadOfDepartment { get; set; }

        public decimal ExperienceBonus { get; set; }

        public Instructor(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            decimal salary,
            DateTime joinDate)
            : base(firstName, lastName, dateOfBirth, salary)
        {
            JoinDate = joinDate;
            ExperienceBonus = 0;
        }

        public int CalculateYearsOfExperience()
        {
            DateTime today = DateTime.Today;

            int years = today.Year - JoinDate.Year;

            if (JoinDate.Date > today.AddYears(-years))
            {
                years--;
            }

            return years;
        }

        public void AssignDepartment(Department department)
        {
            if (department == null)
            {
                throw new ArgumentNullException(nameof(department));
            }

            Department = department;
        }

        public override decimal CalculateSalary()
        {
            int yearsOfExperience = CalculateYearsOfExperience();

            decimal bonus = yearsOfExperience * ExperienceBonus;

            return Salary + bonus;
        }
    }
}