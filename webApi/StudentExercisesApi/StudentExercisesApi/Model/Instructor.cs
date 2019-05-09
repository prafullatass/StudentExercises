using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentExercisesApi.Model
{
    public class Instructor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Specality { get; set; }
        [MaxLength(20)]
        public string SlackHandle { get; set; }
        [Required]
        public Cohort Cohort { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} instructing {Cohort.CohortName}, has spcality in {Specality} and handle slack {SlackHandle}";
        }
    }
}
