using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class searchedWordList
    {
        public List<Word> list;
        public searchedWordList()
        {
            list = new List<Word>(100);
        }
        public searchedWordList(Word member)
        {
            list.Add(member);
        }
    }
}
