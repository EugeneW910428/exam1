
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace BackendExamAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Myoffice_ACPDController : ControllerBase
    {
        private readonly string _connectionString = "Server=<YourServer>;Database=BackendExamHub;User Id=<YourUser>;Password=<YourPassword>;";

        [HttpGet]
        public IActionResult GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = connection.Query("EXEC usp_GetAllMyoffice_ACPD");
                return Ok(result);
            }
        }

        [HttpPost]
        public IActionResult Insert([FromBody] dynamic jsonData)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@InputJson", jsonData.ToString(), DbType.String);

                connection.Execute("EXEC usp_InsertMyoffice_ACPD", parameters);
                return Ok("Record inserted successfully.");
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] dynamic jsonData)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@InputJson", jsonData.ToString(), DbType.String);

                connection.Execute("EXEC usp_UpdateMyoffice_ACPD", parameters);
                return Ok("Record updated successfully.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id, DbType.String);

                connection.Execute("EXEC usp_DeleteMyoffice_ACPD", parameters);
                return Ok("Record deleted successfully.");
            }
        }
    }
}
