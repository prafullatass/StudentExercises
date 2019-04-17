using System.Text;

namespace StudentExercises
{
    public class Exercise
    {
        private string _name;
        private string _language;

        public string Name {
            get
            {
                    return _name;
            }
        }
        public string Language {
            get{
                return _language;
            }
        }
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