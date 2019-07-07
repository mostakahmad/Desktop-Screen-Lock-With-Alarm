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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Maximized;
            
            
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            
            Form7 fo = new Form7();
            Form3 f = new Form3();
            Form6 form = new Form6();
            f.Enabled = false;
            form.Hide();
            fo.Show();
        }

        
    }
}
