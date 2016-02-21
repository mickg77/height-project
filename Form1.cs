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
    public partial class Form1 : Form
    {
       

        public static Form1 Mainscreen = new Form1();
         
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Register = new Form2();
            this.Hide();
            Register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 login = new Form3();
            this.Hide();
            login.Show();
        }
    }
}
