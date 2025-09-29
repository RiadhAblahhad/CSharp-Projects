using System;

namespace EmployeeEqualityApp1
{
    // Employee class representing a worker in a company
    public class Employee
    {
        // Unique identifier for the employee
        public int Id { get; set; }

        // Employee's first name
        public string FirstName { get; set; }

        // Employee's last name
        public string LastName { get; set; }

        // Overloading the '==' operator to compare employee Ids
        public static bool operator ==(Employee e1, Employee e2)
        {
            // Handle nulls explicitly
            if (ReferenceEquals(e1, null) && ReferenceEquals(e2, null)) return true;
            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null)) return false;

            return e1.Id == e2.Id;
        }

        // Overloading the '!=' operator in pair with '=='
        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
        }

        // Override Equals for consistency
        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            return this == other;
        }

        // Override GetHashCode when overriding Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create first employee instance
            Employee emp1 = new Employee
            {
                Id = 101,
                FirstName = "Riadh",
                LastName = "Ablahad"
            };

            // Create second employee instance
            Employee emp2 = new Employee
            {
                Id = 102,
                FirstName = "whinnie",
                LastName = "The Pooh"
            };

            // Compare employees using overloaded ==
            Console.WriteLine("emp1 == emp2: " + (emp1 == emp2));

            // Compare using overloaded !=
            Console.WriteLine("emp1 != emp2: " + (emp1 != emp2));
        }
    }
}
