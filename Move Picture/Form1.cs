using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //moves the picutre right
        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 50 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y);
            }
        }
        //moves the picture left
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 50)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y);
            }
        }
        //move the picture up
        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 50)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 50);
            }
        }
        //moves the picutre down
        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 50 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 50);
            }
        }
        
    }
}
