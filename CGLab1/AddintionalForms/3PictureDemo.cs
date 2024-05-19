using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGLab1.AddintionalForms
{
    public partial class _3PictureDemo : Form
    {
        public _3PictureDemo(Bitmap bmp1, Bitmap bmp2, Bitmap bmp3, Bitmap bmp4, Bitmap bmp5, Bitmap bmp6)
        {
            InitializeComponent();
            pictureBox1.Image = bmp1;
            pictureBox2.Image = bmp2;
            pictureBox3.Image = bmp3;

            pictureBox4.Image = bmp4;
            pictureBox5.Image = bmp5;
            pictureBox6.Image = bmp6;

            //pictureBox7.Image = bmp7;
        }
    }
}
