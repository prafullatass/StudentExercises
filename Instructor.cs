namespace StudentExercises
{
    class Instructor
    {
        private string _firstName;
        private string _lastName;
        //public string Slack_handle;
        private string _cohort;
        public Instructor(string firstName, string lastName) {
            _firstName = firstName;
            _lastName = lastName;
        }
        public string Cohort {
            get {
                return _cohort;
            }
            set {
                _cohort = value;
            }
        }
    }
}