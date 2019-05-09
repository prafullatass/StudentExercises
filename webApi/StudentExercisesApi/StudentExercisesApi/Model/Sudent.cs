using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentExercisesApi.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string SlackHandle { get; set; }
        [Required]
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; }

        public void addExercise(Exercise ex)
        {
            Exercises.Add(ex);
        }

        public Student()
        {
            //Exercises = new List<Exercise>();
        }
        public override string ToString()
        {
            string str = "";
            str = $"{FirstName} {LastName} is in {Cohort.CohortName},and slack handle is {SlackHandle} \n";
            str += "=====================================================================";
            //Exercises.ForEach(ex => str += ex.ToString());
            return str;
        }
    }
}

