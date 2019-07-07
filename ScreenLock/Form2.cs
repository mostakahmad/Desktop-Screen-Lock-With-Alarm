using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenLock
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form3 f = new Form3();
            f.Show();
            f.Enabled = false;
            oldPass.Focus();
            
        }
        string pat = @"D:\Windows.txt";
        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 fo = new Form1();
            fo.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oldPassword = File.ReadAllText(pat);

            if (oldPassword == oldPass.Text)
            {
                File.WriteAllText(pat, newPassword.Text);
                this.Hide();
                Form5 fo = new Form5();
                fo.Show();
            }
            else
            {
                this.Hide();
                Form4 fo = new Form4();
                fo.Show();
                oldPass.Text = "";
                newPassword.Text = "";
            }
        }

        private void newPassword_KeyDown(object sender, KeyEventArgs e)
        {
            string oldPassword = File.ReadAllText(pat);

            if (e.KeyCode == Keys.Enter)
            {
                if (oldPassword == oldPass.Text)
                {
                    File.WriteAllText(pat, newPassword.Text);
                    this.Hide();
                    Form5 fo = new Form5();
                    fo.Show();
                }
                else
                {
                    this.Hide();
                    Form4 fo = new Form4();
                    fo.Show();
                    oldPass.Text = "";
                    newPassword.Text = "";
                }

            }
        }

        private void oldPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                oldPass.Text = "";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void oldPass_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
