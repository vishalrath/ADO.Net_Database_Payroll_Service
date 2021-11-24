using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc4ADO.Net_UpdateSalary_PayrollService
{
    public class EmployeeRepository
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
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model.id_num = Convert.ToInt32(reader["id"] == DBNull.Value ? default : reader["id"]);
                        model.Name = reader["name"] == DBNull.Value ? default : reader["name"].ToString();
                        model.Basic_Pay = Convert.ToDouble(reader["BasicPay"] == DBNull.Value ? default : reader["BasicPay"]);
                        model.StartDate = (DateTime)((reader["StartDate"] == DBNull.Value ? default(DateTime) : reader["StartDate"]));
                        model.Gender = reader["gender"] == DBNull.Value ? default : reader["gender"].ToString();
                        model.PhoneNumber = Convert.ToDouble(reader["phone"] == DBNull.Value ? default : reader["phone"]);
                        model.Department = reader["department"] == DBNull.Value ? default : reader["department"].ToString();
                        model.Address = reader["address"] == DBNull.Value ? default : reader["address"].ToString();
                        model.TaxablePay = Convert.ToDouble(reader["Taxable_Pay"] == DBNull.Value ? default : reader["Taxable_Pay"]);
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", model.id_num, model.Name, model.Basic_Pay, model.StartDate, model.Gender, model.PhoneNumber, model.Department, model.Address, model.TaxablePay);
                        Console.WriteLine(" ");
                    }
                }
                else
                {
                    Console.WriteLine("No rows present");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void AddEmployee(EmployeeModel model)
        {
            try
            {
                using (this.sqlConnection)
                {
                    SqlCommand command = new SqlCommand("dbo.spAddEmployeeDetails2", this.sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@name", model.Name);
                    command.Parameters.AddWithValue("@Basic_Pay", model.Basic_Pay);
                    //command.Parameters.AddWithValue("@EmployeeId", model.id_num);
                    command.Parameters.AddWithValue("@StartDate", model.StartDate);
                    //command.Parameters.AddWithValue("@Salary", model.Salary);
                    //command.Parameters.AddWithValue("@Phone", model.PhoneNumber);
                    // command.Parameters.AddWithValue("@address", model.Address);
                    //command.Parameters.AddWithValue("@department", model.Department);
                    command.Parameters.AddWithValue("@gender", model.Gender);
                    //command.Parameters.AddWithValue("@Deduction", model.Deduction);
                    //command.Parameters.AddWithValue("@NetPay", model.NetPay);
                    //command.Parameters.AddWithValue("@incomeTax", model.IncomeTax);
                    //command.Parameters.AddWithValue("@Taxable_pay", model.TaxablePay);
                    sqlConnection.Open();
                    var result = command.ExecuteNonQuery();

                    if (result != 0)
                    {
                        Console.WriteLine("Succesfull inserted record");
                    }
                    else
                    {
                        Console.WriteLine("Unsuccesfull");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        // updete record
        public void UpdateSalary(EmployeeModel model)
        {
            try
            {

                using (this.sqlConnection)
            {
                    EmployeeModel displeymodel = new EmployeeModel();
                SqlCommand command = new SqlCommand("dbo.spUpdateEmployeeDetails", this.sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name", model.Name);
                command.Parameters.AddWithValue("@Basic_Pay", model.Basic_Pay);
                //command.Parameters.AddWithValue("@EmployeeId", model.id_num);
                //command.Parameters.AddWithValue("@StartDate", model.StartDate);
                //command.Parameters.AddWithValue("@Salary", model.Salary);
                //command.Parameters.AddWithValue("@Phone", model.PhoneNumber);
                // command.Parameters.AddWithValue("@address", model.Address);
                //command.Parameters.AddWithValue("@department", model.Department);
                //command.Parameters.AddWithValue("@gender", model.Gender);
                //command.Parameters.AddWithValue("@Deduction", model.Deduction);
                //command.Parameters.AddWithValue("@NetPay", model.NetPay);
                //command.Parameters.AddWithValue("@incomeTax", model.IncomeTax);
                //command.Parameters.AddWithValue("@Taxable_pay", model.TaxablePay);
                sqlConnection.Open();
                var result = command.ExecuteNonQuery();

                if (result != 0)
                {
                    Console.WriteLine("Succesfull Updeted record");
                }
                else
                {
                    Console.WriteLine("Unsuccesfull");
                }
            }
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        public void DeleteRecord(EmployeeModel model)
        {
            try
            {

                using (this.sqlConnection)
                {
                    EmployeeModel displeymodel = new EmployeeModel();
                    SqlCommand command = new SqlCommand("dbo.spDeleteEmployeeDetails1", this.sqlConnection);
                    command.CommandType = CommandType.StoredProcedure;
                    //command.Parameters.AddWithValue("@name", model.Name);
                    //command.Parameters.AddWithValue("@Basic_Pay", model.Basic_Pay);
                    command.Parameters.AddWithValue("@id_num", model.id_num);
                    //command.Parameters.AddWithValue("@StartDate", model.StartDate);
                    //command.Parameters.AddWithValue("@Salary", model.Salary);
                    //command.Parameters.AddWithValue("@Phone", model.PhoneNumber);
                    // command.Parameters.AddWithValue("@address", model.Address);
                    //command.Parameters.AddWithValue("@department", model.Department);
                    //command.Parameters.AddWithValue("@gender", model.Gender);
                    //command.Parameters.AddWithValue("@Deduction", model.Deduction);
                    //command.Parameters.AddWithValue("@NetPay", model.NetPay);
                    //command.Parameters.AddWithValue("@incomeTax", model.IncomeTax);
                    //command.Parameters.AddWithValue("@Taxable_pay", model.TaxablePay);
                    sqlConnection.Open();
                    var result = command.ExecuteNonQuery();

                    if (result != 0)
                    {
                        Console.WriteLine("Succesfull Deleted record");
                    }
                    else
                    {
                        Console.WriteLine("Unsuccesfull");
                    }
                }
            }
            catch (Exception ex)
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
