﻿using StudentExercises.Data;
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

            List<StudentExercise> studentExercises = repo.GetStudentExercise();
            studentExercises.ForEach(Console.WriteLine);
        }
    }
}
