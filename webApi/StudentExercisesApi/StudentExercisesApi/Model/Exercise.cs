using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercisesApi.Model
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public override string ToString()
        {
            return $"{Id} : {Title} ({Language})";
        }
    }
}
