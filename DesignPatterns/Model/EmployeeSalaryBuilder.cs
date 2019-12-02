using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    public class EmployeeSalaryBuilder<T> : EmployeePositionsBuilder<EmployeeSalaryBuilder<T>> where T : EmployeeSalaryBuilder<T>
    {
        //protected Employee _employee = new Employee();

        public T WithSalary(double _salary)
        {
            _employee.Salary = _salary;
            return (T)this;
        }
    }
}
