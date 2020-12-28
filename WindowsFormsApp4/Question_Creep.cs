using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Question_Creep
    {
        public QuestionGame2 question;
        public int type;
        public int X_creep;
        public int Y_creep;
        public int isCorrect; // 0 - sai 1- dung 2- chua tra loi
        static Random rd = new Random();
        public Question_Creep(QuestionGame2 question)
        {
            isCorrect = 2;
            this.question = question;
            X_creep = rd.Next(0, 550);
            Y_creep = rd.Next(0, 400);
            this.type = question.type;
        }

    }
}
