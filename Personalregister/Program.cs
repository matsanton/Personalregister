using System;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();
            
            staff.AddEmployee(new Employee("Mats", 5000));
            staff.AddEmployee(new Employee("Anna", 10000));
            staff.AddEmployee(new Employee("Bertil", 20000));

            staff.Print();

        }
    }
}
