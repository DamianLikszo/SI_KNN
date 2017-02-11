namespace KNN
{
    partial class Form2
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
            this.txtbLogi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.btnWyjscie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbMacierz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbLogi
            // 
            this.txtbLogi.Location = new System.Drawing.Point(386, 38);
            this.txtbLogi.Multiline = true;
            this.txtbLogi.Name = "txtbLogi";
            this.txtbLogi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbLogi.Size = new System.Drawing.Size(276, 408);
            this.txtbLogi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(438, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPowrot
            // 
            this.btnPowrot.Location = new System.Drawing.Point(12, 416);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(188, 30);
            this.btnPowrot.TabIndex = 2;
            this.btnPowrot.Text = "Powrót";
            this.btnPowrot.UseVisualStyleBackColor = true;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // btnWyjscie
            // 
            this.btnWyjscie.Location = new System.Drawing.Point(206, 416);
            this.btnWyjscie.Name = "btnWyjscie";
            this.btnWyjscie.Size = new System.Drawing.Size(174, 30);
            this.btnWyjscie.TabIndex = 3;
            this.btnWyjscie.Text = "Wyjście";
            this.btnWyjscie.UseVisualStyleBackColor = true;
            this.btnWyjscie.Click += new System.EventHandler(this.btnWyjscie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(49, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Macierz Predykcji:";
            // 
            // txtbMacierz
            // 
            this.txtbMacierz.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtbMacierz.Location = new System.Drawing.Point(12, 37);
            this.txtbMacierz.Multiline = true;
            this.txtbMacierz.Name = "txtbMacierz";
            this.txtbMacierz.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbMacierz.Size = new System.Drawing.Size(368, 372);
            this.txtbMacierz.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 457);
            this.Controls.Add(this.txtbMacierz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWyjscie);
            this.Controls.Add(this.btnPowrot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbLogi);
            this.Name = "Form2";
            this.Text = "k-NN - Damian Likszo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbLogi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.Button btnWyjscie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbMacierz;
    }
}