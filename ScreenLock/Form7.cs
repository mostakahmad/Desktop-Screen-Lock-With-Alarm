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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Form3 form = new Form3();
            form.Enabled = false;
            password.Focus();
            
        }
        string pat = @"D:\Windows.txt";
        private void Form7_Load(object sender, EventArgs e)
        {
            password.Text = "";
            password.Focus();
            if (!File.Exists(pat))
            {
                File.WriteAllText(pat, "mostak3800");
            } 
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\Users\Mostak\Desktop\police.wav";
            player.Load();
            player.PlaySync();
            Form3 form = new Form3();
            form.Enabled = false;
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
                    Form4 fo = new Form4();
                    this.Hide();
                    fo.Show();
                }
            }
        }
    }
}
