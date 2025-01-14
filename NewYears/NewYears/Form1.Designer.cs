namespace NewYears
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bit5 = new System.Windows.Forms.TextBox();
            this.Bit4 = new System.Windows.Forms.TextBox();
            this.Bit3 = new System.Windows.Forms.TextBox();
            this.Bit2 = new System.Windows.Forms.TextBox();
            this.Bit1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Bit6 = new System.Windows.Forms.TextBox();
            this.Bit7 = new System.Windows.Forms.TextBox();
            this.Bit8 = new System.Windows.Forms.TextBox();
            this.ConfigBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bit5
            // 
            this.Bit5.Location = new System.Drawing.Point(309, 208);
            this.Bit5.Name = "Bit5";
            this.Bit5.Size = new System.Drawing.Size(23, 22);
            this.Bit5.TabIndex = 1;
            this.Bit5.TextChanged += new System.EventHandler(this.Bit5_TextChanged);
            // 
            // Bit4
            // 
            this.Bit4.Location = new System.Drawing.Point(338, 208);
            this.Bit4.Name = "Bit4";
            this.Bit4.Size = new System.Drawing.Size(23, 22);
            this.Bit4.TabIndex = 2;
            this.Bit4.TextChanged += new System.EventHandler(this.Bit4_TextChanged);
            // 
            // Bit3
            // 
            this.Bit3.Location = new System.Drawing.Point(367, 208);
            this.Bit3.Name = "Bit3";
            this.Bit3.Size = new System.Drawing.Size(23, 22);
            this.Bit3.TabIndex = 3;
            this.Bit3.TextChanged += new System.EventHandler(this.Bit3_TextChanged);
            // 
            // Bit2
            // 
            this.Bit2.Location = new System.Drawing.Point(396, 208);
            this.Bit2.Name = "Bit2";
            this.Bit2.Size = new System.Drawing.Size(23, 22);
            this.Bit2.TabIndex = 4;
            this.Bit2.TextChanged += new System.EventHandler(this.Bit2_TextChanged);
            // 
            // Bit1
            // 
            this.Bit1.Location = new System.Drawing.Point(425, 208);
            this.Bit1.Name = "Bit1";
            this.Bit1.Size = new System.Drawing.Size(23, 22);
            this.Bit1.TabIndex = 5;
            this.Bit1.TextChanged += new System.EventHandler(this.Bit1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Click the number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bit6
            // 
            this.Bit6.Location = new System.Drawing.Point(280, 208);
            this.Bit6.Name = "Bit6";
            this.Bit6.Size = new System.Drawing.Size(23, 22);
            this.Bit6.TabIndex = 9;
            this.Bit6.TextChanged += new System.EventHandler(this.Bit6_TextChanged);
            // 
            // Bit7
            // 
            this.Bit7.Location = new System.Drawing.Point(251, 208);
            this.Bit7.Name = "Bit7";
            this.Bit7.Size = new System.Drawing.Size(23, 22);
            this.Bit7.TabIndex = 10;
            this.Bit7.TextChanged += new System.EventHandler(this.Bit7_TextChanged);
            // 
            // Bit8
            // 
            this.Bit8.Location = new System.Drawing.Point(222, 209);
            this.Bit8.Name = "Bit8";
            this.Bit8.Size = new System.Drawing.Size(23, 22);
            this.Bit8.TabIndex = 11;
            this.Bit8.TextChanged += new System.EventHandler(this.Bit8_TextChanged);
            // 
            // ConfigBTN
            // 
            this.ConfigBTN.Location = new System.Drawing.Point(454, 195);
            this.ConfigBTN.Name = "ConfigBTN";
            this.ConfigBTN.Size = new System.Drawing.Size(75, 23);
            this.ConfigBTN.TabIndex = 12;
            this.ConfigBTN.Text = "Config";
            this.ConfigBTN.UseVisualStyleBackColor = true;
            this.ConfigBTN.Click += new System.EventHandler(this.ConfigBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfigBTN);
            this.Controls.Add(this.Bit8);
            this.Controls.Add(this.Bit7);
            this.Controls.Add(this.Bit6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bit1);
            this.Controls.Add(this.Bit2);
            this.Controls.Add(this.Bit3);
            this.Controls.Add(this.Bit4);
            this.Controls.Add(this.Bit5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Bit5;
        private System.Windows.Forms.TextBox Bit4;
        private System.Windows.Forms.TextBox Bit3;
        private System.Windows.Forms.TextBox Bit2;
        private System.Windows.Forms.TextBox Bit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Bit6;
        private System.Windows.Forms.TextBox Bit7;
        private System.Windows.Forms.TextBox Bit8;
        private System.Windows.Forms.Button ConfigBTN;
    }
}

