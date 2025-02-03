using System; using System.Windows.Forms; namespace NewYears
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }
        int[] total = new int[8];
        private void Bit1_TextChanged(object sender, EventArgs e)
        { if (Bit1.Text.Equals("1")) { total[0] += 1; } total[3] += 1; }
        private void Bit2_TextChanged(object sender, EventArgs e)
        { if (Bit2.Text.Equals("1")) { total[0] += 2; } total[3] += 2; }
        private void Bit3_TextChanged(object sender, EventArgs e)
        { if (Bit3.Text.Equals("1")) { total[0] += 4; } total[3] += 4; }
        private void Bit4_TextChanged(object sender, EventArgs e)
        { if (Bit4.Text.Equals("1")) { total[0] += 8; } total[3] += 8; }
        private void Bit5_TextChanged(object sender, EventArgs e)
        { if (Bit5.Text.Equals("1")) { total[0] += 16; } total[3] += 16; }
        private void Bit6_TextChanged(object sender, EventArgs e)
        { if (Bit6.Text.Equals("1")) { total[0] += 32; } total[3] += 32; }
        private void Bit7_TextChanged(object sender, EventArgs e)
        { if (Bit7.Text.Equals("1")) { total[0] += 64; } total[3] += 64; }
        private void Bit8_TextChanged(object sender, EventArgs e)
        { if (Bit8.Text.Equals("1")) { total[0] += 144; } total[3] += 144; }
        private void Bit9_TextChanged(object sender, EventArgs e)
        { if (Bit9.Text.Equals("1")) { total[1] += 1; } total[3] += 1; }
        private void Bit10_TextChanged(object sender, EventArgs e)
        { if (Bit10.Text.Equals("1")) { total[1] += 2; } total[3] += 2; }
        private void Bit11_TextChanged(object sender, EventArgs e)
        { if (Bit11.Text.Equals("1")) { total[1] += 4; } total[3] += 4; }
        private void Bit12_TextChanged(object sender, EventArgs e)
        { if (Bit12.Text.Equals("1")) { total[1] += 8; } total[3] += 8; }
        private void Bit13_TextChanged(object sender, EventArgs e)
        { if (Bit13.Text.Equals("1")) { total[1] += 16; } total[3] += 16; }
        private void Bit14_TextChanged(object sender, EventArgs e)
        { if (Bit14.Text.Equals("1")) { total[1] += 32; } total[3] += 32; }
        private void Bit15_TextChanged(object sender, EventArgs e)
        { if (Bit15.Text.Equals("1")) { total[1] += 64; } total[3] += 64; }
        private void Bit16_TextChanged(object sender, EventArgs e)
        { if (Bit16.Text.Equals("1")) { total[1] += 144; } total[3] += 144; }
        private void Bit17_TextChanged(object sender, EventArgs e)
        { if (Bit17.Text.Equals("1")) { total[2] += 1; } total[3] += 1; }
        private void Bit18_TextChanged(object sender, EventArgs e)
        { if (Bit18.Text.Equals("1")) { total[2] += 2; } total[3] += 2; }
        private void Bit19_TextChanged(object sender, EventArgs e)
        { if (Bit19.Text.Equals("1")) { total[2] += 4; } total[3] += 4; }
        private void Bit20_TextChanged(object sender, EventArgs e)
        { if (Bit20.Text.Equals("1")) { total[2] += 8; } total[3] += 8; }
        private void Bit21_TextChanged(object sender, EventArgs e)
        { if (Bit21.Text.Equals("1")) { total[2] += 16; } total[3] += 16; }
        private void Bit22_TextChanged(object sender, EventArgs e)
        { if (Bit22.Text.Equals("1")) { total[2] += 32; } total[3] += 32; }
        private void Bit23_TextChanged(object sender, EventArgs e)
        { if (Bit23.Text.Equals("1")) { total[2] += 64; } total[3] += 64; }
        private void Bit24_TextChanged(object sender, EventArgs e)
        { if (Bit24.Text.Equals("1")) { total[2] += 144; } total[3] += 144; }
        private void button1_Click(object sender, EventArgs e)
        { Line1.Text = "0"; Bit1.Text = "0"; Bit2.Text = "0"; Bit3.Text = "0"; Bit4.Text = "0"; Bit5.Text = "0"; Bit6.Text = "0"; Bit7.Text = "0"; Bit8.Text = "0"; total[0] = 0; }
        private void ResetBtn2_Click(object sender, EventArgs e)
        { Line2.Text = "0"; Bit9.Text = "0"; Bit10.Text = "0"; Bit11.Text = "0"; Bit12.Text = "0"; Bit13.Text = "0"; Bit14.Text = "0"; Bit15.Text = "0"; Bit16.Text = "0"; total[1] = 0; }
        private void ResetBtn3_Click(object sender, EventArgs e)
        { Line3.Text = "0"; Bit17.Text = "0"; Bit18.Text = "0"; Bit19.Text = "0"; Bit20.Text = "0"; Bit21.Text = "0"; Bit22.Text = "0"; Bit23.Text = "0"; Bit24.Text = "0"; total[2] = 0; }
        private void ResetAllBtn_Click(object sender, EventArgs e)
        { Line1.Text = "0"; Bit1.Text = "0"; Bit2.Text = "0"; Bit3.Text = "0"; Bit4.Text = "0"; Bit5.Text = "0"; Bit6.Text = "0"; Bit7.Text = "0"; Bit8.Text = "0"; total[0] = 0; Line2.Text = "0"; Bit9.Text = "0"; Bit10.Text = "0"; Bit11.Text = "0"; Bit12.Text = "0"; Bit13.Text = "0"; Bit14.Text = "0"; Bit15.Text = "0"; Bit16.Text = "0"; total[1] = 0; Line3.Text = "0"; Bit17.Text = "0"; Bit18.Text = "0"; Bit19.Text = "0"; Bit20.Text = "0"; Bit21.Text = "0"; Bit22.Text = "0"; Bit23.Text = "0"; Bit24.Text = "0"; total[2] = 0; total[3] = 0; label5.Text = "0"; }
        private void ConfigBTN_Click(object sender, EventArgs e)
        { Line1.Text = total[0].ToString(); Line2.Text = total[1].ToString(); Line3.Text = total[2].ToString(); label5.Text = total[3].ToString(); }
        private void Bit24_MouseDown(object sender, MouseEventArgs e)
        { if (((TextBox)sender).Text == "1") { ((TextBox)sender).Text = "0"; } else { ((TextBox)sender).Text = "1"; } }
        private void shiftLeftBtn_Click(object sender, EventArgs e)
        {
            if ((Bit1.Text).Equals("1"))
            {
                Bit2.Text = "1"; Bit1.Text = "0"; 
            }
            if ((Bit2.Text).Equals("1"))
            {
                Bit3.Text = "1"; Bit2.Text = "0";
            }
            if ((Bit3.Text).Equals("1"))
            {
                Bit4.Text = "1"; Bit3.Text = "0";

            }
            if ((Bit4.Text).Equals("1"))
            {
                Bit5.Text = "1"; Bit4.Text = "0";

            }
            if ((Bit5.Text).Equals("1"))
            {
                Bit6.Text = "1"; Bit5.Text = "0";

            }
            if ((Bit6.Text).Equals("1"))
            {
                Bit7.Text = "1"; Bit6.Text = "0";

            }
            if ((Bit7.Text).Equals("1"))
            {
                Bit8.Text = "1"; Bit7.Text = "0";

            }
            if ((Bit8.Text).Equals("1"))
            {
               Bit8.Text = "0";

            }
        }
    }
}
//total[3]+=1;