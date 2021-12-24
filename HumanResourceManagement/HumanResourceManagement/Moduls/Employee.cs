using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourceManagement.Moduls
{
    class Employee
    {
        public static int count = 1000;
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public string DepartmentName { get; set; }
        public Department Department { get; set; }
        
        public Employee(string fullname, string position, string salary,string departmentname)
        {
            Fullname = fullname;
            Position = position;
            Salary = salary;
            DepartmentName = departmentname;
        }


        public override string ToString()
        {
            return $" {Fullname} {Position} {Salary} {DepartmentName}";

        }



    }
}
