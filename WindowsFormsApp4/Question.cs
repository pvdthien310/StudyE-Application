using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Question
    {
        public string question;
        public string answerA;
        public string answerB;
        public string answerC;
        public string answerD;
        public int correctIndex; // cau tra loi dung la cau nao
        public Question(string ques, string a, string b, string c, string d, int index)
        {
            question = ques;
            answerA = a;
            answerB = b;
            answerC = c;
            answerD = d;
            correctIndex = index;
        }

    }
}
