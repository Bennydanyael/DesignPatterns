using DesignPatterns.Model;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var _employee = EmployeeBuilderDirector
                .NewEmployee
                .SetName("Benny")
                .AtPositions("Software Developer")
                .WithSalary(3500)
                .Build();

            Console.WriteLine(_employee);
            Console.ReadLine();
            //_employee.SetName("Benny").AtPositions("");
        }
    }
}
