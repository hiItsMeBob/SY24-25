using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
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
        //-----------------------------------------------------------------------------------------------------------------------\\
        //everything bellow this point are all the mines 
        private void B64_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            this.BackColor = Color.Red;

        }
        private void B17_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            this.BackColor = Color.Red;


        }
        private void B23_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            this.BackColor = Color.Red;

        }
        private void B27_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            this.BackColor = Color.Red;


        }
       

        private void B38_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            this.BackColor = Color.Red;


        }

        private void B49_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            this.BackColor = Color.Red;

        }
        private void B65_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            this.BackColor = Color.Red;

        }
        private void B82_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
            B82.BackColor = Color.Red;
            B82.Text = "M";
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
            this.BackColor = Color.Red;
        }
        private void B100_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            EndTmr.Enabled = true;
            this.BackColor = Color.Red;

          
        }
        private void B87_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;         
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            EndTmr.Enabled = true;
            this.BackColor = Color.Red;

        }
        private void B46_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M"; 
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            EndTmr.Enabled = true;
            this.BackColor = Color.Red;


        }
        private void B31_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B31.Text = "M";
            B31.BackColor = Color.Red;
            B46.Text = "M";
            B46.BackColor = Color.Red;
            B87.Text = "M";
            B87.BackColor = Color.Red;
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
            B82.BackColor = Color.Red;
            B82.Text = "M";
            EndTmr.Enabled = true;
            this.BackColor = Color.Red;

        }
        //-----------------------------------------------------------------------------------------------------------------------\\
        //Bellow this point is group (Alpha)
        private void B2_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B3_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B4_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B5_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B6_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }
        private void B16_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B15_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B14_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B13_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B12_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B11_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B21_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";
        }

        private void B22_Click(object sender, EventArgs e)
        {
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }



        private void B24_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B25_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";
        }
       

        private void B35_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B34_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";



        }

        private void B33_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";



        }

        private void B32_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }



        private void B41_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B42_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B43_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B44_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B45_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }



       

        private void B55_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";



        }

        private void B54_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B53_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B52_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";

        }

        private void B51_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B61_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B62_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";



        }

     

        private void B1_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);

            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }

        private void B71_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B1.BackColor = Color.Gray;
            B2.BackColor = Color.Gray;
            B3.BackColor = Color.Gray;

            B4.BackColor = Color.Gray;
            B5.BackColor = Color.Gray;
            B6.BackColor = Color.Gray;
            B6.Text = "1";
            B11.BackColor = Color.Gray;
            B12.BackColor = Color.Gray;
            B12.Text = "1";
            B13.BackColor = Color.Gray;
            B13.Text = "1";
            B14.BackColor = Color.Gray;
            B14.Text = "1";
            B15.BackColor = Color.Gray;
            B16.BackColor = Color.Gray;
            B16.Text = "2";
            B21.BackColor = Color.Gray;
            B21.Text = "1";
            B22.BackColor = Color.Gray;
            B22.Text = "2";
            B24.BackColor = Color.Gray;
            B24.Text = "1";
            B25.BackColor = Color.Gray;
            B25.Text = "";
            B32.BackColor = Color.Gray;
            B32.Text = "2";
            B33.BackColor = Color.Gray;
            B33.Text = "1";
            B34.BackColor = Color.Gray;
            B34.Text = "1";
            B35.BackColor = Color.Gray;
            B35.Text = "2";
            B41.BackColor = Color.Gray;
            B41.Text = "1";
            B42.BackColor = Color.Gray;
            B42.Text = "1";
            B43.BackColor = Color.Gray;
            B43.Text = "0";
            B44.BackColor = Color.Gray;
            B44.Text = "0";
            B45.BackColor = Color.Gray;
            B45.Text = "1";
            B51.BackColor = Color.Gray;
            B51.Text = "";
            B52.BackColor = Color.Gray;
            B52.Text = "0";
            B53.BackColor = Color.Gray;
            B53.Text = "1";
            B54.BackColor = Color.Gray;
            B54.Text = "2";
            B55.BackColor = Color.Gray;
            B55.Text = "3";
            B61.BackColor = Color.Gray;
            B61.Text = "0";
            B62.BackColor = Color.Gray;
            B62.Text = "1";
            B63.BackColor = Color.Gray;
            B63.Text = "1";
            B71.BackColor = Color.Gray;
            B71.Text = "1";


        }
         //-----------------------------------------------------------------------------------------------------------------------------------------------\\
         //This is group (Bravo) 
        private void B50_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";



        }
        private void B48_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";



        }

        private void B47_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";

        }
        private void B60_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }
        private void B59_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }
        private void B58_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }

        private void B57_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }
        private void B56_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";



        }

        private void B70_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";

        }

        private void B67_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";

        }

        private void B68_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }

        private void B69_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }
        private void B66_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }
        private void B80_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }

        private void B79_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B79.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";

        }

        private void B78_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B78.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "0";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }

        private void B77_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B77.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "0";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";


        }

        private void B76_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B76.BackColor = Color.Gray;
            B50.BackColor = Color.Gray;
            B50.Text = "1";
            // B49.BackColor = Color.Gray;   <-- This is a Mine 
            // B49.Text = "1";               <-- This is a Mine 
            B48.BackColor = Color.Gray;
            B48.Text = "2";
            B47.BackColor = Color.Gray;
            B47.Text = "2";
            B60.BackColor = Color.Gray;
            B60.Text = "1";
            B59.BackColor = Color.Gray;
            B59.Text = "1";
            B58.BackColor = Color.Gray;
            B58.Text = "1";
            B57.BackColor = Color.Gray;
            B57.Text = "1";
            B56.BackColor = Color.Gray;
            B56.Text = "2";
            B70.BackColor = Color.Gray;
            B70.Text = "";
            B69.BackColor = Color.Gray;
            B69.Text = "0";
            B68.BackColor = Color.Gray;
            B68.Text = "";
            B67.BackColor = Color.Gray;
            B67.Text = "0";
            B66.BackColor = Color.Gray;
            B66.Text = "1";
            B80.BackColor = Color.Gray;
            B80.Text = "0";
            B79.BackColor = Color.Gray;
            B79.Text = "0";
            B78.BackColor = Color.Gray;
            B78.Text = "1";
            B77.BackColor = Color.Gray;
            B77.Text = "1";
            B76.BackColor = Color.Gray;
            B76.Text = "1";

        }

        //-----------------------------------------------------------------------------------------\\
        // Bellow this is group (Charle)
        private void B8_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;
            B10.Text = "0";
            B9.BackColor = Color.Gray;
            B9.Text = "0";
            B8.BackColor = Color.Gray;
            B8.Text = "1";
            B20.BackColor = Color.Gray;
            B20.Text = "0";
            B19.BackColor = Color.Gray;
            B19.Text = "0";
            B18.BackColor = Color.Gray;
            B18.Text = "2";
            B30.BackColor = Color.Gray;
            B30.Text = "0";
            B29.BackColor = Color.Gray;
            B29.Text = "1";
            B28.BackColor = Color.Gray;
            B28.Text = "3";

        }

        private void B9_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;
            B10.Text = "0";
            B9.BackColor = Color.Gray;
            B9.Text = "0";
            B8.BackColor = Color.Gray;
            B8.Text = "1";
            B20.BackColor = Color.Gray;
            B20.Text = "0";
            B19.BackColor = Color.Gray;
            B19.Text = "0";
            B18.BackColor = Color.Gray;
            B18.Text = "2";
            B30.BackColor = Color.Gray;
            B30.Text = "0";
            B29.BackColor = Color.Gray;
            B29.Text = "1";
            B28.BackColor = Color.Gray;
            B28.Text = "3";

        }

        private void B10_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;
            B10.Text = "0";
            B9.BackColor = Color.Gray;
            B9.Text = "0";
            B8.BackColor = Color.Gray;
            B8.Text = "1";
            B20.BackColor = Color.Gray;
            B20.Text = "0";
            B19.BackColor = Color.Gray;
            B19.Text = "0";
            B18.BackColor = Color.Gray;
            B18.Text = "2";
            B30.BackColor = Color.Gray;
            B30.Text = "0";
            B29.BackColor = Color.Gray;
            B29.Text = "1";
            B28.BackColor = Color.Gray;
            B28.Text = "3";

        }
            private void B20_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;
            B10.Text = "0";
            B9.BackColor = Color.Gray;
            B9.Text = "0";
            B8.BackColor = Color.Gray;
            B8.Text = "1";
            B20.BackColor = Color.Gray;
            B20.Text = "0";
            B19.BackColor = Color.Gray;
            B19.Text = "0";
            B18.BackColor = Color.Gray;
            B18.Text = "2";
            B30.BackColor = Color.Gray;
            B30.Text = "0";
            B29.BackColor = Color.Gray;
            B29.Text = "1";
            B28.BackColor = Color.Gray;
            B28.Text = "3";

        }

        private void B19_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;
            B10.Text = "0";
            B9.BackColor = Color.Gray;
            B9.Text = "0";
            B8.BackColor = Color.Gray;
            B8.Text = "1";
            B20.BackColor = Color.Gray;
            B20.Text = "0";
            B19.BackColor = Color.Gray;
            B19.Text = "0";
            B18.BackColor = Color.Gray;
            B18.Text = "2";
            B30.BackColor = Color.Gray;
            B30.Text = "0";
            B29.BackColor = Color.Gray;
            B29.Text = "1";
            B28.BackColor = Color.Gray;
            B28.Text = "3";
        }

        private void B18_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;
            B10.Text = "0";
            B9.BackColor = Color.Gray;
            B9.Text = "0";
            B8.BackColor = Color.Gray;
            B8.Text = "1";
            B20.BackColor = Color.Gray;
            B20.Text = "0";
            B19.BackColor = Color.Gray;
            B19.Text = "0";
            B18.BackColor = Color.Gray;
            B18.Text = "2";
            B30.BackColor = Color.Gray;
            B30.Text = "0";
            B29.BackColor = Color.Gray;
            B29.Text = "1";
            B28.BackColor = Color.Gray;
            B28.Text = "3";

        }
        private void B28_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;
            B10.Text = "0";
            B9.BackColor = Color.Gray;
            B9.Text = "0";
            B8.BackColor = Color.Gray;
            B8.Text = "1";
            B20.BackColor = Color.Gray;
            B20.Text = "0";
            B19.BackColor = Color.Gray;
            B19.Text = "0";
            B18.BackColor = Color.Gray;
            B18.Text = "2";
            B30.BackColor = Color.Gray;
            B30.Text = "0";
            B29.BackColor = Color.Gray;
            B29.Text = "1";
            B28.BackColor = Color.Gray;
            B28.Text = "3";

        }

        private void B29_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;
            B10.Text = "0";
            B9.BackColor = Color.Gray;
            B9.Text = "0";
            B8.BackColor = Color.Gray;
            B8.Text = "1";
            B20.BackColor = Color.Gray;
            B20.Text = "0";
            B19.BackColor = Color.Gray;
            B19.Text = "0";
            B18.BackColor = Color.Gray;
            B18.Text = "2";
            B30.BackColor = Color.Gray;
            B30.Text = "0";
            B29.BackColor = Color.Gray;
            B29.Text = "1";
            B28.BackColor = Color.Gray;
            B28.Text = "3";

        }

        private void B30_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B10.BackColor = Color.Gray;
            B10.Text = "0";
            B9.BackColor = Color.Gray;
            B9.Text = "0";
            B8.BackColor = Color.Gray;
            B8.Text = "1";
            B20.BackColor = Color.Gray;
            B20.Text = "0";
            B19.BackColor = Color.Gray;
            B19.Text = "0";
            B18.BackColor = Color.Gray;
            B18.Text = "2";
            B30.BackColor = Color.Gray;
            B30.Text = "0";
            B29.BackColor = Color.Gray;
            B29.Text = "1";
            B28.BackColor = Color.Gray;
            B28.Text = "3";

        }
        // public void setflag()
        // {

        //    m_flag = !m_fage;
        //     if (m_flag)
        //        m_b.backcollor = false;
        //   else
        //        m_b.backcollor = null;


        // }


        //-----------------------------------------------------------------------------------------\\
        //normal gray buttons


        private void B7_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B7.BackColor = Color.Gray;
            B7.Text = "1";


        }

       

       





        private void B26_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B26.BackColor = Color.Gray;
            B26.Text = "2";

        }



     

        private void B40_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B40.BackColor = Color.Gray;
            B40.Text = "1";

        }

        private void B39_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B39.BackColor = Color.Gray;
            B39.Text = "1";

        }


        private void B37_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B37.BackColor = Color.Gray;
            B37.Text = "3";

        }

        private void B36_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B36.BackColor = Color.Gray;
            B36.Text = "2";
        }
       


      

       

       
      

        

       

      

    

  

    private void B75_Click(object sender, EventArgs e)
    {
        int A = Random.Next(1, 3);
        B75.BackColor = Color.Gray;
           B75.Text = "2";

        }

    private void B74_Click(object sender, EventArgs e)
    {
        int A = Random.Next(1, 3);
        B74.BackColor = Color.Gray;
            B74.Text = "2";
        }

    private void B73_Click(object sender, EventArgs e)
    {
        int A = Random.Next(1, 3);
        B73.BackColor = Color.Gray;
            B73.Text = "2";

    }

    private void B72_Click(object sender, EventArgs e)
    {
        int A = Random.Next(1, 3);
        B72.BackColor = Color.Gray;
        B72.Text = "1";

        }
    private void B81_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B81.BackColor = Color.Gray;
            B81.Text = "1";
        }

        private void B63_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B63.BackColor = Color.Gray;


        }

        private void B83_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B83.BackColor = Color.Gray;
            B83.Text = "1";
        }

        private void B84_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B84.BackColor = Color.Gray;
            B84.Text = "0";
        }

        private void B85_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B85.BackColor = Color.Gray;
            B85.Text = "0";
        }

        private void B86_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B86.BackColor = Color.Gray;
            B86.Text = "1";
        }

       

        private void B88_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B88.BackColor = Color.Gray;
            B88.Text = "1";

        }

        private void B89_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B89.BackColor = Color.Gray;
            B89.Text = "1";
        }

        private void B90_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B90.BackColor = Color.Gray;
            B90.Text = "1";

        }

        

        private void B99_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B99.BackColor = Color.Gray;
            B99.Text = "1";

        }

        private void B98_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B98.BackColor = Color.Gray;
            B98.Text = "1";
        }

        private void B97_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B97.BackColor = Color.Gray;
            B97.Text = "1";

        }

        private void B96_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B96.BackColor = Color.Gray;
            B96.Text = "1";

        }

        private void B95_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B95.BackColor = Color.Gray;
            B95.Text = "0";

        }

        private void B94_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B94.BackColor = Color.Gray;
            B94.Text = "0";
        }

        private void B93_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B93.BackColor = Color.Gray;
            B93.Text = "1";

        }

        private void B92_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B92.BackColor = Color.Gray;
            B92.Text = "1";
        }

        private void B91_Click(object sender, EventArgs e)
        {
            int A = Random.Next(1, 3);
            B91.BackColor = Color.Gray;
            B91.Text = "1";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Resetbtn1.BackColor = Color.Green;
            Greentmr.Enabled = true;
            EndTmr.Enabled = false;
            
        }

        private void Resetbtn1_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------------------------------------------------\\
            //This clears the M's from the mines 
            B17.Text = "";
            B65.Text = "";
            B27.Text = "";
            B100.Text = "";
            B38.Text = "";
            B64.Text = "";
            B23.Text = "";
            B49.Text = "";
            B82.Text = "";
            B87.Text = "";
            B46.Text = "";

            Resetbtn1.BackColor= Color.Gray;


            Greentmr.Enabled=false;
            GreyTimer.Enabled=false;
            this.BackColor = Color.White;
            //-----------------------------------------------------------------------------------------\\
            //Bellow this point sets the pattern of the buttons like green/lime
            B1.BackColor = Color.Green;
            B2.BackColor = Color.Lime;
            B3.BackColor = Color.Green;
            B4.BackColor = Color.Lime;
            B5.BackColor = Color.Green;
            B6.BackColor = Color.Lime;
            B7.BackColor = Color.Green;
            B8.BackColor = Color.Lime;
            B9.BackColor = Color.Green;
            B10.BackColor = Color.Lime;
            B11.BackColor = Color.Lime;
            B12.BackColor = Color.Green;
            B13.BackColor = Color.Lime;
            B14.BackColor = Color.Green;
            B15.BackColor = Color.Lime;
            B16.BackColor = Color.Green;
            B17.BackColor = Color.Lime;
            B18.BackColor = Color.Green;
            B19.BackColor = Color.Lime;
            B20.BackColor = Color.Green;
            B21.BackColor = Color.Green;
            B22.BackColor = Color.Lime;
            B23.BackColor = Color.Green;
            B24.BackColor = Color.Lime;
            B25.BackColor = Color.Green;
            B26.BackColor = Color.Lime;
            B27.BackColor = Color.Green;
            B28.BackColor = Color.Lime;
            B29.BackColor = Color.Green;
            B30.BackColor = Color.Lime;
            B31.BackColor = Color.Lime;
            B32.BackColor = Color.Green;
            B33.BackColor = Color.Lime;
            B34.BackColor = Color.Green;
            B35.BackColor = Color.Lime;
            B36.BackColor = Color.Green;
            B37.BackColor = Color.Lime;
            B38.BackColor = Color.Green;
            B39.BackColor = Color.Lime;
            B40.BackColor = Color.Green;
            B41.BackColor = Color.Green;
            B42.BackColor = Color.Lime;
            B43.BackColor = Color.Green;
            B44.BackColor = Color.Lime;
            B45.BackColor = Color.Green;
            B46.BackColor = Color.Lime;
            B47.BackColor = Color.Green;
            B48.BackColor = Color.Lime;
            B49.BackColor = Color.Green;
            B50.BackColor = Color.Lime;
            B51.BackColor = Color.Lime;
            B52.BackColor = Color.Green;
            B53.BackColor = Color.Lime;
            B54.BackColor = Color.Green;
            B55.BackColor = Color.Lime;
            B56.BackColor = Color.Green;
            B57.BackColor = Color.Lime;
            B58.BackColor = Color.Green;
            B59.BackColor = Color.Lime;
            B60.BackColor = Color.Green;
            B61.BackColor = Color.Green;
            B62.BackColor = Color.Lime;
            B63.BackColor = Color.Green;
            B64.BackColor = Color.Lime;
            B65.BackColor = Color.Green;
            B66.BackColor = Color.Lime;
            B67.BackColor = Color.Green;
            B68.BackColor = Color.Lime;
            B69.BackColor = Color.Green;
            B70.BackColor = Color.Lime;
            B71.BackColor = Color.Lime;
            B72.BackColor = Color.Green;
            B73.BackColor = Color.Lime;
            B74.BackColor = Color.Green;
            B75.BackColor = Color.Lime;
            B76.BackColor = Color.Green;
            B77.BackColor = Color.Lime;
            B78.BackColor = Color.Green;
            B79.BackColor = Color.Lime;
            B80.BackColor = Color.Green;
            B81.BackColor = Color.Green;
            B82.BackColor = Color.Lime;
            B83.BackColor = Color.Green;
            B84.BackColor = Color.Lime;
            B85.BackColor = Color.Green;
            B86.BackColor = Color.Lime;
            B87.BackColor = Color.Green;
            B88.BackColor = Color.Lime;
            B89.BackColor = Color.Green;
            B90.BackColor = Color.Lime;
            B91.BackColor = Color.Lime;
            B92.BackColor = Color.Green;
            B93.BackColor = Color.Lime;
            B94.BackColor = Color.Green;
            B95.BackColor = Color.Lime;
            B96.BackColor = Color.Green;
            B97.BackColor = Color.Lime;
            B98.BackColor = Color.Green;
            B99.BackColor = Color.Lime;
            B100.BackColor = Color.Green;
            //--------------------------------------------------------------------------------------\\
            // bellow this point clears all the text from the buttons 
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            B4.Text = "";
            B5.Text = "";
            B6.Text = "";
            B7.Text = "";
            B8.Text = "";
            B9.Text = "";
            B10.Text = "";
            B11.Text = "";
            B12.Text = "";
            B13.Text = "";
            B14.Text = "";
            B15.Text = "";
            B16.Text = "";
            B17.Text = "";
            B18.Text = "";
            B19.Text = "";
            B20.Text = "";
            B21.Text = "";
            B22.Text = "";
            B23.Text = "";
            B24.Text = "";
            B25.Text = "";
            B26.Text = "";
            B27.Text = "";
            B28.Text = "";
            B29.Text = ""; 
            B30.Text = "";
            B31.Text = "";
            B32.Text = "";
            B33.Text = "";
            B34.Text = "";
            B35.Text = "";
            B36.Text = "";
            B37.Text = "";
            B38.Text = "";
            B39.Text = "";
            B40.Text = "";
            B41.Text = "";
            B42.Text = "";
            B43.Text = "";
            B44.Text = "";
            B45.Text = "";
            B46.Text = "";
            B47.Text = "";
            B48.Text = "";
            B49.Text = "";
            B50.Text = "";
            B51.Text = "";
            B52.Text = "";
            B53.Text = "";
            B54.Text = "";
            B55.Text = "";
            B56.Text = "";
            B57.Text = "";
            B58.Text = "";
            B59.Text = "";
            B60.Text = "";
            B61.Text = "";
            B62.Text = "";
            B63.Text = "";
            B64.Text = "";
            B65.Text = "";
            B66.Text = "";
            B67.Text = "";
            B68.Text = "";
            B69.Text = "";
            B70.Text = "";
            B71.Text = "";
            B72.Text = "";
            B73.Text = "";
            B74.Text = "";
            B75.Text = "";
            B76.Text = "";
            B77.Text = "";
            B78.Text = "";
            B79.Text = "";
            B80.Text = "";
            B81.Text = "";
            B82.Text = "";
            B83.Text = "";
            B84.Text = "";
            B85.Text = "";
            B86.Text = "";
            B87.Text = "";
            B88.Text = "";
            B89.Text = "";
            B90.Text = "";
            B91.Text = "";
            B92.Text = "";
            B93.Text = "";
            B94.Text = "";
            B95.Text = "";
            B96.Text = "";
            B97.Text = "";
            B98.Text = "";
            B99.Text = "";
            B100.Text = "";
        }

        //-----------------------------------------------------------------------------------------\\
        //Bellow this point sets up the reset buttons gray green flicker effect  

        private void Greentmr_Tick(object sender, EventArgs e)
        {
            Resetbtn1.BackColor = Color.Green;
            GreyTimer.Enabled = true;
            Greentmr.Enabled = false;
        }

        private void GreyTimer_Tick(object sender, EventArgs e)
        {
            Resetbtn1.BackColor = Color.Gray;
            GreyTimer.Enabled = false;
            Greentmr.Enabled = true;
        }


        //-----------------------------------------------------------------------------------------\\
        // Bellow this is all the flags system 
      

        private void B10_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                b.BackColor = Color.Blue;
            }
        }
        //-----------------------------------------------------------------------------------------\\
        // Bellow this is the timer for the game 
        int x = 0;  
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            x++;

            label1.Text= x.ToString();
        }
    }
}
