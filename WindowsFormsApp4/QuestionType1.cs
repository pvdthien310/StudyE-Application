using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class QuestionType1 : QuestionGame2
    {
        public string question;
        public string answerA;
        public string answerB;
        public string answerC;
        public string answerD;
        public int correctIndex; // cau tra loi dung la cau nao
        public QuestionType1(string ques, string a, string b, string c, string d, int index)
        {
            type = 1;
            question = ques;
            answerA = a;
            answerB = b;
            answerC = c;
            answerD = d;
            correctIndex = index;
        }
        public override string[] GetQuestion()
        {
            string[] temp = new string[6] { question, answerA, answerB, answerC, answerD, correctIndex.ToString() };

            return temp;
        }

    }
}
