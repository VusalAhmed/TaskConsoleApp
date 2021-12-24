using HumanResourceManagement.Moduls;
using System;

namespace HumanResourceManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Fullname = "Ahmadzada Vusal";
            employee.DepartmentName = "Meta Holding";
            employee.Position = "Web Developer";
            employee.Salary = "5000 azn";

            Department department = new Department();
            department.Name = "Meta Holding";
            department.WorkerLimit = "3";
            department.



                employee.Department = department;
        }
    }
}
