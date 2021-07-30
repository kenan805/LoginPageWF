using System;
using System.Windows.Forms;

namespace _28_07_2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_Username_TextChanged(object sender, EventArgs e)
        {
            Btn1_Login.Enabled = true;
            Lbl4_Check_Login.Visible = false;
        }


        private void Btn1_Login_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextBox1_Username.Text != "username")
            {
                Lbl4_Check_Login.Visible = true;
                Lbl4_Check_Login.Text = "Username not found!";
            }
            else if (TextBox2_Password.Text != "password")
            {
                Lbl4_Check_Login.Visible = true;
                Lbl4_Check_Login.Text = "Password incorrect!";
            }
            else if (TextBox1_Username.Text == "username" && TextBox2_Password.Text == "password")
            {
            Lbl4_Check_Login.Visible = false;
                MessageBox.Show("Welcome social network", "Info", MessageBoxButtons.OK);
            }
        }
    }
}
