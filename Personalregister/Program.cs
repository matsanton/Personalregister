/*
 * 
 * Uppgift 1: Klasser i programmet:
 * 
 * Employee - En klass för anställda
 * Staff    - En klass för hela personalstyrkan 
 * 
 * Uppgift 2
 * 
 * Employee har attribut:
 *       
 *       Name - Sträng för namnet
 *       Salary - Heltal för lönen
 * 
 * Staff har metoderna:
 * 
 *      AddEmployee() - för att lägga till en anställd i registret
 *      Print()       - för att skriva ut hela registret
 * 
 * 
 * 
 * 
 * 
 * 
 */


using System;

namespace Personalregister
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Staff staff = new Staff();
            
            staff.AddEmployee(new Employee("Mats", 5000));
            staff.AddEmployee(new Employee("Anna", 10000));
            staff.AddEmployee(new Employee("Bertil", 20000));

            do
            {
                PrintMenu();
                key = Console.ReadKey();
                Console.WriteLine();

                switch (key.KeyChar)
                {
                    case '1':
                        staff.AddEmployee(CreateEmployee());
                        break;
                    case '2':
                        staff.Print();
                        break;
                }

            }
            while (key.KeyChar != 'x');
        }

        private static void PrintMenu()
        {
            Console.WriteLine("\n1 - Lägg till anställd");
            Console.WriteLine("2 - Skriv ut registret");
            Console.WriteLine("x - Avsluta\n");
        }

        private static Employee CreateEmployee()
        {
            string name;
            int salary;
            Console.WriteLine("Ange namn:");
            name = Console.ReadLine();
            Console.WriteLine("Ange lön:");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Anställd inlagd i registret");
            return new Employee(name, salary);
            
        }
    }
}
