using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public abstract class Database
    {
        public List<Word> list;
        protected abstract void LoadDataFromSQL();
    }
}
