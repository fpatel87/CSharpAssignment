using System;

namespace SchoolManagementSystem.Interfaces
{
    public interface IInstructorService : IPersonService
    {
        int CalculateYearsOfExperience();

        void AssignDepartment(Models.Department department);

        bool IsHeadOfDepartment { get; set; }
    }
}