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
  

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // the limit of the database is 20. We need to store the username, password and height of each of the customers
        static public string[] v_username = new string[20];
        static public string[] v_password = new string[20];
        static public int[] v_height = new int[20];
        // we store the value of the counter
        static public int counter = 0;
  

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.Mainscreen.Show();
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (counter < 20)
            {
                v_username[counter] = txt_username.Text;
                v_password[counter] = txt_password.Text;
                v_height[counter] = int.Parse(txt_height.Text);
                MessageBox.Show("Username " + v_username[counter] + " Password " + v_password[counter] + " Height " + v_height[counter]);
                txt_username.Text = "";
                txt_password.Text = "";
                txt_height.Text = "";

                counter++;
            }
            else
            {
                MessageBox.Show("Database is full");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
