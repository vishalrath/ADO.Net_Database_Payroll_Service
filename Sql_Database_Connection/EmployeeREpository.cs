using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_Database_Connection
{
   public  class EmployeeREpository
    {
        //uc 1 ADO.NET Connection databse
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee_payroll;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // createdconnection objto connect with database
        SqlConnection sqlConnection = new SqlConnection(connectionString);
       public void GetAllEmployeeDetails()
        {
            try
            {
                EmployeeModel model = new EmployeeModel();
                string query = @"select * from employee_payroll";
                //command obj forexecuting query against database
                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                //Executing command obj
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model.EmployeeID = Convert.ToInt32(reader["id"] == DBNull.Value ? default : reader["id"]);
                        model.EmployeeName = reader["name"] == DBNull.Value ? default : reader["name"].ToString();
                        model.BasicPay = Convert.ToDouble(reader["BasicPay"] == DBNull.Value ? default : reader["BasicPay"]);
                        model.StaetDate = (DateTime)((reader["StartDate"] == DBNull.Value ? default(DateTime) : reader["StartDate"]));
                        model.Gender = reader["gender"] == DBNull.Value ? default : reader["gender"].ToString();
                        model.PhoneNumber = Convert.ToDouble(reader["phone"] == DBNull.Value ? default : reader["phone"]);
                        model.Department = reader["department"] == DBNull.Value ? default : reader["department"].ToString();
                        model.Address = reader  ["address"] == DBNull.Value ? default : reader["address"].ToString();
                        model.TaxablePay = Convert.ToDouble(reader["Taxable_Pay"] == DBNull.Value ? default : reader["Taxable_Pay"]);
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",model.EmployeeID,model.EmployeeName,model.BasicPay,model.StaetDate,model.Gender,model.PhoneNumber,model.Department,model.Address,model.TaxablePay);
                        Console.WriteLine(" ");
                    }
                }
                else
                {
                    Console.WriteLine("No rows present");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
