using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindSweeper
{
    public partial class Form1 : Form

    {
        Random Random = new Random();
        Button[] btn = new Button[100];
        tile[] tileGrid = new tile[100];
        public Form1()
        {

            InitializeComponent();

            btn[0] = B1;
            btn[1] = B2;
            btn[2] = B3;
            btn[3] = B4;
            btn[4] = B5;
            btn[5] = B6;
            btn[6] = B7;
            btn[7] = B8;
            btn[8] = B9;
            btn[9] = B10;
            btn[10] = B11;
            btn[11] = B12;
            btn[12] = B13;
            btn[13] = B14;
            btn[14] = B15;
            btn[15] = B16;
            btn[16] = B17;
            btn[17] = B18;
            btn[18] = B19;
            btn[19] = B20;
            btn[20] = B21;
            btn[21] = B22;
            btn[22] = B23;
            btn[23] = B24;
            btn[24] = B25;
            btn[25] = B26;
            btn[26] = B27;
            btn[27] = B28;
            btn[28] = B29;
            btn[29] = B30;
            btn[30] = B31;
            btn[31] = B32;
            btn[32] = B33;
            btn[33] = B34;
            btn[34] = B35;
            btn[35] = B36;
            btn[36] = B37;
            btn[37] = B38;
            btn[38] = B39;
            btn[39] = B40;
            btn[40] = B41;
            btn[41] = B42;
            btn[42] = B43;
            btn[43] = B44;
            btn[44] = B45;
            btn[45] = B46;
            btn[46] = B47;
            btn[47] = B48;
            btn[48] = B49;
            btn[49] = B50;
            btn[50] = B51;
            btn[50] = B51;
            btn[51] = B52;
            btn[52] = B53;
            btn[53] = B54;
            btn[54] = B55;
            btn[55] = B56;
            btn[56] = B57;
            btn[57] = B58;
            btn[58] = B59;
            btn[59] = B60;
            btn[60] = B61;
            btn[61] = B62;
            btn[62] = B63;
            btn[63] = B64;
            btn[64] = B65;
            btn[65] = B66;
            btn[66] = B67;
            btn[67] = B68;
            btn[68] = B69;
            btn[69] = B70;
            btn[70] = B71;
            btn[71] = B72;
            btn[72] = B73;
            btn[73] = B74;
            btn[74] = B75;
            btn[75] = B76;
            btn[76] = B77;
            btn[77] = B78;
            btn[78] = B79;
            btn[79] = B80;
            btn[80] = B81;
            btn[81] = B82;
            btn[82] = B83;
            btn[83] = B84;
            btn[84] = B85;
            btn[85] = B86;
            btn[86] = B87;
            btn[87] = B88;
            btn[88] = B89;
            btn[89] = B90;
            btn[90] = B91;
            btn[91] = B92;
            btn[92] = B93;
            btn[93] = B94;
            btn[94] = B95;
            btn[95] = B96;
            btn[96] = B97;
            btn[97] = B98;
            btn[98] = B99;
            btn[99] = B100;

           // for (int i = 0; i < 100 i++)    
           // { 
            
            //}

        }

        
        private void RandomNum_Click(object sender, EventArgs e)
        {
            int a = Random.Next(1, 100);
            NumLable.Text += a.ToString() + ", ";

        }

        private void B64_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B17.Text = "M";
            B17.BackColor = Color.Red;
            B65.Text = "M";
            B65.BackColor = Color.Red;
            B27.Text = "M";
            B27.BackColor = Color.Red;
            B100.Text = "M";
            B100.BackColor = Color.Red;
            B38.Text = "M";
            B38.BackColor = Color.Red;
            B64.Text = "M";
            B64.BackColor = Color.Red;
            B23.Text = "M";
            B23.BackColor = Color.Red;
            B49.Text = "M";
            B49.BackColor = Color.Red;
            EndTmr.Enabled = true;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B2.BackColor = Color.Gray;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B3.BackColor = Color.Gray;

        }

        private void B4_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B4.BackColor = Color.Gray;

        }

        private void B5_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B5.BackColor = Color.Gray;

        }

        private void B6_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B6.BackColor = Color.Gray;

        }

        private void B7_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B6.BackColor = Color.Gray;

        }

        private void B8_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B8.BackColor = Color.Gray;

        }

        private void B9_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B9.BackColor = Color.Gray;

        }

        private void B10_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;

        }

        private void B20_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B20.BackColor = Color.Gray;

        }

        private void B19_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B19.BackColor = Color.Gray;

        }

        private void B18_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B18.BackColor = Color.Gray;


        }

        private void B17_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B17.Text = "M";
            B17.BackColor = Color.Red;
            B65.Text = "M";
            B65.BackColor = Color.Red;
            B27.Text = "M";
            B27.BackColor = Color.Red;
            B100.Text = "M";
            B100.BackColor = Color.Red;
            B38.Text = "M";
            B38.BackColor = Color.Red;
            B64.Text = "M";
            B64.BackColor = Color.Red;
            B23.Text = "M";
            B23.BackColor = Color.Red;
            B49.Text = "M";
            B49.BackColor = Color.Red;
            EndTmr.Enabled = true;


        }

        private void B16_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B16.BackColor = Color.Gray;


        }

        private void B15_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B15.BackColor = Color.Gray;

        }

        private void B14_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B14.BackColor = Color.Gray;

        }

        private void B13_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B13.BackColor = Color.Gray;

        }

        private void B12_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B12.BackColor = Color.Gray;

        }

        private void B11_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B11.BackColor = Color.Gray;

        }

        private void B21_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B21.BackColor = Color.Gray;

        }

        private void B22_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B22.BackColor = Color.Gray;

        }

        private void B23_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B17.Text = "M";
            B17.BackColor = Color.Red;
            B65.Text = "M";
            B65.BackColor = Color.Red;
            B27.Text = "M";
            B27.BackColor = Color.Red;
            B100.Text = "M";
            B100.BackColor = Color.Red;
            B38.Text = "M";
            B38.BackColor = Color.Red;
            B64.Text = "M";
            B64.BackColor = Color.Red;
            B23.Text = "M";
            B23.BackColor = Color.Red;
            B49.Text = "M";
            B49.BackColor = Color.Red;
            EndTmr.Enabled = true;

        }

        private void B24_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B24.BackColor = Color.Gray;


        }

        private void B25_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B25.BackColor = Color.Gray;


        }

        private void B26_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B26.BackColor = Color.Gray;

        }

        private void B27_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B17.Text = "M";
            B17.BackColor = Color.Red;
            B65.Text = "M";
            B65.BackColor = Color.Red;
            B27.Text = "M";
            B27.BackColor = Color.Red;
            B100.Text = "M";
            B100.BackColor = Color.Red;
            B38.Text = "M";
            B38.BackColor = Color.Red;
            B64.Text = "M";
            B64.BackColor = Color.Red;
            B23.Text = "M";
            B23.BackColor = Color.Red;
            B49.Text = "M";
            B49.BackColor = Color.Red;
            EndTmr.Enabled = true;


        }

        private void B28_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B28.BackColor = Color.Gray;

        }

        private void B29_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B29.BackColor = Color.Gray;

        }

        private void B30_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B30.BackColor = Color.Gray;

        }

        private void B40_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B40.BackColor = Color.Gray;

        }

        private void B39_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B39.BackColor = Color.Gray;

        }

        private void B38_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B17.Text = "M";
            B17.BackColor = Color.Red;
            B65.Text = "M";
            B65.BackColor = Color.Red;
            B27.Text = "M";
            B27.BackColor = Color.Red;
            B100.Text = "M";
            B100.BackColor = Color.Red;
            B38.Text = "M";
            B38.BackColor = Color.Red;
            B64.Text = "M";
            B64.BackColor = Color.Red;
            B23.Text = "M";
            B23.BackColor = Color.Red;
            B49.Text = "M";
            B49.BackColor = Color.Red;
            EndTmr.Enabled = true;


        }

        private void B37_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B37.BackColor = Color.Gray;


        }

        private void B36_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B36.BackColor = Color.Gray;

        }

        private void B35_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B35.BackColor = Color.Gray;


        }

        private void B34_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B34.BackColor = Color.Gray;


        }

        private void B33_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B33.BackColor = Color.Gray;


        }

        private void B32_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B32.BackColor = Color.Gray;


        }

        private void B31_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.BackColor = Color.Gray;

        }

        private void B41_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B41.BackColor = Color.Gray;

        }

        private void B42_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B42.BackColor = Color.Gray;

        }

        private void B43_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B43.BackColor = Color.Gray;

        }

        private void B44_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B44.BackColor = Color.Gray;


        }

        private void B45_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B45.BackColor = Color.Gray;

        }

        private void B46_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B46.BackColor = Color.Gray;


        }

        private void B47_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B47.BackColor = Color.Gray;

        }

        private void B48_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B48.BackColor = Color.Gray;


        }

        private void B49_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B17.Text = "M";
            B17.BackColor = Color.Red;
            B65.Text = "M";
            B65.BackColor = Color.Red;
            B49.Text = "M";
            B49.BackColor = Color.Red;
            B27.Text = "M";
            B27.BackColor = Color.Red;
            B100.Text = "M";
            B100.BackColor = Color.Red;
            B38.Text = "M";
            B38.BackColor = Color.Red;
            B64.Text = "M";
            B64.BackColor = Color.Red;
            B23.Text = "M";
            B23.BackColor = Color.Red;
            EndTmr.Enabled = true;

        }

        private void B50_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B50.BackColor = Color.Gray;


        }

        private void B60_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B60.BackColor = Color.Gray;


        }

        private void B59_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B59.BackColor = Color.Gray;

        }

        private void B58_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B58.BackColor = Color.Gray;


        }

        private void B57_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B57.BackColor = Color.Gray;


        }

        private void B56_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B56.BackColor = Color.Gray;


        }

        private void B55_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B55.BackColor = Color.Gray;


        }

        private void B54_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B54.BackColor = Color.Gray;

        }

        private void B53_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B53.BackColor = Color.Gray;


        }

        private void B52_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B52.BackColor = Color.Gray;

        }

        private void B51_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B51.BackColor = Color.Gray;


        }

        private void B61_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B61.BackColor = Color.Gray;

        }

        private void B62_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B62.BackColor = Color.Gray;


        }

        private void B63_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B63.BackColor = Color.Gray;


        }

        private void B1_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);

            B1.BackColor = Color.Gray;


        }

        private void B65_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B17.Text = "M";
            B17.BackColor = Color.Red;
            B65.Text = "M";
            B65.BackColor = Color.Red;
            B27.Text = "M";
            B27.BackColor = Color.Red;
            B100.Text = "M";
            B100.BackColor = Color.Red;
            B38.Text = "M";
            B38.BackColor = Color.Red;
            B64.Text = "M";
            B64.BackColor = Color.Red;
            B23.Text = "M";
            B23.BackColor = Color.Red;
            B49.Text = "M";
            B49.BackColor = Color.Red;
            EndTmr.Enabled = true;

        }

        private void B66_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B66.BackColor = Color.Gray;

        }

        private void B67_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);

            B67.BackColor = Color.Gray;

        }

        private void B68_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B68.BackColor = Color.Gray;

        }

        private void B69_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B69.BackColor = Color.Gray;


        }

        private void B70_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B70.BackColor = Color.Gray;


        }

        private void B80_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B80.BackColor = Color.Gray;


        }

        private void B79_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;

        }

        private void B78_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B78.BackColor = Color.Gray;


        }

        private void B77_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B77.BackColor = Color.Gray;


        }

        private void B76_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B76.BackColor = Color.Gray;

        }

        private void B75_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B75.BackColor = Color.Gray;


        }

        private void B74_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B74.BackColor = Color.Gray;

        }

        private void B73_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B73.BackColor = Color.Gray;

        }

        private void B72_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B72.BackColor = Color.Gray;

        }

        private void B71_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B71.BackColor = Color.Gray;

        }

        private void B81_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B81.BackColor = Color.Gray;

        }

        private void B82_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B82.BackColor = Color.Gray;

        }

        private void B83_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B83.BackColor = Color.Gray;

        }

        private void B84_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B84.BackColor = Color.Gray;

        }

        private void B85_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B85.BackColor = Color.Gray;

        }

        private void B86_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B86.BackColor = Color.Gray;

        }

        private void B87_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B87.BackColor = Color.Gray;


        }

        private void B88_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B88.BackColor = Color.Gray;

        }

        private void B89_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B89.BackColor = Color.Gray;

        }

        private void B90_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B90.BackColor = Color.Gray;


        }

        private void B100_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B17.Text = "M";
            B17.BackColor = Color.Red;
            B65.Text = "M";
            B65.BackColor = Color.Red;
            B100.Text = "M";
            B100.BackColor = Color.Red;
            B38.Text = "M";
            B38.BackColor = Color.Red;
            B64.Text = "M";
            B64.BackColor = Color.Red;
            B23.Text = "M";
            B23.BackColor = Color.Red;
            EndTmr.Enabled = true;


        }

        private void B99_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B99.BackColor = Color.Gray;


        }

        private void B98_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B98.BackColor = Color.Gray;

        }

        private void B97_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B97.BackColor = Color.Gray;


        }

        private void B96_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B96.BackColor = Color.Gray;

        }

        private void B95_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B95.BackColor = Color.Gray;

        }

        private void B94_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B94.BackColor = Color.Gray;

        }

        private void B93_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B93.BackColor = Color.Gray;

        }

        private void B92_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B92.BackColor = Color.Gray;

        }

        private void B91_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B91.BackColor = Color.Gray;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            B1.Visible = false;
        }
    }
}
