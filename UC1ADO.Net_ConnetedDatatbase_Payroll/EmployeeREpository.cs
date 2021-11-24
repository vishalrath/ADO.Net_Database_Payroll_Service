using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1ADO.Net_ConnetedDatatbase_Payroll
{
     public class EmployeeREpository
    {

        //uc 1 ADO.NET Connection databse
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee_payroll;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // createdconnection objto connect with database
        SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
