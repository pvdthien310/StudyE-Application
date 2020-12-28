using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class GameManager
    {
        private static GameManager instance;

        public static GameManager Instance
        {
            get { if (instance == null) instance = new GameManager(); return instance; }
            private set { instance = value; }
        }
        public string username;
        public Character userCharacter; // nhan vat
        public QuestionData quesData;  // bộ xử lý câu hỏi
        public int current_ques_index = 0; // cau hoi hien tai duoc chieu tren mang hinh
        public GameManager() { }
        public GameManager(int isChallenge, int whatCharacter)
        {
            switch (whatCharacter)
            {
                case 2:
                    {
                        userCharacter = new Pantheon();
                        break;
                    }
                case 1:
                    {
                        userCharacter = new Darius();
                        break;
                    }
                case 3:
                    {
                        userCharacter = new Yasuo();
                        break;
                    }
            }
            quesData = new QuestionData(25, isChallenge);

        }

    }
}
