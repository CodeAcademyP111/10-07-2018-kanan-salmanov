using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked){
                txtPass.UseSystemPasswordChar = false;
                showPass.Text = "Hide Password";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                showPass.Text = "Show Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && txtPass.Text=="12345")
            {
                MessageBox.Show("En Buyuk Kamran!");
            }
            else
            {
                MessageBox.Show("Daxil etdiyin ad ve ya shifre yalnisdir, dede!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
