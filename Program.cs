using System;
using System.Collections.Generic;

namespace Classes
{
    class Program {
        public static void Main( string[] args) {

        //Create a company, and three employees, and then assign the employees to the company.

        Company DesignCo = new Company("Design Co.", DateTime.Now);

        Employee employee1 = new Employee();
        employee1.Name = "Erin Agobert";
        employee1.JobTitle= "Chief Executive Officer";
        employee1.StartDate= DateTime.Now;

        Employee employee2 = new Employee();
        employee2.Name = "Katrina Carter";
        employee2.JobTitle= "Vice President - Marketing";
        employee2.StartDate= DateTime.Now;

        Employee employee3 = new Employee();
        employee3.Name = "Earline Shaw";
        employee3.JobTitle= "Vice President - Finance";
        employee3.StartDate=DateTime.Now;

        List <Employee> DCEmployees = new List <Employee> ();
        DCEmployees.Add(employee1);
        DCEmployees.Add(employee2);
        DCEmployees.Add(employee3);

        //Update the Company class to write the name of each employee to the console. Consider a method named ListEmployees().

        } 
    }
}

