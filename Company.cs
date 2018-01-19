using System;
using System.Collections.Generic;

public class Company
{
    public string Name { get; set; }
    public DateTime CreatedOn { get; set; }

    //Create a constructor method that accepts two arguments: 1. The name of the company and 2. The date it was created

    //Modify the Company class so that you assign employees to a company.

    public Company(string name, DateTime createdOn)
    {

    //The constructor will set the value of the public properties
        Name = name;
        CreatedOn = createdOn;
        Console.WriteLine(name, createdOn);
    }

    // Create a property for holding a list of current employees
    List <Employee> Employees {get; set;}

    // Create a method that allows external code to add an employee
    public void AddEmployee (Employee employee){
        Employees.Add(employee);
    }

    // Create a method that allows external code to remove an employee
    public void RemoveEmployee (Employee employee){
        Employees.Remove(employee);
    }

    //Update the Company class to write the name of each employee to the console. Consider a method named ListEmployees().
    public void ListEmployees(List<Employee> Employees){
        foreach(Employee employee in Employees){
            Console.WriteLine(employee);
        }
    }
}