using EmployeeManagement.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BusinessLogic
{
    public class EmployeeBusinessLogic
    {
        public Employee AddEmployee(Employee employee)
        {
            EmployeeDataAccess employeeDataAccessLayer = new EmployeeDataAccess();

            Console.WriteLine("Enter Employee Id");
            employee.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            employee.Department = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            employee.Salary = Convert.ToInt32( Console.ReadLine());
            return employeeDataAccessLayer.AddEmployee(employee);
        }
        public Employee UpdateEmployee(int EmployeeId, int EmployeeSalary)
        {
            EmployeeDataAccess employeeDataAccessLayer = new EmployeeDataAccess();
            Console.WriteLine("Enter Employee Id whose info You want to update");
            EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Salary you want to update");
            EmployeeSalary = Convert.ToInt32( Console.ReadLine());
            return employeeDataAccessLayer.UpdateEmployee(EmployeeId, EmployeeSalary);
        }
        public Employee GetEmployees(Employee employee)
        {
            EmployeeDataAccess employeeDataAccessLayer = new EmployeeDataAccess();
            return employeeDataAccessLayer.GetEmployees(employee);
        }
        public Employee DeleteEmployee(int EmployeeId)
        {
            EmployeeDataAccess employeeDataAccessLayer = new EmployeeDataAccess();
            Console.WriteLine("Enter Employee Id whose info You want to Delete");
            EmployeeId = int.Parse(Console.ReadLine());
            return employeeDataAccessLayer.DeleteEmployee(EmployeeId);
        }
        
    }
}
