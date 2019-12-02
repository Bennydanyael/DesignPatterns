using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    public class EmployeeInfoBuilder<T> : EmployeeBuilder where T : EmployeeInfoBuilder<T>
    {
        //protected Employee _employee = new Employee();

        public T SetName(string _name)
        {
            _employee.Name = _name;
            return (T) this;
        }
    }
}
