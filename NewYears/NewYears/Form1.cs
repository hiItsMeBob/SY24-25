using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewYears
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// ///////////////////////////////////////////////////ALL TEXT BOXES///////////////////////////////////////////////////
        int[] total = new int[8];
        private void Bit1_TextChanged(object sender, EventArgs e)
        {
            if (Bit1.Text.Equals("1"))

            {
                total[0] += 1;
                
                
            }
        }

        private void Bit2_TextChanged(object sender, EventArgs e)
        {
            if (Bit2.Text.Equals("1"))

            {
                total[0] += 2;
            }
        }

        private void Bit3_TextChanged(object sender, EventArgs e)
        {
            if (Bit3.Text.Equals("1"))

            {
            total[0] += 4;
            }
        }

        private void Bit4_TextChanged(object sender, EventArgs e)
        {
            if (Bit4.Text.Equals("1"))

            {
                total[0]+= 8;
            }
        }
        private void Bit5_TextChanged(object sender, EventArgs e)
        {
            if (Bit5.Text.Equals("1"))

            {
                total[0] += 16;
            }
        }
        private void Bit6_TextChanged(object sender, EventArgs e)
        {
            if (Bit6.Text.Equals("1"))

            {
                total[0] += 32;
            }
        }

        private void Bit7_TextChanged(object sender, EventArgs e)
        {
            if (Bit7.Text.Equals("1"))

            {
                total[0] += 64;
            }
        }

        private void Bit8_TextChanged(object sender, EventArgs e)
        {
            if (Bit8.Text.Equals("1"))

            {
                total[0] += 144;
            }
        }


        /// ///////////////////////////////////////////////////CONVIG BTN/RESET BTN///////////////////////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            Bit1.Text = "";
            Bit2.Text = "";
            Bit3.Text = "";
            Bit4.Text = "";
            Bit5.Text = "";
            Bit6.Text = "";
            Bit7.Text = "";
            Bit8.Text = "";
            total[0] = 0;
        }

        private void ConfigBTN_Click(object sender, EventArgs e)
        {
            label1.Text = total[0].ToString();
        }
    }
}
