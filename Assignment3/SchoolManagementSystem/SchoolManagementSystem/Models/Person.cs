using System;
using System.Collections.Generic;
using SchoolManagementSystem.Interfaces;

namespace SchoolManagementSystem.Models
{
    public class Person : IPersonService
    {
        private decimal salary;
        private readonly List<Address> addresses;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }

                salary = value;
            }
        }

        public Person(
            string firstName,
            string lastName,
            DateTime dateOfBirth,
            decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Salary = salary;

            addresses = new List<Address>();
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Today;

            int age = today.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        public virtual decimal CalculateSalary()
        {
            return Salary;
        }

        public void AddAddress(Address address)
        {
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            addresses.Add(address);
        }

        public List<Address> GetAddresses()
        {
            return new List<Address>(addresses);
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}