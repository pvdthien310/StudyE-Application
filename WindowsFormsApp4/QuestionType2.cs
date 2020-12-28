using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class QuestionType2 : QuestionGame2
    {
        string question;
        string correctanswer;
        public QuestionType2(string a, string b)
        {
            question = a;
            correctanswer = b;
            type = 2;
        }
        public override string[] GetQuestion()
        {
            string[] temp = new string[2] { question, correctanswer };
            return temp;
        }
    }
}
