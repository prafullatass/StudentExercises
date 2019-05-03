using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Model
{
    public class Cohort
    {
        public int Id { get; set; }
        public string CohortName { get; set; }

        public override string ToString()
        {
            return ($" {Id} : {CohortName} ");
        }

    }
}
