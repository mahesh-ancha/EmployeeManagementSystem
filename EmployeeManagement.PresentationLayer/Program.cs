using EmployeeManagement.BusinessLogic;
using Entities;
using System;
using System.Data.SqlClient;

namespace EmployeeManagement.PresentationLayer
{
    public class Program
    {

        static void Main(string[] args)
        {
           


            Employee employee = new Employee();
            

            EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();

            Console.WriteLine("Choose the Option:\n");
            while(1>0)
            {
                Console.WriteLine("1.Display Employees\n1.Add Employee\n3.Update Employee\n4.Delete Employee\n5.Exit");
                int ch = int.Parse(Console.ReadLine());

                switch(ch)
                {
                    case 1: employeeBusinessLogic.GetEmployees(employee);
                        break;
                    case 2: employeeBusinessLogic.AddEmployee(employee);
                        break ;
                    default: break;
                    case 3:
                        Employee update = new Employee();
                        update = employeeBusinessLogic.UpdateEmployee(update.Id, update.Salary);
                        Console.WriteLine(update.ToString());
                        break;
                    case 4:
                        Employee delete = new Employee();
                        delete = employeeBusinessLogic.DeleteEmployee(delete.Id);
                        Console.WriteLine(delete.ToString());
                        break;
                }
                if(ch==5)
                    break;
            }
          
        }
    }
}
