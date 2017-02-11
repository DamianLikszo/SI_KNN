namespace KNN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPokazTST = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPokazTRN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updownK = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMetryka = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnWynik = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownK)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWczytaj);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane";
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(107, 127);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(98, 30);
            this.btnWczytaj.TabIndex = 2;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPokazTST);
            this.groupBox5.Location = new System.Drawing.Point(162, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "System Testowy";
            // 
            // btnPokazTST
            // 
            this.btnPokazTST.Enabled = false;
            this.btnPokazTST.Location = new System.Drawing.Point(6, 48);
            this.btnPokazTST.Name = "btnPokazTST";
            this.btnPokazTST.Size = new System.Drawing.Size(138, 36);
            this.btnPokazTST.TabIndex = 0;
            this.btnPokazTST.Text = "Pokaż TST";
            this.btnPokazTST.UseVisualStyleBackColor = true;
            this.btnPokazTST.Click += new System.EventHandler(this.btnPokazTST_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPokazTRN);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "System Treningowy";
            // 
            // btnPokazTRN
            // 
            this.btnPokazTRN.Enabled = false;
            this.btnPokazTRN.Location = new System.Drawing.Point(6, 48);
            this.btnPokazTRN.Name = "btnPokazTRN";
            this.btnPokazTRN.Size = new System.Drawing.Size(136, 36);
            this.btnPokazTRN.TabIndex = 0;
            this.btnPokazTRN.Text = "Pokaż TRN";
            this.btnPokazTRN.UseVisualStyleBackColor = true;
            this.btnPokazTRN.Click += new System.EventHandler(this.btnPokazTRN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updownK);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboMetryka);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia";
            // 
            // updownK
            // 
            this.updownK.Location = new System.Drawing.Point(9, 108);
            this.updownK.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.updownK.Name = "updownK";
            this.updownK.Size = new System.Drawing.Size(185, 22);
            this.updownK.TabIndex = 5;
            this.updownK.ValueChanged += new System.EventHandler(this.updownK_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "k-NN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metryka:";
            // 
            // comboMetryka
            // 
            this.comboMetryka.FormattingEnabled = true;
            this.comboMetryka.Items.AddRange(new object[] {
            "Euklidesa",
            "Manhattana",
            "Canberra",
            "Czebyszewa",
            "BWK Persona"});
            this.comboMetryka.Location = new System.Drawing.Point(9, 52);
            this.comboMetryka.Name = "comboMetryka";
            this.comboMetryka.Size = new System.Drawing.Size(185, 24);
            this.comboMetryka.TabIndex = 3;
            this.comboMetryka.SelectedIndexChanged += new System.EventHandler(this.comboMetryka_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(542, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyniki";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnWynik);
            this.groupBox6.Location = new System.Drawing.Point(6, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(188, 136);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "System Wynikowy";
            // 
            // btnWynik
            // 
            this.btnWynik.Enabled = false;
            this.btnWynik.Location = new System.Drawing.Point(23, 48);
            this.btnWynik.Name = "btnWynik";
            this.btnWynik.Size = new System.Drawing.Size(145, 54);
            this.btnWynik.TabIndex = 0;
            this.btnWynik.Text = "Pokaż Wynik";
            this.btnWynik.UseVisualStyleBackColor = true;
            this.btnWynik.Click += new System.EventHandler(this.btnWynik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 185);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(770, 232);
            this.MinimumSize = new System.Drawing.Size(770, 232);
            this.Name = "Form1";
            this.Text = "k-NN - Damian Likszo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownK)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnPokazTST;
        private System.Windows.Forms.Button btnPokazTRN;
        private System.Windows.Forms.Button btnWynik;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMetryka;
        private System.Windows.Forms.NumericUpDown updownK;
    }
}

