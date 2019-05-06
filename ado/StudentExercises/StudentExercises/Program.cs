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
            Console.WriteLine("Cohorts");
            Console.WriteLine("====================");

            List<Cohort> cohorts = repo.GetCohorts();
            cohorts.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Exercises");
            Console.WriteLine("====================");

            List<Exercise> exercises = repo.GetExercises();
            exercises.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Instructors");
            Console.WriteLine("====================");

            List<Instructor> instructors = repo.GetInstructors();
            instructors.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Students");
            Console.WriteLine("====================");


            List<Student> students = repo.GetStudents();
            students.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Students - Exercises");
            Console.WriteLine("====================");

            List<StudentExercise> studentExercises = repo.GetStudentExercise();
            studentExercises.ForEach(Console.WriteLine);

            Console.WriteLine();
            Console.WriteLine("Javascript Exercises");
            Console.WriteLine("====================");
            List<Exercise> JavaExercises = repo.singleExercises("Javascript");
            JavaExercises.ForEach(Console.WriteLine);

            //insert a new exercise into the database

            //repo.InsertNewExercise(new Exercise
            //{
            //    Title = "chickenMonkey",
            //    Language = "JavaScript"
            //});
            //Console.WriteLine();
            //Console.WriteLine("Exercises");
            //Console.WriteLine("====================");

            //exercises = repo.GetExercises();
            //exercises.ForEach(Console.WriteLine);

            //insert new instructor
            //repo.AddNewInstructor(new Instructor
            //{
            //    FirstName = "Kimmy",
            //    LastName = "Bird", 
            //    SlackHandle = "@Kimmy",
            //    Specality = "C#"
            //}, 2);

            //Console.WriteLine();
            //Console.WriteLine("Instructors");
            //Console.WriteLine("====================");

            //instructors = repo.GetInstructors();
            //instructors.ForEach(Console.WriteLine);



        }
    }
}
