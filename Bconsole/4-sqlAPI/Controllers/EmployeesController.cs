using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace BAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllDataEmployee()
        {
            try
            {
                Employees employees = new Employees();
                return Ok(new { result = employees.ShowAllDataEmployees() });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { message = ex.Message })
                {
                    StatusCode = 500
                };
            }
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody]Employees employees)
        {
            try
            {
                employees.CreateEmployees();
            }
            catch (Exception ex)
            {
                return new JsonResult(new { message = ex.Message })
                {
                    StatusCode = 500
                };
            }
            return Ok(new {message = "Create employee"});
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id,[FromBody] Employees employees)
        {
            try
            {
                employees.UpdateEmployee(id);
            }

            catch (Exception ex)
            {
                return  new JsonResult(new{message = ex.Message})
                {
                    StatusCode = 500
                };
            }

            return Ok(new {message = "Update employee"});
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                Employees employees = new Employees();
                employees.DeleteEmployee(id);
            }
            catch (Exception ex)
            {
                return new JsonResult(new { message = ex.Message })
                {
                    StatusCode = 500
                };
            }
            return Ok(new { message = "Delete employee" });
        }

    }
}