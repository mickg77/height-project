using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int changeheight =0;

        private void Form4_Load(object sender, EventArgs e)
        {
            //these lines of code display the username and the current amount in their balance
            user.Text = Form2.v_username[Form3.found];
            height.Text = (Form2.v_height[Form3.found]).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changeheight = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (changeheight <= Form2.v_height[Form3.found])
            {
                Form2.v_height[Form3.found] = Form2.v_height[Form3.found]  -changeheight;
                height.Text = (Form2.v_height[Form3.found]).ToString();
            }
            else
            {
                MessageBox.Show("Can't be less than 0");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changeheight = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            changeheight = -1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            changeheight = -100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Mainscreen.Show();
        }
    }
}
