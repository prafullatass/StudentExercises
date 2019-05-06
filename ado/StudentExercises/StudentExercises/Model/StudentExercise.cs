using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises.Model
{
    public class StudentExercise
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Instructor Instructor { get; set; }
        public Exercise Exercise { get; set; }
        public override string ToString()
        {
            return $"{Student.FirstName} {Student.LastName} is woking on {Exercise.Title} " +
                $"({Exercise.Language}) given by {Instructor.FirstName} {Instructor.LastName}";
        }
    }
}
