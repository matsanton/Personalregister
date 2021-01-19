using System;
using System.Collections.Generic;
using System.Text;

namespace Personalregister
{
    class Employee
    {
        public int Salary { get; set; }
        public string Name { get; set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }


    }
}
