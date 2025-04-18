using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudyApi;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Api.killRoblox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string script = richTextBox1.Text;
            Api.execute(script);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Api.inject();
        }
    }
}
