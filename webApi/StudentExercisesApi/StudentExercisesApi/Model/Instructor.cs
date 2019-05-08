using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercisesApi.Model
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specality { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} instructing {Cohort.CohortName}, has spcality in {Specality} and handle slack {SlackHandle}";
        }
    }
}
