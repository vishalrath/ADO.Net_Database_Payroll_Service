﻿using System;

namespace Uc4ADO.Net_UpdateSalary_PayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //EmployeeRepository connection = new EmployeeRepository();
            //connection.GetAllEmployeeDetails();
            //Console.ReadLine();

            EmployeeModel model = new EmployeeModel();
            //model.Name = "terisa";
            //model.Basic_Pay = 300000;
            //model.Gender = "F";
            //model.StartDate = DateTime.Now;
            model.id_num = 9;

            //EmployeeRepository Repo = new EmployeeRepository();
            //Repo.AddEmployee(model);

            //EmployeeRepository Repo = new EmployeeRepository();
            //Repo.UpdateSalary(model);


            EmployeeRepository Repo = new EmployeeRepository();
            Repo.DeleteRecord(model);
            Console.ReadLine();
        }
    }
}
