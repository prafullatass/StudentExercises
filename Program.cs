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
            
            Console.WriteLine(Praful);
        }
    }
}
