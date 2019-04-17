using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort C30 = new Cohort("Cohort 30");
            Cohort E6 = new Cohort("Evening Cohort 6");
            Cohort C33 = new Cohort("Cohort 33");

            Student Praful = new Student("Prafullata" , "Sonawane", "praful", C30);

            Student Janet = new Student("Janet" , "Woods", "janet", C30);

            Student Nisha = new Student("Nisha" , "Shah", "nisha", C33);

            Student Ryan = new Student("Steven", "D", "Steven", C33);

            Instructor Steve = new Instructor("Steve", "Brownlee", "steve", C30);
            Instructor Meg = new Instructor("Meg", "D", "meg", E6);
            Instructor Jenna = new Instructor("Jenna", "Solis", "jenna", C30);
            Instructor Jessi = new Instructor("Jessi", "", "jessi", C33);

            C30.addInstructor(Steve);
            C30.addInstructor(Jenna);
            C30.addStudent(Praful);
            C30.addStudent(Janet);
            C33.addInstructor(Jessi);
            C33.addStudent(Ryan);
            C33.addStudent(Nisha);

            Exercise SolarSystem = new Exercise("JS", "SolarSystem");
            Exercise OverlyExcited = new Exercise("JS", "Overly Excited");
            Exercise nutshell = new Exercise("React", "Nutshell");
            Exercise addressBook = new Exercise("C#", "Address Book");
            Exercise capstone = new Exercise("React", "Capstone Project");

            Steve.assignExercise(SolarSystem, Praful);
            Steve.assignExercise(capstone, Praful);
            Jessi.assignExercise(nutshell, Ryan);
            Jessi.assignExercise(capstone, Nisha);
            Jenna.assignExercise(OverlyExcited, Janet);

            Console.WriteLine(Praful);
            Console.WriteLine(Nisha);
            Console.WriteLine(Steve);
            Console.WriteLine(Jessi);

            Console.WriteLine(C30);
            Console.WriteLine(C33);

            List<Student> students = new List<Student>() {
                Praful,
                Janet,
                Ryan,
                Nisha
            };

            List<Exercise> exercises = new List<Exercise>() {
                SolarSystem,
                nutshell,
                addressBook,
                capstone
            };
            List<Instructor> instructors = new List<Instructor>() {
                Steve,
                Jenna,
                Jessi,
                Meg
            };
            List<Cohort> cohorts = new List<Cohort>() {
                C30,
                C33,
                E6
            };
            //List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> JS_exercises = from exercise in exercises
                        where exercise.Language.Equals("JS")
                        select exercise;
            Console.WriteLine("Only JS exercises ---");
            foreach (Exercise ex in JS_exercises)
            {
                Console.WriteLine($"{ex.Name}");
            };
            //List students in a particular cohort by using the Where() LINQ method.
            //IEnumerable<Student> studentsC30 = from
        }
    }
}
