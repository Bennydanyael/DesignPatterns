using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Model
{
    public class EmployeeBuilderDirector : EmployeeSalaryBuilder<EmployeeBuilderDirector>
    {
        public static EmployeeBuilderDirector NewEmployee => new EmployeeBuilderDirector();
    }
}
