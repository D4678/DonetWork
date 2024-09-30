using System;
using System.Collections.Generic;

delegate bool isPromotable(Employee empl);

class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, isPromotable IsEligiableToPromote)
    {
        foreach (Employee emp in employeeList)
        {
            if (emp.Experience >= 5)
            {
                Console.WriteLine(emp.Name + " " + "Promoted");
            }
        }
    }
}
class Test
{
    public static void Main()
    {
        List<Employee> emplist = new List<Employee>();
        emplist.Add(new Employee() { Id = 101, Name = "John", Experience = 5, Salary = 5000 });
        emplist.Add(new Employee() { Id = 101, Name = "Marry", Experience = 2, Salary = 60000 });
        emplist.Add(new Employee() { Id = 101, Name = "Bob", Experience = 4, Salary = 10000 });
        emplist.Add(new Employee() { Id = 101, Name = "Mariea", Experience = 6, Salary = 2000 });

        Employee.PromoteEmployee(emplist);
    }
}