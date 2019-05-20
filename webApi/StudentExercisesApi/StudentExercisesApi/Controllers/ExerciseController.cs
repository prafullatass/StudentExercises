using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StudentExercisesApi.Model;

namespace StudentExercisesApi.Controllers
{
    [Route("exercise/[controller]")]
    [ApiController]
    public class ExerciseController : Controller
    {
        
        private readonly IConfiguration _config;

        public ExerciseController(IConfiguration config)
        {
            _config = config;
        }

        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Title, Language FROM Exercise";
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<Exercise> exercises = new List<Exercise>();

                    while (reader.Read())
                    {
                        Exercise exercise = new Exercise
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Language = reader.GetString(reader.GetOrdinal("Language"))
                        };

                    exercises.Add(exercise);
                    }
                    reader.Close();

                    return Ok(exercises);
                }
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get ([FromRoute] int id)
        {
            using(SqlConnection conn = Connection)
            {
                conn.Open();
                Exercise ex = null;
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Title, Language FROM Exercise where Id = @id";
                    cmd.Parameters.Add(new SqlParameter("@id", id));
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ex = new Exercise()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Language = reader.GetString(reader.GetOrdinal("Language"))
                        };
                    }
                    else
                        return new StatusCodeResult(StatusCodes.Status404NotFound);
                    reader.Close();
                }
                return Ok(ex);
            }
        }

        //[HttpPost ]
    }
}