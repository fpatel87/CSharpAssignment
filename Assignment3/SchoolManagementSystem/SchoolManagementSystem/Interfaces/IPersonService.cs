using SchoolManagementSystem.Models;
using System.Collections.Generic;
using System.Net;

namespace SchoolManagementSystem.Interfaces
{
    public interface IPersonService
    {
        int CalculateAge();
        decimal CalculateSalary();
        List<Address> GetAddresses();
    }
}