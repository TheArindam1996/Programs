using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmployeeDAL
    {
        ArrayList arl = new ArrayList();
        static Employee emp;
        public bool AddEmployee(Employee e)
        {
            arl.Add(e);
            if (arl.Count > 0)
                return true;
            else
                return false;
        }
        public bool DeleteEmployee(int id)
        {
            for(int i=0;i<arl.Count;i++)
            {
                Employee ep = arl[i] as Employee;
                if (ep.EMPId == id)
                    break;

                else if (i == arl.Count-1)
                    return false;                
            }
            arl.RemoveAt(id);
            return true;
        }
        public string SearchEmployee(int id)
        {
            string empname="";
            for (int i = 0; i < arl.Count; i++)
            {
                Employee ep = arl[i] as Employee;
                if (ep.EMPId == id)
                    empname = ep.EmpName;

                else
                    empname = "Employee does not found";
            }
            return empname;
        }
        static void Main(string[] args)
        {
            bool infy = true;
            emp = new Employee();
            EmployeeDAL edal = new EmployeeDAL();
            int val = 0;
            while(infy)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Delete Employee");
                Console.WriteLine("3. Search Employee");
                Console.WriteLine("4. Exit\n");
                val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1: Console.WriteLine("Enter employee id");
                            emp.EMPId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter employee name");
                            emp.EmpName = Console.ReadLine();
                            Console.WriteLine("Enter employee salary");
                            emp.EmpSalary = double.Parse(Console.ReadLine());
                            if (edal.AddEmployee(emp) == true)
                            Console.WriteLine("Employee Added Successfully\n");                            
                            break;

                    case 2: Console.WriteLine("Enter the employee id to be deleted");
                            if(edal.DeleteEmployee(int.Parse(Console.ReadLine()))==true)
                            Console.WriteLine("Record Deleted\n");
                            else
                            Console.WriteLine("Record does not exist as per the given id\n");
                            break;

                    case 3: Console.WriteLine("Enter the employee id to be searched");
                            Console.WriteLine(edal.SearchEmployee(int.Parse(Console.ReadLine()))+"\n");
                            break;

                    case 4: infy = false;
                            break;
                }
            }
        }
    }
}
