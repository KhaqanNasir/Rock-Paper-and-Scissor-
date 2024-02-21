using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_and_Scissor_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; pictureBox3.Visible = false; pictureBox5.Visible = true;
            pictureBox2.Visible = false; pictureBox6.Visible = false; label5.Visible=false;
            Random random = new Random();
            int x = random.Next(0, 3);
            if (0 == x) { pictureBox4.Visible = true; } else if (1 == x) { pictureBox6.Visible = true; } else if (2 == x) { pictureBox2.Visible = true; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) { this.Close(); }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true; pictureBox3.Visible = false; pictureBox5.Visible = false;
            pictureBox2.Visible=false; pictureBox6.Visible = false; label5.Visible=false;
            Random random = new Random();
            int x=random.Next(0, 3);
            if (0 == x) { pictureBox6.Visible = true; } else if (1==x){ pictureBox4.Visible = true; }else if (2 == x) { pictureBox2.Visible = true; }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; pictureBox3.Visible = true; pictureBox5.Visible = false;
            pictureBox2.Visible = false; pictureBox6.Visible = false; label5.Visible=false;
            Random random = new Random();
            int x = random.Next(0, 3);
            if (0 == x) { pictureBox2.Visible = true; } else if (1 == x) { pictureBox4.Visible = true; } else if (2 == x) { pictureBox6.Visible = true; }
        }
    }
}
