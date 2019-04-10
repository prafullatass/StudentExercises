
using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private string _cohort;
        public string Slack_handle;
        public List<Exercise> Exercises = new List<Exercise>();

        public Student (string FirstName, string LastName) {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public string Cohort {
            set {
                _cohort = value;
            }
            get {
                return _cohort;
            }
        }
        public void assignExercises(List<Exercise> exercises) {
            Exercises.AddRange(exercises);
        }
        public void assignExercises(Exercise exercise) {
            Exercises.Add(exercise);
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder($@"
Name : {_firstName} {_lastName}
Cohort : {Cohort}
Slack :{Slack_handle} \n
            ");
            return output.ToString();
        }
    }
}
