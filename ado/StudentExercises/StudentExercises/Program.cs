using StudentExercises.Data;
using StudentExercises.Model;
using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Repository repo = new Repository();

            List<Cohort> cohorts = repo.GetCohorts();
            cohorts.ForEach(Console.WriteLine);

            List<Exercise> exercises = repo.GetExercises();
            exercises.ForEach(Console.WriteLine);

            List<Instructor> instructors = repo.GetInstructors();
            instructors.ForEach(Console.WriteLine);
        }
    }
}
