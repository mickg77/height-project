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
    public partial class Form3 : Form
    {

        
        public static int found = -1;
        public static int i = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this for loop will run for the amount of people in the array
            for (i = 0; i <= Form2.counter; i++)
            {
                if (txt_username.Text==Form2.v_username[i] && txt_password.Text==Form2.v_password[i])
                {
                    found = i;
                    i = Form2.counter;
                    MessageBox.Show("Customer Found");
                    Form4 Adjust = new Form4();
                   
                    this.Close();
                    Adjust.Show();
                        }
                else
                {
                    MessageBox.Show("Please try again. Username or password is invalid.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form1.Mainscreen.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
