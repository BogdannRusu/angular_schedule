using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace athena.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoriController : ControllerBase
    {
        private IConfiguration _configuration;

        public ProfesoriController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GetProfesori")]
        public JsonResult GetProfesori()
        {
            string sql = "Select * from profesori";
            DataTable table = new DataTable();
            string sqlDataSourse = _configuration.GetConnectionString("BogdanConnection");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDataSourse))
            {
                myCon.Open();
                using(SqlCommand myCommand = new SqlCommand(sql, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();

                }

                return new JsonResult("Sau afisat datele cu succes");
            }
        }
    }
}
