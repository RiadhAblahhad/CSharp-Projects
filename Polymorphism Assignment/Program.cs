using System;

namespace QuittableApp1
{
    // Define the interface with a Quit method
    public interface IQuittable
    {
        void Quit(); // Method to be implemented by a class that can "quit"
    }

    // Employee class implements IQuittable
    public class Employee : IQuittable
    {
        public string Name { get; set; }

        // Implementation of the Quit method from IQuittable
        public void Quit()
        {
            Console.WriteLine($"{Name} has quit the company. Goodbye!"); // Print quitting message
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee instance
            Employee employee = new Employee { Name = "Riadh" };

            // Use polymorphism: IQuittable reference to Employee object
            IQuittable quittable = employee;

            // Call the Quit method via interface reference
            quittable.Quit(); // Output will show that Riadh quit
        }
    }
}
