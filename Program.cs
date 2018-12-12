using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        string EmployeeName;
        int EmployeeId;
        double Salary;
        public string EmpName
        {
            set
            {
                EmployeeName = value;
            }
            get
            {
                return EmployeeName;
            }
        }
        public int EMPId
        {
            set
            {
                EmployeeId = value;
            }
            get
            {
                return EmployeeId;
            }
        } 
        public double EmpSalary
        {
            set
            {
                Salary = value;
            }
            get
            {
                return Salary;
            }
        }
    }
}
