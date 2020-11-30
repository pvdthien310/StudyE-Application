using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public abstract class Character
    {
        public Bitmap avatar;
        public Bitmap char_sprite;
        public abstract void Correct_action(PaintEventArgs e, ref int isCorrect, ref int Q_check, ref int char_action_goback, ref int locaion_char, ref int locaton_creep);

        public abstract void Incorrect_action(PaintEventArgs e, ref int isCorrect, ref int Q_check, ref int char_action_goback, ref int locaion_char, ref int locaton_creep);

    }
}
