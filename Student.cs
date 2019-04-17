
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
    public class Student : NSSPerson
    {

        public List<Exercise> Exercises = new List<Exercise>();

        public Student (string fName, string lastName, string slack, Cohort cohort) :
        base ( fName,  lastName,  slack,  cohort) {
        }

        public void assignExercises(List<Exercise> exercises) {
            Exercises.AddRange(exercises);
        }
        public void assignExercises(Exercise exercise) {
            Exercises.Add(exercise);
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder($@"
                Name : {FullName}
                Cohort : {Cohort.CohortName}
                Slack :{Slack_handle}
                Exercises :
                -------------------------------------------
            ");
            Exercises.ForEach(exercise => output.Append($"{exercise}"));
            return output.ToString();
        }

    }
}
