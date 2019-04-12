using System.Text;

namespace StudentExercises
{
    class Instructor
    {
        private string _firstName;
        private string _lastName;
        public string Slack_handle;
        private Cohort _cohort;
        public Instructor(string firstName, string lastName) {
            _firstName = firstName;
            _lastName = lastName;
        }
        public string FullName
        {
            get
            {
                return($"{_firstName} {_lastName}");
            }
        }
        public Cohort Cohort {
            get {
                return _cohort;
            }
            set {
                _cohort = value;
            }
        }
        public override string ToString(){
            StringBuilder output = new StringBuilder();
            output.Append($@"
                Name   : {_firstName} {_lastName}
                Slack  : {Slack_handle}
                Cohort : {Cohort.CohortName}
            ");
            return output.ToString();
        }

        public void assignExercise(Exercise exercise, Student stud) {
            stud.Exercises.Add(exercise);
        }
    }
}