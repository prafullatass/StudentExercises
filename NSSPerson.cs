namespace StudentExercises
{
    public class NSSPerson
    {
        private string _firstName;
        private string _lastName;
        private string _slack_handle;
        private Cohort _cohort;
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
        }
        public string Slack_handle
        {
            get {
                return _slack_handle;
            }

        }
        public NSSPerson (string firstName, string lastName, string slack, Cohort cohort) {
            _firstName = firstName;
            _lastName = lastName;
            _slack_handle = slack;
            _cohort = cohort;
        }
    }
}