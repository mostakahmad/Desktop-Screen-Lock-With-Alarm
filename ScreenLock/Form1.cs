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
    
    public partial class Form1 : Form
    {
            
        public Form1()
        {
            InitializeComponent();
            Form3 form = new Form3();
            form.Show();
            form.Enabled = false;
            password.Focus();
        }
        string pat = @"D:\Windows.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
            password.Text = "";
            password.Focus();
            if (!File.Exists(pat))
            {
                File.WriteAllText(pat, "mostak3800");
            }
            

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string pass = File.ReadAllText(pat);

            if (password.Text == pass)
            {
                Application.Exit();
            }
            else
            {
                password.Text = "";
                MessageBox.Show("               Password Is Incorrect\nDefault Password Was \"mostak3800\"");
                password.Focus();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            string pass = File.ReadAllText(pat);

            if (e.KeyCode == Keys.Enter)
            {
                if (password.Text == pass)
                {
                    Application.Exit();
                }
                else
                {
                    password.Text = "";
                    this.Hide();
                    Form4 fo = new Form4();
                    fo.Show();
                }
            }
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fo = new Form2();
            fo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form6 fo = new Form6();
            this.Hide();
            fo.Show();
        }

        
        

        


        

        

       
    }

}
