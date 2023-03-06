using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОЧ2
{
    public class Exam: Zalik
    {
        public string Assistant { get; private set; }
        public Exam():base() 
        {
            Assistant = string.Empty;       
        }
        public Exam(string _subject, string _teacher, string _assistant, int _grade): base(_subject, _teacher, _grade)
        {
            Assistant = _assistant;
        }

        public override string ToString()
        {
            if (Grade >= 90)
            {
                return $"Предмет: {Subject}, викладач: {Teacher}, асистент: {Assistant}, бал: {Grade} - відмінно ";
            }
            else if (Grade >= 71 && Grade <= 89)
            {
                return $"Предмет: {Subject}, викладач: {Teacher}, асистент: {Assistant}, бал: {Grade} - добре ";
            }
            else if (Grade >= 51 && Grade <= 70)
            {
                return $"Предмет: {Subject}, викладач: {Teacher}, асистент: {Assistant}, бал: {Grade} - задовільно ";
            }
            else
            {
                return $"Предмет: {Subject}, викладач: {Teacher}, асистент: {Assistant}, бал: {Grade} - незадовільно ";
            }
        }
    }
}
