using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZeaMart_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.textBox1.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            this.textBox1.UseSystemPasswordChar = true;
            if (textBoxuser.Text == "admin novel" && textBox1.Text == "admin") 
            {
                new Form1().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usernamen or Password is wrong");
                textBoxuser.Clear();
                textBox1.Clear();
                textBoxuser.Focus();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2pass_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
