using System;
using System.Collections.Generic;

namespace Bconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees employees = new Employees();
            employees.name = "Clin Baton";
            employees.emp_id = "99999";
            employees.position = "Hawk Eyes";
            employees.tel = "09999999999";
            employees.email = "clin.ba@inet.co.th";
            employees.address = "Newyork";

            employees.CreateEmployees();

            List<Employees> employeesList = employees.ShowAllDataEmployees();
            foreach (Employees emp in employeesList)
            {
                Console.WriteLine($"id : {emp.id}");
                Console.WriteLine($"name : {emp.name}");
                Console.WriteLine($"emp_id : {emp.emp_id}");
                Console.WriteLine($"position : {emp.position}");
                Console.WriteLine($"tel : {emp.tel}");
                Console.WriteLine($"email : {emp.email}");
                Console.WriteLine($"address : {emp.address}");
                Console.WriteLine("=====================================");
            }
        }
    }
}
