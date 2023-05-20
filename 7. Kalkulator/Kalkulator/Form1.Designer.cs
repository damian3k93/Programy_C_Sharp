namespace Kalkulator
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
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b000 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b00 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bWynik = new System.Windows.Forms.Button();
            this.bPierwiastek = new System.Windows.Forms.Button();
            this.bProcent = new System.Windows.Forms.Button();
            this.bOdwrotna = new System.Windows.Forms.Button();
            this.bPrzeciwna = new System.Windows.Forms.Button();
            this.bDzielenie = new System.Windows.Forms.Button();
            this.bMnozenie = new System.Windows.Forms.Button();
            this.bOdejmowanie = new System.Windows.Forms.Button();
            this.bDodawanie = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbWynik
            // 
            this.tbWynik.Location = new System.Drawing.Point(29, 21);
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.Size = new System.Drawing.Size(271, 20);
            this.tbWynik.TabIndex = 0;
            this.tbWynik.TextChanged += new System.EventHandler(this.tbWynik_TextChanged);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(6, 77);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(33, 23);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b000);
            this.groupBox1.Controls.Add(this.b0);
            this.groupBox1.Controls.Add(this.b9);
            this.groupBox1.Controls.Add(this.b8);
            this.groupBox1.Controls.Add(this.b00);
            this.groupBox1.Controls.Add(this.b7);
            this.groupBox1.Controls.Add(this.b6);
            this.groupBox1.Controls.Add(this.b5);
            this.groupBox1.Controls.Add(this.b4);
            this.groupBox1.Controls.Add(this.b3);
            this.groupBox1.Controls.Add(this.b2);
            this.groupBox1.Controls.Add(this.b1);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cyfry";
            // 
            // b000
            // 
            this.b000.Location = new System.Drawing.Point(84, 108);
            this.b000.Name = "b000";
            this.b000.Size = new System.Drawing.Size(33, 23);
            this.b000.TabIndex = 11;
            this.b000.Text = "000";
            this.b000.UseVisualStyleBackColor = true;
            this.b000.Click += new System.EventHandler(this.b000_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(6, 108);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(33, 23);
            this.b0.TabIndex = 12;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(84, 19);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(33, 23);
            this.b9.TabIndex = 9;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(45, 19);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(33, 23);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b00
            // 
            this.b00.Location = new System.Drawing.Point(45, 108);
            this.b00.Name = "b00";
            this.b00.Size = new System.Drawing.Size(33, 23);
            this.b00.TabIndex = 10;
            this.b00.Text = "00";
            this.b00.UseVisualStyleBackColor = true;
            this.b00.Click += new System.EventHandler(this.b00_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(6, 19);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(33, 23);
            this.b7.TabIndex = 7;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(84, 48);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(33, 23);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(45, 48);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(33, 23);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(6, 48);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(33, 23);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(84, 77);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(33, 23);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(45, 77);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(33, 23);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bWynik);
            this.groupBox2.Controls.Add(this.bPierwiastek);
            this.groupBox2.Controls.Add(this.bProcent);
            this.groupBox2.Controls.Add(this.bOdwrotna);
            this.groupBox2.Controls.Add(this.bPrzeciwna);
            this.groupBox2.Controls.Add(this.bDzielenie);
            this.groupBox2.Controls.Add(this.bMnozenie);
            this.groupBox2.Controls.Add(this.bOdejmowanie);
            this.groupBox2.Controls.Add(this.bDodawanie);
            this.groupBox2.Location = new System.Drawing.Point(160, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funkcje matematyczne";
            // 
            // bWynik
            // 
            this.bWynik.Location = new System.Drawing.Point(84, 77);
            this.bWynik.Name = "bWynik";
            this.bWynik.Size = new System.Drawing.Size(71, 23);
            this.bWynik.TabIndex = 11;
            this.bWynik.Text = "=";
            this.bWynik.UseVisualStyleBackColor = true;
            this.bWynik.Click += new System.EventHandler(this.bWynik_Click);
            // 
            // bPierwiastek
            // 
            this.bPierwiastek.Location = new System.Drawing.Point(123, 48);
            this.bPierwiastek.Name = "bPierwiastek";
            this.bPierwiastek.Size = new System.Drawing.Size(33, 23);
            this.bPierwiastek.TabIndex = 4;
            this.bPierwiastek.Text = "√";
            this.bPierwiastek.UseVisualStyleBackColor = true;
            this.bPierwiastek.Click += new System.EventHandler(this.bPierwiastek_Click);
            // 
            // bProcent
            // 
            this.bProcent.Location = new System.Drawing.Point(6, 77);
            this.bProcent.Name = "bProcent";
            this.bProcent.Size = new System.Drawing.Size(72, 23);
            this.bProcent.TabIndex = 4;
            this.bProcent.Text = "a % b";
            this.bProcent.UseVisualStyleBackColor = true;
            this.bProcent.Click += new System.EventHandler(this.bProcent_Click);
            // 
            // bOdwrotna
            // 
            this.bOdwrotna.Location = new System.Drawing.Point(45, 48);
            this.bOdwrotna.Name = "bOdwrotna";
            this.bOdwrotna.Size = new System.Drawing.Size(33, 23);
            this.bOdwrotna.TabIndex = 4;
            this.bOdwrotna.Text = "1/x";
            this.bOdwrotna.UseVisualStyleBackColor = true;
            this.bOdwrotna.Click += new System.EventHandler(this.bOdwrotna_Click);
            // 
            // bPrzeciwna
            // 
            this.bPrzeciwna.Location = new System.Drawing.Point(6, 48);
            this.bPrzeciwna.Name = "bPrzeciwna";
            this.bPrzeciwna.Size = new System.Drawing.Size(33, 23);
            this.bPrzeciwna.TabIndex = 4;
            this.bPrzeciwna.Text = "- x";
            this.bPrzeciwna.UseVisualStyleBackColor = true;
            this.bPrzeciwna.Click += new System.EventHandler(this.bPrzeciwna_Click);
            // 
            // bDzielenie
            // 
            this.bDzielenie.Location = new System.Drawing.Point(123, 19);
            this.bDzielenie.Name = "bDzielenie";
            this.bDzielenie.Size = new System.Drawing.Size(33, 23);
            this.bDzielenie.TabIndex = 4;
            this.bDzielenie.Text = "/";
            this.bDzielenie.UseVisualStyleBackColor = true;
            this.bDzielenie.Click += new System.EventHandler(this.bDzielenie_Click);
            // 
            // bMnozenie
            // 
            this.bMnozenie.Location = new System.Drawing.Point(84, 19);
            this.bMnozenie.Name = "bMnozenie";
            this.bMnozenie.Size = new System.Drawing.Size(33, 23);
            this.bMnozenie.TabIndex = 4;
            this.bMnozenie.Text = "*";
            this.bMnozenie.UseVisualStyleBackColor = true;
            this.bMnozenie.Click += new System.EventHandler(this.bMnozenie_Click);
            // 
            // bOdejmowanie
            // 
            this.bOdejmowanie.Location = new System.Drawing.Point(45, 19);
            this.bOdejmowanie.Name = "bOdejmowanie";
            this.bOdejmowanie.Size = new System.Drawing.Size(33, 23);
            this.bOdejmowanie.TabIndex = 4;
            this.bOdejmowanie.Text = "-";
            this.bOdejmowanie.UseVisualStyleBackColor = true;
            this.bOdejmowanie.Click += new System.EventHandler(this.bOdejmowanie_Click);
            // 
            // bDodawanie
            // 
            this.bDodawanie.Location = new System.Drawing.Point(6, 19);
            this.bDodawanie.Name = "bDodawanie";
            this.bDodawanie.Size = new System.Drawing.Size(33, 23);
            this.bDodawanie.TabIndex = 10;
            this.bDodawanie.Text = "+";
            this.bDodawanie.UseVisualStyleBackColor = true;
            this.bDodawanie.Click += new System.EventHandler(this.bDodawanie_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(205, 193);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(71, 23);
            this.bClear.TabIndex = 12;
            this.bClear.Text = "CE";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 265);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbWynik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWynik;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b000;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b00;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bWynik;
        private System.Windows.Forms.Button bPierwiastek;
        private System.Windows.Forms.Button bProcent;
        private System.Windows.Forms.Button bOdwrotna;
        private System.Windows.Forms.Button bPrzeciwna;
        private System.Windows.Forms.Button bDzielenie;
        private System.Windows.Forms.Button bMnozenie;
        private System.Windows.Forms.Button bOdejmowanie;
        private System.Windows.Forms.Button bDodawanie;
        private System.Windows.Forms.Button bClear;
    }
}

