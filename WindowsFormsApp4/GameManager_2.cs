using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{

    public class GameManager_2
    {
        public Start parent;

        public List<QuestionGame2> list;
        public Game2Database database;
        public int current_question;
        public int n;

        public GameManager_2(Start parent)
        {
            this.parent = parent;
            list = new List<QuestionGame2>();
            database = new Game2Database();
            RepairQuestion();
        }
        public void RepairQuestion()
        {

            Random rd = new Random();
            n = rd.Next(10);
            CreateQuestionType1(n);
            CreateQuestionType2(10 - n);

        }
        public void CreateQuestionType1(int number_question)
        {
            string ques, a, b, c, d;
            int index;
            Word[] wordlist = new Word[4];

            int random = 0;

            for (int i = 0; i < number_question; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    wordlist[j] = database.list[random];
                    random++;
                }

                ques = wordlist[0].Name;
                Word temp = wordlist[3];
                int luckynumber = 0;
                foreach (var e in wordlist)
                {

                    if (temp.ID >= e.ID) luckynumber++;
                }
                if (luckynumber == 0 || luckynumber > 4) luckynumber++;
                switch (luckynumber)
                {
                    case 1:
                        {
                            a = wordlist[0].Meaning;
                            b = wordlist[1].Meaning;
                            c = wordlist[2].Meaning;
                            d = wordlist[3].Meaning;
                            index = luckynumber;
                            //list[i] = new QuestionType1(ques, a, b, c, d, index);
                            list.Add(new QuestionType1(ques, a, b, c, d, index));

                            break;
                        }
                    case 2:
                        {
                            a = wordlist[1].Meaning;
                            b = wordlist[0].Meaning;
                            c = wordlist[2].Meaning;
                            d = wordlist[3].Meaning;
                            index = luckynumber;
                            // list[i] = new QuestionType1(ques, a, b, c, d, index);
                            list.Add(new QuestionType1(ques, a, b, c, d, index));

                            break;
                        }
                    case 3:
                        {
                            a = wordlist[1].Meaning;
                            b = wordlist[2].Meaning;
                            c = wordlist[0].Meaning;
                            d = wordlist[3].Meaning;
                            index = luckynumber;
                            // list[i] = new QuestionType1(ques, a, b, c, d, index);
                            list.Add(new QuestionType1(ques, a, b, c, d, index));

                            break;
                        }
                    case 4:
                        {
                            a = wordlist[2].Meaning;
                            b = wordlist[3].Meaning;
                            c = wordlist[1].Meaning;
                            d = wordlist[0].Meaning;
                            index = luckynumber;
                            //   list[i] = new QuestionType1(ques, a, b, c, d, index);
                            list.Add(new QuestionType1(ques, a, b, c, d, index));
                            break;
                        }
                }
            }
        }

        public void CreateQuestionType2(int number_question)
        {
            string question, answer;
            for (int i = 0; i < number_question; i++)
            {
                question = database.list2[i].ques_sentence;
                answer = database.list2[i].answer_sentence;
                list.Add(new QuestionType2(question, answer));
            }
        }
    }
}
