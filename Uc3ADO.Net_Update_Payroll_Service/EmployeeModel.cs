using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc3ADO.Net_Update_Payroll_Service
{
     public class EmployeeModel
    {
        public int id_num { get; set; }
        public string Name { get; set; }
        public double PhoneNumber { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public double Basic_Pay { get; set; }
        public string Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public string NetPay { get; set; }
        public DateTime StartDate { get; set; }
    }
}
