using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Positions { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Positions : {Positions}, Salary : {Salary}";
        }
    }
}
