using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> Exercises { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is in {Cohort.CohortName},and slack handle is {SlackHandle} ";
        }
    }
}
