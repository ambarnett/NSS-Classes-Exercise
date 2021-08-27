using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        //TODO: Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }

        /*
            TODO: Create a constructor method that accepts two arguments:
                TODO: 1. The name of the company
                TODO: 2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string name, DateTime created)
        {
            Name = name;
            CreatedOn = created;
            Employees = new List<Employee>();
        }

        public void ListEmployees()
        {
            foreach(var Employee in Employees)
            {
                Console.WriteLine($"{Employee.FirstName} {Employee.LastName} works for {Name} as {Employee.Title} since {Employee.StartDate}");
            }
        }
    }
}
