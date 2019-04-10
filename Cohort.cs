using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        private string _name;
        public List<Student> students = new List<Student>();
        //public List<Instructor> instructors = new List<Instructor>();
        public Cohort (string CohortName) {
            _name = CohortName;
        }
    }
}
