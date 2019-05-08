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
        
        public Student() {
            Exercises = new List<Exercise>();
        }
        public override string ToString()
        {
            string str = "";
            str = $"{FirstName} {LastName} is in {Cohort.CohortName},and slack handle is {SlackHandle} \n";
            str += "-----------------Exercises------------------------------";
            Exercises.ForEach(ex => str += "\n      " + ex.ToString());
            return str;
        }
    }
}
