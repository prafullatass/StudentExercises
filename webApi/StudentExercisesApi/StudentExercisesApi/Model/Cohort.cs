using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentExercisesApi.Model
{
    public class Cohort
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string CohortName { get; set; }

        public override string ToString()
        {
            return ($" {Id} : {CohortName} ");
        }

    }
}
