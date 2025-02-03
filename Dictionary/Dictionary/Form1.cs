using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        WordBook1 dict = new WordBook1();
        public Form1()
        {
            InitializeComponent();
        }

        private void WordBtn_Click(object sender, EventArgs e)
        {
            if (WordTxt.Text != String.Empty && DefTxt.Text != String.Empty)
            {
                dict.add(WordTxt.Text, DefTxt.Text);
                comboBox1.Items.Add(WordTxt.Text);
                WordTxt.Clear();
                DefTxt.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DefTxt.Text = dict.getDef(comboBox1.SelectedItem.ToString());
            WordTxt.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
