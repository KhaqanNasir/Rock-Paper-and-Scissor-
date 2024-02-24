using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_and_Scissor_Game
{
    public partial class Form2 : Form
    {
        int count1 = 0;
        int count2 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = true; pictureBox3.Visible = false; pictureBox5.Visible = false;
            pictureBox2.Visible = false; pictureBox6.Visible = false; label5.Visible = false;
            Random random = new Random();
            int x = random.Next(0, 3);
            if (0 == x) { pictureBox2.Visible = true; } else if (1 == x) { pictureBox4.Visible = true; } else if (2 == x) { pictureBox6.Visible = true; }
            if (count1 <= 5 && count2<=5)
            {
                if (x == 0) {  }
                else if (x == 1) { ++count2; label3.Text = "Computer Score : " + (count2) + " / 5"; }
                else if (x == 2) { ++count1;  label1.Text = "Your Score : " + (count1) + " / 5"; }
            }
            if (count1 == 5) { label7.Text = "You Win !!"; label7.Visible = true; button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                MessageBox.Show("You Win\nRestart The Game","Informative Message",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            if (count2 == 5) { label7.Text = "You Lost"; label7.Visible = true; button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                MessageBox.Show("You Lost\nRestart The Game", "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; pictureBox3.Visible = true; pictureBox5.Visible = false;
            pictureBox2.Visible = false; pictureBox6.Visible = false; label5.Visible = false;
            Random random = new Random();
            int x = random.Next(0, 3);
            if (0 == x) { pictureBox6.Visible = true; } else if (1 == x) { pictureBox4.Visible = true; } else if (2 == x) { pictureBox2.Visible = true; }
            if (count1 <= 5 && count2 <= 5)
            {
                if (x == 0) { ++count2; label3.Text = "Computer Score : " + (count2) + " / 5"; }
                else if (x == 1) {  }
                else if (x == 2) { ++count1; label1.Text = "Your Score : " + (count1) + " / 5"; }
            }
            if (count1 == 5)
            {
                label7.Text = "You Win !!"; label7.Visible = true; button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                MessageBox.Show("You Win\nRestart The Game", "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (count2 == 5)
            {
                label7.Text = "You Lost"; label7.Visible = true; button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                MessageBox.Show("You Lost\nRestart The Game", "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false; pictureBox3.Visible = false; pictureBox5.Visible = true;
            pictureBox2.Visible = false; pictureBox6.Visible = false; label5.Visible = false;
            Random random = new Random();
            int x = random.Next(0, 3);
            if (0 == x) { pictureBox4.Visible = true; } else if (1 == x) { pictureBox6.Visible = true; } else if (2 == x) { pictureBox2.Visible = true; }
            if (count1 <= 5 && count2 <= 5)
            {
                if (x == 0) { ++count1; label1.Text = "Your Score : " + (count1) + " / 5"; }
                else if (x == 1) {  }
                else if (x == 2) { ++count2; label3.Text = "Computer Score : " + (count2) + " / 5"; }
            }
            if (count1 == 5)
            {
                label7.Text = "You Win !!"; label7.Visible = true; button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                MessageBox.Show("You Win\nRestart The Game", "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (count2 == 5)
            {
                label7.Text = "You Lost"; label7.Visible = true; button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                MessageBox.Show("You Lost\nRestart The Game", "Informative Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            count1 = 0; count2 = 0; label7.Visible = false; label5.Visible = true;
            label1.Text = "Your Score : " + count1 + " / 5"; label3.Text = "Computer Score : " + count1 + " / 5";
            button1.Enabled = true; button2.Enabled=true; button3.Enabled = true;
        }
    }
}
