using System.Collections.Generic;
using System.Text;

namespace StudentExercises
{
    public class Cohort
    {
        private string _name;
        private List<Student> _students = new List<Student>();
        private List<Instructor> _instructors = new List<Instructor>();
        public Cohort (string CohortName) {
            _name = CohortName;
        }
        public string CohortName {
            get
            {
                return _name;
            }
        }
        public void addStudent(List<Student> studs) {
            _students.AddRange(studs);
        }
        public void addStudent(Student stud) {
            _students.Add(stud);
        }
        public void addInstructor(Instructor inst)
        {
            _instructors.Add(inst);
        }
        public override string ToString() {
            StringBuilder output = new StringBuilder();
            output.Append($@"
    {_name}
    ---------------------------
    Instructors --");
            _instructors.ForEach(inst => output.Append($"\n {inst.FullName}"));
            output.Append(@"
    -------------------------
    Students --");
            _students.ForEach(stud => output.Append($"\n {stud.FullName} "));
            return output.ToString();
        }
    }
}
