using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class QuestionData
    {
        public Question[] List;
        public int[] Result;
        public Database database;
        public int number_question;

        public QuestionData(int number, int isChallenge)
        {
            List = new Question[number];
            Result = new int[number];
            number_question = number;
            switch (isChallenge)
            {
                case 1:
                    {
                        this.database = new ChallengeDatabase();
                        break;
                    }
                case 2:
                    {
                        this.database = new PractiseDatabase();
                        break;

                    }
            }
            this.CreateQuestion(this.List, this.database);
        }
        private void CreateQuestion(Question[] list, Database data)
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
                            list[i] = new Question(ques, a, b, c, d, index);
                            break;
                        }
                    case 2:
                        {
                            a = wordlist[1].Meaning;
                            b = wordlist[0].Meaning;
                            c = wordlist[2].Meaning;
                            d = wordlist[3].Meaning;
                            index = luckynumber;
                            list[i] = new Question(ques, a, b, c, d, index);
                            break;
                        }
                    case 3:
                        {
                            a = wordlist[1].Meaning;
                            b = wordlist[2].Meaning;
                            c = wordlist[0].Meaning;
                            d = wordlist[3].Meaning;
                            index = luckynumber;
                            list[i] = new Question(ques, a, b, c, d, index);
                            break;
                        }
                    case 4:
                        {
                            a = wordlist[2].Meaning;
                            b = wordlist[3].Meaning;
                            c = wordlist[1].Meaning;
                            d = wordlist[0].Meaning;
                            index = luckynumber;
                            list[i] = new Question(ques, a, b, c, d, index);
                            break;
                        }
                }
                //if (i == 9)
                //{
                //    int e = 0;
                //}

            }


        }

    }
}
