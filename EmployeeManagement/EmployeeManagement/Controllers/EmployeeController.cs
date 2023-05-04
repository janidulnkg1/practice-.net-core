using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;
using EmployeeManagement.Models;
using Microsoft.Extensions.Configuration;
using System.Runtime.Intrinsics.Arm;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("/employees/getall")]
        public JsonResult Get(){

            string query = @"select * from employee";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            MySqlDataReader myReader;
            using (MySqlConnection myCon = new MySqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
                return new JsonResult(table);
        }

        [HttpPost("/employee/add")]
        public JsonResult Post(int employeeId, string employeeName, string department, string dateOfJoining, string photoFileName)
        {
            string query = @"insert into Employee (EmployeeName,Department,DateofJoining,PhotoFileName) values (@EmployeeName,@Department,@DateofJoining,@PhotoFileName)";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@EmployeeName", employeeName);
                    myCommand.Parameters.AddWithValue("@Department", department);
                    myCommand.Parameters.AddWithValue("@DateofJoining", dateOfJoining);
                    myCommand.Parameters.AddWithValue("@PhotoFileName", photoFileName);


                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();

                }
            }
            return new JsonResult("Employee Added Successfully!");

        }


        [HttpPut("/employee/update")]
        public JsonResult Put(int employeeId,string employeeName, string department, string dateOfJoining,string photoFileName)
        {
            string query = @"update Employee set (EmployeeName,Department,DateofJoining,PhotoFileName) values (@EmployeeName,@Department,@DateofJoining,@PhotoFileName) where EmployeeId=@EmployeeId";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@EmployeeName", employeeName);
                    myCommand.Parameters.AddWithValue("@Department", department);
                    myCommand.Parameters.AddWithValue("@DateofJoining", dateOfJoining);
                    myCommand.Parameters.AddWithValue("@PhotoFileName", photoFileName);
                    myCommand.Parameters.AddWithValue("@EmployeeId", employeeId);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();

                }
            }
            return new JsonResult("Employee Updated Successfully!");
        }

        [HttpDelete("/employee/delete/{id}")]
        public JsonResult Delete(int employeeId)
        {
            string query = @"delete from Employee where EmployeeId=@EmployeeId;";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@EmployeeID", employeeId);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();

                }
            }
            return new JsonResult("Employee Deleted Successfully!");
        }



























    }
}
