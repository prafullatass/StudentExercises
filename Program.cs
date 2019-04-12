using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort C30 = new Cohort("Cohort 30");
            Cohort E6 = new Cohort("Evening Cohort 6");
            Cohort C33 = new Cohort("Cohort 33");

            Student Praful = new Student("Prafullata" , "Sonawane");
            Praful.Cohort = C30;
            Praful.Slack_handle = "day-cohort-30";

            Student Janet = new Student("Janet" , "Woods");
            Janet.Cohort = C30;
            Janet.Slack_handle = "day-cohort-26";

            Student Nisha = new Student("Nisha" , "Shah");
            Nisha.Cohort = C33;
            Nisha.Slack_handle = "day-cohort-33";

            Student Ryan = new Student("Ryan", "D");
            Ryan.Cohort = C33;
            Ryan.Slack_handle = "day-cohort-33";

            Instructor Steve = new Instructor("Steve", "Brownlee");
            Instructor Meg = new Instructor("Meg", "D");
            Instructor Jenna = new Instructor("Jenna", "Solis");
            Instructor Jessi = new Instructor("Jessi", "");

            Steve.Cohort = C30;
            Steve.Slack_handle = "Day-Cohort-30";

            Meg.Cohort = E6;
            Meg.Slack_handle = "Evening 6";

            Jenna.Cohort = C30;
            Jenna.Slack_handle = "Day-Cohort-30";

            Jessi.Cohort = C33;
            Jessi.Slack_handle = "Day-Cohort-33";

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
        }
    }
}
