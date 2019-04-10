using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Praful = new Student("Prafullata" , "Sonawane");
            Praful.Cohort = "C30";
            Praful.Slack_handle = "day-cohort-30";

            Student Priyanka = new Student("Priyanka" , "Gerge");
            Priyanka.Cohort = "C26";
            Priyanka.Slack_handle = "day-cohort-26";

            Student Nisha = new Student("Nisha" , "Shah");
            Nisha.Cohort = "C33";
            Nisha.Slack_handle = "day-cohort-33";

            Cohort C30 = new Cohort("Day Cohort 30");
            Cohort E6 = new Cohort("Evening Cohort 6");
            Cohort C33 = new Cohort("Day Cohort 33");

            Instructor Steve = new Instructor("Steve", "Brownlee");
            Instructor Meg = new Instructor("Meg", "D");
            Instructor Jenna = new Instructor("Jenna", "Solis");
            Steve.Cohort = "C30";
            Steve.Slack_handle = "Day Cohort 30";

            Meg.Cohort = "E6";
            Meg.Slack_handle = "Evening 6";

            Jenna.Cohort = "C30";
            Jenna.Slack_handle = "Day Cohort 30";

            Console.WriteLine(Praful);
        }
    }
}
