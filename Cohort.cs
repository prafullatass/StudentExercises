using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        private string _name;
        public List<Student> Students = new List<Student>();
        public List<Instructor> Instructors = new List<Instructor>();
        public Cohort (string CohortName) {
            _name = CohortName;
        }

        public void addStudent(List<Student> studs) {
            Students.AddRange(studs);
        }
        public void addStudent(Student stud) {
            Students.Add(stud);
        }
        public void addInstructor(Instructor inst)
        {
            Instructors.Add(inst);
        }
    }
}
