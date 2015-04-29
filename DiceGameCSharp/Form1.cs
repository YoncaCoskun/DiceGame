using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMakinesiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int sumMe = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int a = random.Next(1, 7);
            label3.Text = a.ToString();

            int b = random.Next(1, 7);
            label4.Text = b.ToString();

            sumMe += a + b;
            label16.Text = sumMe.ToString();

            if (a == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\1.png";

            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\4.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\6.png";
            }

            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\1.png";

            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\2.png";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\6.png";
            }
        }
        int sumPC = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            int c = random.Next(1, 7);
            label10.Text = c.ToString();

            int d = random.Next(1, 7);
            label9.Text = d.ToString();

            sumPC += c + d;
            label15.Text = sumPC.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\1.png";

            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\2.png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\3.png";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\4.png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\5.png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\6.png";
            }

            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\1.png";

            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\2.png";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\3.png";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\4.png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\5.png";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Yonca\\Desktop\\Dice\\6.png";
            }

            if (sumMe >100 && sumMe>sumPC)
            {
                label13.Text = "Your Winner!!!";
            }
            if (sumPC>100 && sumPC>sumMe)
            {
                label13.Text = "Your Losee!!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

    }
}
