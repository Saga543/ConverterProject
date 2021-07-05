
namespace Projekt_W62950
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbJednostki = new System.Windows.Forms.GroupBox();
            this.rbSL = new System.Windows.Forms.RadioButton();
            this.rbPamiec = new System.Windows.Forms.RadioButton();
            this.rbCzas = new System.Windows.Forms.RadioButton();
            this.rbMasa = new System.Windows.Forms.RadioButton();
            this.rbDługosc = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bKonwertuj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bWyczysc = new System.Windows.Forms.Button();
            this.bZamknij = new System.Windows.Forms.Button();
            this.gbJednostki.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJednostki
            // 
            this.gbJednostki.Controls.Add(this.rbSL);
            this.gbJednostki.Controls.Add(this.rbPamiec);
            this.gbJednostki.Controls.Add(this.rbCzas);
            this.gbJednostki.Controls.Add(this.rbMasa);
            this.gbJednostki.Controls.Add(this.rbDługosc);
            this.gbJednostki.Location = new System.Drawing.Point(30, 12);
            this.gbJednostki.Name = "gbJednostki";
            this.gbJednostki.Size = new System.Drawing.Size(503, 55);
            this.gbJednostki.TabIndex = 0;
            this.gbJednostki.TabStop = false;
            this.gbJednostki.Text = "Jednostki";
            // 
            // rbSL
            // 
            this.rbSL.AutoSize = true;
            this.rbSL.Location = new System.Drawing.Point(352, 22);
            this.rbSL.Name = "rbSL";
            this.rbSL.Size = new System.Drawing.Size(118, 19);
            this.rbSL.TabIndex = 4;
            this.rbSL.Text = "Systemy liczbowe";
            this.rbSL.UseVisualStyleBackColor = true;
            this.rbSL.CheckedChanged += new System.EventHandler(this.rbSL_CheckedChanged);
            // 
            // rbPamiec
            // 
            this.rbPamiec.AutoSize = true;
            this.rbPamiec.Location = new System.Drawing.Point(262, 22);
            this.rbPamiec.Name = "rbPamiec";
            this.rbPamiec.Size = new System.Drawing.Size(64, 19);
            this.rbPamiec.TabIndex = 3;
            this.rbPamiec.Text = "Pamięć";
            this.rbPamiec.UseVisualStyleBackColor = true;
            this.rbPamiec.CheckedChanged += new System.EventHandler(this.rbPamiec_CheckedChanged);
            // 
            // rbCzas
            // 
            this.rbCzas.AutoSize = true;
            this.rbCzas.Location = new System.Drawing.Point(190, 23);
            this.rbCzas.Name = "rbCzas";
            this.rbCzas.Size = new System.Drawing.Size(49, 19);
            this.rbCzas.TabIndex = 2;
            this.rbCzas.Text = "Czas";
            this.rbCzas.UseVisualStyleBackColor = true;
            this.rbCzas.CheckedChanged += new System.EventHandler(this.rbCzas_CheckedChanged);
            // 
            // rbMasa
            // 
            this.rbMasa.AutoSize = true;
            this.rbMasa.Location = new System.Drawing.Point(102, 23);
            this.rbMasa.Name = "rbMasa";
            this.rbMasa.Size = new System.Drawing.Size(53, 19);
            this.rbMasa.TabIndex = 1;
            this.rbMasa.Text = "Masa";
            this.rbMasa.UseVisualStyleBackColor = true;
            this.rbMasa.CheckedChanged += new System.EventHandler(this.rbMasa_CheckedChanged);
            // 
            // rbDługosc
            // 
            this.rbDługosc.AutoSize = true;
            this.rbDługosc.Checked = true;
            this.rbDługosc.Location = new System.Drawing.Point(7, 23);
            this.rbDługosc.Name = "rbDługosc";
            this.rbDługosc.Size = new System.Drawing.Size(68, 19);
            this.rbDługosc.TabIndex = 0;
            this.rbDługosc.TabStop = true;
            this.rbDługosc.Text = "Długość";
            this.rbDługosc.UseVisualStyleBackColor = true;
            this.rbDługosc.CheckedChanged += new System.EventHandler(this.rbDługosc_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bKonwertuj
            // 
            this.bKonwertuj.Location = new System.Drawing.Point(52, 159);
            this.bKonwertuj.Name = "bKonwertuj";
            this.bKonwertuj.Size = new System.Drawing.Size(105, 30);
            this.bKonwertuj.TabIndex = 2;
            this.bKonwertuj.Text = "Konwertuj";
            this.bKonwertuj.UseVisualStyleBackColor = true;
            this.bKonwertuj.Click += new System.EventHandler(this.bKonwertuj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(193, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Długość";
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(7, 127);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(42, 19);
            this.rb5.TabIndex = 4;
            this.rb5.Text = "km";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(7, 101);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(36, 19);
            this.rb4.TabIndex = 3;
            this.rb4.Text = "m";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(7, 75);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(43, 19);
            this.rb3.TabIndex = 2;
            this.rb3.Text = "dm";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(7, 49);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(42, 19);
            this.rb2.TabIndex = 1;
            this.rb2.Text = "cm";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(7, 23);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(47, 19);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "mm";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(352, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(352, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 23);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(352, 195);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 23);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(352, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 23);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(352, 265);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 23);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(519, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(61, 170);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "dm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "cm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "mm";
            // 
            // bWyczysc
            // 
            this.bWyczysc.Location = new System.Drawing.Point(52, 203);
            this.bWyczysc.Name = "bWyczysc";
            this.bWyczysc.Size = new System.Drawing.Size(105, 30);
            this.bWyczysc.TabIndex = 10;
            this.bWyczysc.Text = "Wyczyść";
            this.bWyczysc.UseVisualStyleBackColor = true;
            this.bWyczysc.Click += new System.EventHandler(this.bWyczysc_Click);
            // 
            // bZamknij
            // 
            this.bZamknij.Location = new System.Drawing.Point(52, 253);
            this.bZamknij.Name = "bZamknij";
            this.bZamknij.Size = new System.Drawing.Size(105, 30);
            this.bZamknij.TabIndex = 11;
            this.bZamknij.Text = "Zamknij";
            this.bZamknij.UseVisualStyleBackColor = true;
            this.bZamknij.Click += new System.EventHandler(this.bZamknij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 389);
            this.Controls.Add(this.bZamknij);
            this.Controls.Add(this.bWyczysc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bKonwertuj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbJednostki);
            this.Name = "Form1";
            this.Text = "Konwerter jednostek";
            this.gbJednostki.ResumeLayout(false);
            this.gbJednostki.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJednostki;
        private System.Windows.Forms.RadioButton rbMasa;
        private System.Windows.Forms.RadioButton rbDługosc;
        private System.Windows.Forms.RadioButton rbCzas;
        private System.Windows.Forms.RadioButton rbSL;
        private System.Windows.Forms.RadioButton rbPamiec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bKonwertuj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bWyczysc;
        private System.Windows.Forms.Button bZamknij;
    }
}

