using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using StudentExercises.Model;

namespace StudentExercises.Data
{
    public class Repository
    {
        public SqlConnection Connection
        {
            get
            {
                string _connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=StudentExercises;Integrated Security=True";
                return new SqlConnection(_connectionString);
            }
        }

        public List<Cohort> GetCohorts()
        {
            List<Cohort> cohorts = new List<Cohort>();
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from Cohort";
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        cohorts.Add(new Cohort
                        {
                            Id = Reader.GetInt32(Reader.GetOrdinal("Id")),
                            CohortName = Reader.GetString(Reader.GetOrdinal("CohortName"))
                        });
                    }
                    Reader.Close();
                }
            }
            return cohorts;
        }

        public List<Exercise> GetExercises()
        {
            List<Exercise> exercises = new List<Exercise>();
            using (SqlConnection conn = Connection)
            {

                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from Exercise";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        exercises.Add(new Exercise
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Language = reader.GetString(reader.GetOrdinal("Language"))
                        });
                    }
                    reader.Close();
                }
            }
            return exercises;
        }
        public List<Instructor> GetInstructors ()
        {
            List<Instructor> instuctors = new List<Instructor>();
            using(SqlConnection conn = Connection)
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT i.Id,        
                                        i.FirstName,
                                        i.LastName,
                                        i.SlackHandle,
                                        i.Specality,
                                        c.Id CohortId,
                                        c.CohortName
                                        From Instructor i Join Cohort c on i.CohortId = c.Id";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        instuctors.Add(new Instructor
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            SlackHandle = reader.GetString(reader.GetOrdinal("SlackHandle")),
                            Specality = reader.GetString(reader.GetOrdinal("Specality")),
                            Cohort = new Cohort
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("CohortId")),
                                CohortName = reader.GetString(reader.GetOrdinal("CohortName"))
                            }
                        });
                    }
                    reader.Close();
                }
            }
            return instuctors;
        }
    }
}
