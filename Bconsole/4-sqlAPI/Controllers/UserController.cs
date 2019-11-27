using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt; //สร้าง Token
using Microsoft.IdentityModel.Tokens; // สร้างตัวเข้ารหัส Token
using System.Security.Claims;
using System.Text;
using BAPI.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

// สร้าง Body Token

namespace BAPI.Controllers
{
    [Route("api/[controller]")]// API login Path
    [ApiController]
    public class UserController : ControllerBase
    {
        // อ่าน config จาก appsetting.json
        private readonly IConfiguration _configuration;

        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody]User user)
        {
            if (user.username.Trim() == "hdyuser" && user.password.Trim() == "hdypass")
            {
                List<Claim> claimsList = new List<Claim>();
                claimsList.Add(new Claim("username", user.username));

                //เตรียมคีย์เอาไว้เข้ารหัสสร้าง Token
                SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Key"]));
                SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
                
                // ระยะเวลา Token
                DateTime expiresDate = DateTime.Now.AddDays(Double.Parse(_configuration["Expires"]));
                
                // สร้าง token
                JwtSecurityToken token = new JwtSecurityToken(
                    issuer: _configuration["Expires"],
                    audience: _configuration["Audience"],
                    claims: claimsList,
                    expires: expiresDate,
                    signingCredentials: credentials

                    );
                string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(new {token = tokenString});
            }
            else
            {
                return new JsonResult(new {messeage = "Invalid Username or Password"})
                    {StatusCode = 401};
            }
            
        }

        [Route("register")] // API Register Path 
        [HttpPost]
        public IActionResult Register([FromBody] User user)
        {
            try
            {
                user.Register();
                return  new JsonResult(new{ message = "Register User Success"})
                    {StatusCode = 201};
            }
            catch (Exception ex)
            {
                return new JsonResult(new { message = ex.Message})
                    {StatusCode = 500};
            }
        }

    }

    public class User
    {
        public string username;
        public string password;
        public string name;
        Database database = new Database();

        public void Register()
        {
            string queryString = $"INSERT INTO users (username,password,name)" +
                                 $"VALUES ('{username}','{password}','{name}')";
            
            database.ExecuteDB(queryString);
        }

        // wait to continue

//        public bool checkUser()
//        {
//            string queryString = $"SELECT * FROM users WHERE username=";
//            database.ExecuteDB(queryString);
//        }

    }
}