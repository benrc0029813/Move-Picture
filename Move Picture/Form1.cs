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

        private Image Sun;
        private Image Moon;

        public Form1()
        {
            InitializeComponent();
            Sun = Properties.Resources.Sun;
            Moon = Properties.Resources.Moon;
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

        private async void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y);
            await Task.Delay(500);
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            int d;
            try
            {
                d = Convert.ToInt32(textBox1.Text);  
            }
            catch
            {
                MessageBox.Show("Don't be a Idiot type in a number");
                d = 10;
            }
            for (int i = 0; i < 10; i++)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                    await Task.Delay(d);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image==Sun)
            {
                pictureBox2.Image = Moon;
            }
            else
            {
                pictureBox2.Image = Sun;
            }
        }

    }
}
