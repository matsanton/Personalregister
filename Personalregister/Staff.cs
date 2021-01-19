using System;
using System.Collections.Generic;
using System.Text;

namespace Personalregister
{
    class Staff
    {
        private List<Employee> employees;

        public Staff()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void Print()
        {
            foreach (var e in employees)
            {
                Console.WriteLine("{0} har lön {1} ", e.Name, e.Salary);
            }
        }


    }
}
