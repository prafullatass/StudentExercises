using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using StudentExercises.Model;

namespace StudentExercises.Data
{
    public class Repository
    {
           //Make Connection to database
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
            //establish connection
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    //set the commnad
                    cmd.CommandText = "SELECT * from Cohort";
                    //execute it and store data in reader
                    SqlDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        //for each row of data store it in List
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

        public List<Student> GetStudents ()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT s.Id,
                                        s.FirstName,
                                        s.LastName,
                                        s.SlackHandle,
                                        s.CohortId ,
                                        c.CohortName
                                        FROM Student s join Cohort c on s.CohortId = c.Id ";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            SlackHandle = reader.GetString(reader.GetOrdinal("SlackHandle")),
                            Cohort = new Cohort
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("CohortId")),
                                CohortName = reader.GetString(reader.GetOrdinal("CohortName"))
                            }
                        });
                    }
                    reader.Close();
                }
                return students;
            }
        }

        public List<StudentExercise> GetStudentExercise()
        {
            List<StudentExercise> studentExercises = new List<StudentExercise>();
            
            using(SqlConnection conn = Connection)
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"select se.StudentId, se.Id,
                                            se.ExerciseId, 
                                            se.InstructorId,
                                            s.FirstName StudFirstName,
                                            s.LastName StudLastName, 
                                            i.FirstName IFirstName, 
                                            i.LastName ILastName,
                                            e.Title, e.[Language]
                                            from StudentExercise se
                                            join Student s on se.StudentId = s.Id
                                            join Instructor i on i.Id = se.InstructorId
                                            join Exercise e on e.Id = se.ExerciseId
                                            ";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        studentExercises.Add(new StudentExercise
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Student = new Student
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("StudentId")),
                                FirstName = reader.GetString(reader.GetOrdinal("StudFirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("StudLastName"))
                            },
                            Instructor = new Instructor
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("InstructorId")),
                                FirstName = reader.GetString(reader.GetOrdinal("IFirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("ILastName"))
                            },
                            Exercise = new Exercise
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("ExerciseId")),
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                Language = reader.GetString(reader.GetOrdinal("Language"))
                            }
                        });
                    }
                    reader.Close();
                }
            }
            return studentExercises;
        }

        public List<Exercise> singleExercises (string language)
        {
            List<Exercise> exercises = new List<Exercise>();
            using(SqlConnection conn = Connection)
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT id, Title from Exercise where 
                                        Language = 'JavaScript'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        exercises.Add( new Exercise
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Language = "Javascript"
                    });
                    }
                    reader.Close();
                }
                return exercises;
            }
        }
    }
}
