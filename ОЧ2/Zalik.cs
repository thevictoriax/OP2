using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОЧ2
{
    public class Zalik
    {
        private string subject;
        private string teacher;
        private double grade;


        public Zalik()
        {
            subject = string.Empty;
            teacher = string.Empty; 
            grade = 0.0;
        }
           

        public Zalik(string _subject, string _teacher, double _grade) 
        {
            grade = _grade;
            subject = _subject;
            teacher = _teacher;
        }

        public override string ToString()
        {
            if (grade>50)
            {
                return $"{subject} , {teacher} , {grade} - зараховано ";
            }
            else
            {
                return $"{subject} , {teacher} , {grade} - НЕ зараховано ";
            }
        }
    }
}
