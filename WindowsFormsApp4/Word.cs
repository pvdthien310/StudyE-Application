using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{

    public class Word
    {
        public int ID;
        public string Name;
        public string Meaning;
        //public bool isMemorable;
        public Word(int a, string b, string c)
        {
            this.ID = a;
            this.Name = b;
            this.Meaning = c;
        }

    }
}
