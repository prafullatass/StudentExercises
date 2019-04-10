
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        private string _firstName;
        private string _lastName;
        private string Slack_handle;
        private string _cohort;
        //public List<Exercise> Exercises = new List<Exercise>();

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
    }
}
