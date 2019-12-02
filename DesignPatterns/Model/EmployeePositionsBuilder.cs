using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    public class EmployeePositionsBuilder<T> : EmployeeInfoBuilder<EmployeePositionsBuilder<T>> where T : EmployeePositionsBuilder<T>
    {
        //protected Employee _employee = new Employee();
        public T AtPositions(string _positions)
        {
            _employee.Positions = _positions;
            return (T) this;
        }
    }
}
