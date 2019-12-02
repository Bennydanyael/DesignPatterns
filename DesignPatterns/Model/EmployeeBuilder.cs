using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    public abstract class EmployeeBuilder
    {
        protected Employee _employee;

        public EmployeeBuilder()
        {
            _employee = new Employee();
        }

        public Employee Build() => _employee;
    }
}
