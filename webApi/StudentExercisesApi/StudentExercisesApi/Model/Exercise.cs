using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudentExercisesApi.Model
{
    public class Exercise
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }
        [Required]
        [MaxLength(20)]
        public string Language { get; set; }
        public override string ToString()
        {
            return $"{Id} : {Title} ({Language})";
        }
    }
}
