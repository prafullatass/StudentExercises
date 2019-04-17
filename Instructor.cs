using System.Text;

namespace StudentExercises {
    public class Instructor : NSSPerson {
        public Instructor (string firstName, string lastName, string slack, Cohort cohort) :
        base(firstName,  lastName,  slack,  cohort) {

        }

        public override string ToString () {
            StringBuilder output = new StringBuilder ();
            output.Append ($@"
                Name   : {FullName}
                Slack  : {Slack_handle}
                Cohort : {Cohort.CohortName}
            ");
            return output.ToString ();
        }

        public void assignExercise ( Exercise exercise, Student stud) {
            stud.Exercises.Add (exercise);
        }
    }
}