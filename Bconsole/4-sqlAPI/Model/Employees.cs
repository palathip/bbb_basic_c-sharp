using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BAPI.Model
{
    public class Employees
    {
        public int id;
        public String name;
//        [StringLength(5,ErrorMessage = "emp_id must have 5 Digit")]
//        [Required]
        public String emp_id; //{ get; set; }
        public String tel;
        public String email;
        public String position;
        public String address;

        private Database database = new Database();

        public List<Employees> ShowAllDataEmployees()
        {
            string queryString = "SELECT * FROM employees";
            DataTable dataTable = database.QueryDB(queryString);
            List<Employees> employeesList = new List<Employees>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Employees employees = new Employees();
                employees.id = int.Parse(dataRow["id"].ToString());
                employees.name = dataRow["name"].ToString();
                employees.emp_id = dataRow["emp_id"].ToString();
                employees.tel = dataRow["tel"].ToString();
                employees.email = dataRow["email"].ToString();
                employees.position = dataRow["position"].ToString();
                employees.address = dataRow["address"].ToString();

                employeesList.Add(employees);
            }

            return employeesList;
        }

        public void CreateEmployees()
        {
            string queryString = "INSERT INTO employees(name,emp_id,tel,email,position,address)" +
                                 $"VALUE('{name}','{emp_id}','{tel}','{email}','{position}','{address}')";
            database.ExecuteDB(queryString);
        }

        public void UpdateEmployee(int id)
        {
            string queryString = $"UPDATE employees SET name = '{name}',emp_id = '{emp_id}',position ='{position}',tel = '{tel}',email='{email}',address='{address}' WHERE id = {id}";
            database.ExecuteDB(queryString);
        }

        public void DeleteEmployee(int id)
        {
            string queryString = $"DELETE from employees WHERE id = {id}";
            database.ExecuteDB(queryString);
        }
    }
}
