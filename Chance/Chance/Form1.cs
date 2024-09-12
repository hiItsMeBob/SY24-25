using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = random.Next(1, 100);
            textBox2.Text += a.ToString() + ", ";
            button1.Enabled = true;
            textBox1.BackColor = Color.Red;
           
        }
    }
}
