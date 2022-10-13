using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccess
{
    public class EmployeeDataAccess
    {
        SqlConnection sqlConnection;
        string ConnectionString = @"Data Source=MAHESh;Initial Catalog=EmployeeDB;Integrated Security=True;
                           Encrypt=True;TrustServerCertificate=True;User Instance=False";

        public Employee AddEmployee(Employee employee)
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string insetQuery = "insert into Employee(Id,Name,Department,Salary,Age) values(" + employee.Id + ",'" + employee.Name + "','" + employee.Department + "','" + employee.Salary + "','" + employee.Age + "')";
            SqlCommand cmd = new SqlCommand(insetQuery, sqlConnection);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Data Inserted Successfully");
            return employee;
        }
        public Employee UpdateEmployee(int EmployeeId, int EmployeeSalary)
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string updateQuery = "update Employee set EmployeeSalary=" + EmployeeSalary + "where EmployeeId=" + EmployeeId + "";
            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("Updated The Data");

            Employee updateEmployee = new Employee();
            return updateEmployee;
        }
        public Employee GetEmployees(Employee employee)
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string displayQuery = "select *from Employee";
            SqlCommand displayCommand = new SqlCommand(displayQuery, sqlConnection);
            SqlDataReader dataReader = displayCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine("Emp id:" + dataReader.GetValue(0).ToString());
                Console.WriteLine("Emp name:" + dataReader.GetValue(1).ToString());
                Console.WriteLine("Emp dept:" + dataReader.GetValue(2).ToString());
                Console.WriteLine("Emp sal:" + dataReader.GetValue(3).ToString());
                Console.WriteLine("Emp Age:" + dataReader.GetValue(4).ToString());

                Console.WriteLine("----");
            }
            dataReader.Close();
            Console.WriteLine("Read Completed");
            return employee;

        }
        public Employee DeleteEmployee(int EmployeeId)
        {
            sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string deleteQuery = "Delete from Employee where EmployeeId=" + EmployeeId;
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("Deleted Successfully");
            Employee deleteEmployee = new Employee();
            return deleteEmployee;
        }

        
    }
}
