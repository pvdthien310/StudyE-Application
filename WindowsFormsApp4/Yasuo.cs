using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class Yasuo : Character
    {

        Bitmap gamebackground = new Bitmap("background.jpg");
        Bitmap firebullet = new Bitmap("firebullet.png");
        Bitmap char_action = new Bitmap("yasuosprite_action.png");
        Bitmap creep_death = new Bitmap("creep_death.png");
        Bitmap background_char = new Bitmap("background.jpg");
        Bitmap yasuo_death_1 = new Bitmap("yasuo_death_1.png");
        Bitmap yasuo_death_2 = new Bitmap("yasuo_death_3.png");


        private Bitmap sprite = new Bitmap("yasuosprite.png");
        private Bitmap creep = new Bitmap("creep.png");
        // Back buffer
        private Bitmap backBuffer;
        private System.Threading.Timer timer2;
        public Graphics graphics;
        // Số thự tự của frame (16 frame ảnh)
        private int index;
        // dòng hiện tại của frame
        private int curFrameColumn;
        // cột hiện tại của frame
        private int curFrameRow;

        //private int location_char = 100; // vi tri ban dau con yasuo dung
        ///private int location_creep = 600;
        private int location_firebullet = 780;

        // bien check
        int Q_check = 0;
        int isCorrect = 0;
        int char_action_goback = 0;
        int incorrect_check = 0;

        // dead lan 3 effect 
        private int curFrameColumn_deadth_3 = 0;

        private static Yasuo instance;

        public static Yasuo Instance
        {
            get { if (instance == null) instance = new Yasuo(); return instance; }
            private set { instance = value; }
        }
        public Yasuo()
        {
            avatar = new Bitmap("yasuoavatar.png");
            char_sprite = new Bitmap("yasuosprite.png");
            index = 0;

        }
        public override void Correct_action(PaintEventArgs e, ref int isCorrect, ref int Q_check, ref int char_action_goback, ref int location_char, ref int location_creep)
        {



            //if (char_action_goback == 0 && isCorrect == 0)
            //{
            //    // e.Graphics.DrawImage(background_char, 2, 1);
            //    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 590), new Rectangle(2, 1, 900, 500), GraphicsUnit.Pixel);
            //    e.Graphics.DrawImage(creep, location_creep, 310, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
            //    e.Graphics.DrawImage(sprite, location_char, 270, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);


            //    return;
            //}

            //if (Q_check == 1 && char_action_goback == 1) ///
            //{
            //    if (location_char == 100)
            //    {
            //        //e.Graphics.DrawImage(background_char, 2, 1);
            //        e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 590), new Rectangle(2, 1, 900, 500), GraphicsUnit.Pixel);
            //        e.Graphics.DrawImage(sprite, location_char, 270, new Rectangle(0, 0, 88, 113), GraphicsUnit.Pixel);


            //        Q_check = 0;
            //        char_action_goback = 2; // moi thuc hien xong va da quay ve, tra ve  2 de chuyen cau
            //        location_creep = 600;
            //        location_char = 100;


            //    }
            //    else
            //    {
            //        //e.Graphics.DrawImage(background_char, 2, 1);
            //        e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 590), new Rectangle(2, 1, 900, 500), GraphicsUnit.Pixel);
            //        e.Graphics.DrawImage(sprite, location_char, 270, new Rectangle(curFrameColumn * 88, 120, 84, 110), GraphicsUnit.Pixel);
            //        location_char -= 40;
            //    }
            //    if (index > 16)
            //        index = 0;
            //    else
            //        index++;
            //    return;
            //}
            //else if (char_action_goback == 0 && (isCorrect == 1 || isCorrect == 2))
            //{
            //    // Lấy đối tượng graphics để vẽ lên back buffer

            //    // e.Graphics.DrawImage(background_char, 2, 1);
            //    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 590), new Rectangle(2, 1, 900, 500), GraphicsUnit.Pixel);
            //    e.Graphics.DrawImage(sprite, location_char, 270, new Rectangle(curFrameColumn * 88, 0, 84, 111), GraphicsUnit.Pixel);
            //    e.Graphics.DrawImage(creep, location_creep, 310, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
            //    //guna2Panel3.BackgroundImage = gamebackground;
            //    //guna2Panel3.BackgroundImageLayout = ImageLayout.Stretch;

            //    // Tăng thứ tự frame để lấy frame tiếp theo

            //    if (index > 16)
            //        index = 0;
            //    else
            //    { index++; }
            //    location_char += 40;
            //    location_creep -= 30;


            //}



            ////// Chem quai
            //if (location_char >= (location_creep - 30) && isCorrect == 1 )
            //{ 
            //    background_char.MakeTransparent();
            //    //e.Graphics.DrawImage(background_char, 2, 1);
            //    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 590), new Rectangle(2, 1, 900, 500), GraphicsUnit.Pixel);
            //    e.Graphics.DrawImage(char_action, location_char, 270, new Rectangle(0, 0, 200, 110), GraphicsUnit.Pixel);
            //    e.Graphics.DrawImage(creep_death, location_creep + 60, 310, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
            //    isCorrect--;
            //    Q_check = 0;
            //    char_action_goback = 1; // check xem char da ve vi tri ban dau chua
            //    return;
            //}

            //else if (location_char >= 330 && isCorrect == 0)  /// hien hinh anh con quai chet
            //{
            //    background_char.MakeTransparent();
            //    // e.Graphics.DrawImage(background_char, 2, 1);
            //    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 590), new Rectangle(2, 1, 900, 500), GraphicsUnit.Pixel);
            //    e.Graphics.DrawImage(char_action, location_char, 270, new Rectangle(0, 0, 200, 110), GraphicsUnit.Pixel);
            //    e.Graphics.DrawImage(creep_death, location_creep + 60, 310, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
            //    isCorrect = 0;
            //    Q_check = 1; // da chem xong ;
            //    char_action_goback = 1; // check xem char da ve vi tri ban dau chua
            //}
            curFrameColumn = index % 4;
            if (Q_check == 0 && isCorrect == 1)
            {
                if (location_char <= location_creep - 100)
                {
                    location_char += 20;
                    location_creep -= 30;
                    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(sprite, location_char, 380, new Rectangle(index * 88, 0, 88, 111), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(creep, location_creep, 420, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);

                    if (index >= 3)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }

                    char_action_goback = 1;
                    return;
                }

                else
                {
                    background_char.MakeTransparent();
                    //e.Graphics.DrawImage(background_char, 2, 1);
                    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(char_action, location_char, 380, new Rectangle(0, 0, 200, 110), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(creep_death, location_creep + 60, 420, new Rectangle(0, 0, 88, 110), GraphicsUnit.Pixel);
                    Q_check = 1;
                    index = 0;
                    char_action_goback = 2; // check xem char da ve vi tri ban dau chua
                    return;
                }
            }
            else if (Q_check == 1 && isCorrect == 1)
            {
                if (location_char <= 100)
                {
                    // e.Graphics.DrawImage(background_char, 2, 1);
                    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(sprite, location_char, 380, new Rectangle(0, 0, 92, 113), GraphicsUnit.Pixel);

                    isCorrect = 3;
                    Q_check = 0;
                    char_action_goback = 0; // moi thuc hien xong va da quay ve, tra ve  2 de chuyen cau
                    index = 0;
                    location_creep = 800;
                    //location_char = 100;

                    return;
                }
                if (char_action_goback == 2)
                {
                    // e.Graphics.DrawImage(background_char, 2, 1);
                    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(sprite, location_char, 380, new Rectangle(index * 88, 120, 88, 113), GraphicsUnit.Pixel);
                    location_char -= 20;
                    if (index >= 3)
                        index = 0;
                    else
                    { index++; }
                    return;
                }

            }



        }
        public override void Incorrect_action(PaintEventArgs e, ref int isCorrect, ref int Q_check, ref int char_action_goback, ref int location_char, ref int location_creep)
        {
            //curFrameColumn = index % 4;
            int yasuo_death_column = index % 8;
            if (Q_check == 0 && isCorrect == 2)
            {
                if (location_firebullet - 30 <= location_char && incorrect_check != 3)
                {
                    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(yasuo_death_1, location_char, 380, new Rectangle(0, 0, 84, 111), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(creep, location_creep, 420, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
                    char_action_goback = 2;
                    index = 0;
                    Q_check = 1;
                    incorrect_check++;
                    return;

                }
                else if (location_firebullet - 30 <= location_char && incorrect_check == 3)
                {
                    if (curFrameColumn_deadth_3 == 10)
                    {
                        incorrect_check = 0;
                        curFrameColumn_deadth_3 = 0;
                        char_action_goback = 2;
                        Q_check = 1;
                    }
                    else curFrameColumn_deadth_3++;
                    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(yasuo_death_2, location_char, 380, new Rectangle(curFrameColumn_deadth_3 * 200, 0, 200, 120), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(creep, location_creep, 420, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
                    if (curFrameColumn_deadth_3 == 10)
                    {
                        // MessageBox.Show("May thua roi thang lon :)))");
                        isCorrect = 0; //  cho nó dừng draw 
                        isCorrect = 4; // Goi lenh xuat form result
                                       //Application.Exit(); // out chương trình

                    }

                    return;
                }
                else
                {
                    location_char += 20;
                    location_firebullet -= 30;
                    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(sprite, location_char, 380, new Rectangle(index * 88, 0, 84, 111), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(firebullet, location_firebullet, 380, new Rectangle(0, 0, 100, 100), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(creep, location_creep, 420, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
                    //guna2Panel3.BackgroundImage = gamebackground;
                    //guna2Panel3.BackgroundImageLayout = ImageLayout.Stretch;

                    // Tăng thứ tự frame để lấy frame tiếp theo
                    if (index >= 3)
                        index = 0;
                    else
                    { index++; }

                    char_action_goback = 1;
                    return;
                }
            }
            else if (Q_check == 1 && isCorrect == 2)
            {
                if (location_char < 100)
                {
                    // e.Graphics.DrawImage(background_char, 2, 1);
                    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(sprite, location_char, 381, new Rectangle(0, 0, 88, 113), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(creep, location_creep, 420, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);

                    isCorrect = 3;
                    Q_check = 0;
                    char_action_goback = 0; // moi thuc hien xong va da quay ve, tra ve  2 de chuyen cau
                    location_creep = 800;
                    //location_char = 100;
                    index = 0;
                    location_firebullet = 780;
                    return;
                }
                if (char_action_goback == 2)
                {
                    //e.Graphics.DrawImage(background_char, 2, 1);
                    e.Graphics.DrawImage(background_char, new Rectangle(0, 0, 1000, 600), new Rectangle(0, 0, 1280, 720), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(sprite, location_char, 380, new Rectangle(index * 88, 120, 84, 110), GraphicsUnit.Pixel);
                    e.Graphics.DrawImage(creep, location_creep, 420, new Rectangle(0, 0, 84, 110), GraphicsUnit.Pixel);
                    if (index >= 3)
                        index = 0;
                    else
                    { index++; }
                    location_char -= 20;
                    return;
                }
            }


        }
    }
}
