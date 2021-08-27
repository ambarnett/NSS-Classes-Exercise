using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create an instance of a company. Name it whatever you like.
            // Company company = new Company();
            var deathStar = new Company("Death Star", new DateTime(2021, 01, 01));
            //TODO: Create three employees
            var darthVader = new Employee("Darth", "Vader", "Sith Lord", new DateTime(2021, 01, 01));
            var oldBen = new Employee("Obi-wan", "Kenobi", "Jedi/Hermit", new DateTime(2021, 01, 01));
            var hanSolo = new Employee("Han", "Solo", "Smuggler", new DateTime(2021, 01, 01));

            //TODO: Assign the employees to the company

            deathStar.Employees.Add(darthVader);
            deathStar.Employees.Add(oldBen);
            deathStar.Employees.Add(hanSolo);

            //TODO: Iterate the company's employee list and generate the simple report shown above

            deathStar.ListEmployees();
        }
    }
}
