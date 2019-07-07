using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenLock
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Form3 form = new Form3();
            form.Show();
            form.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fo = new Form1();
            fo.Show();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
