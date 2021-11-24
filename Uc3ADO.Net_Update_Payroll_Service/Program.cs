using System;

namespace Uc3ADO.Net_Update_Payroll_Service
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmployeeRepository connection = new EmployeeRepository();
            connection.GetAllEmployeeDetails();
            Console.ReadLine();

            EmployeeModel model = new EmployeeModel();
            model.Name = "tester";
            model.Basic_Pay = 3560.50;
            model.Gender = "M";
            model.StartDate = DateTime.Now;
            //model.id_num = 10;

            EmployeeRepository Repo = new EmployeeRepository();
            Repo.AddEmployee(model);

        }
    }
}
