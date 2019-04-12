using System.Text;

namespace StudentExercises
{
    class Exercise
    {
        private string _name;
        private string _language;

        public Exercise (string name, string language) {
            _name = name;
            _language = language;
        }

        public override string ToString()
        {
            return ($"{_name} in {_language} \n");
        }
    }
}