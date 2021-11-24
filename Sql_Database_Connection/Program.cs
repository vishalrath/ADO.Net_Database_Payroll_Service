using System;

namespace Sql_Database_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmployeeREpository connection = new EmployeeREpository();
            connection.GetAllEmployeeDetails();
            Console.ReadLine();
        }
    }
}
