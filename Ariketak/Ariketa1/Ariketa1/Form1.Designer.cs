namespace Ariketa1
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
            this.btnEsaldi1 = new System.Windows.Forms.Button();
            this.txtEsaldia = new System.Windows.Forms.TextBox();
            this.btnEsaldi2 = new System.Windows.Forms.Button();
            this.btnEsaldi3 = new System.Windows.Forms.Button();
            this.btnEsaldi4 = new System.Windows.Forms.Button();
            this.btnEsaldi5 = new System.Windows.Forms.Button();
            this.btnLotu = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEsaldi1
            // 
            this.btnEsaldi1.Location = new System.Drawing.Point(131, 194);
            this.btnEsaldi1.Name = "btnEsaldi1";
            this.btnEsaldi1.Size = new System.Drawing.Size(101, 54);
            this.btnEsaldi1.TabIndex = 0;
            this.btnEsaldi1.Text = "Esaldi 1";
            this.btnEsaldi1.UseVisualStyleBackColor = true;
            this.btnEsaldi1.Click += new System.EventHandler(this.btnEsaldi1_Click);
            // 
            // txtEsaldia
            // 
            this.txtEsaldia.Location = new System.Drawing.Point(186, 46);
            this.txtEsaldia.Multiline = true;
            this.txtEsaldia.Name = "txtEsaldia";
            this.txtEsaldia.Size = new System.Drawing.Size(411, 116);
            this.txtEsaldia.TabIndex = 1;
            // 
            // btnEsaldi2
            // 
            this.btnEsaldi2.Enabled = false;
            this.btnEsaldi2.Location = new System.Drawing.Point(355, 194);
            this.btnEsaldi2.Name = "btnEsaldi2";
            this.btnEsaldi2.Size = new System.Drawing.Size(101, 54);
            this.btnEsaldi2.TabIndex = 2;
            this.btnEsaldi2.Text = "Esaldi 2";
            this.btnEsaldi2.UseVisualStyleBackColor = true;
            this.btnEsaldi2.Click += new System.EventHandler(this.btnEsaldi2_Click);
            // 
            // btnEsaldi3
            // 
            this.btnEsaldi3.Enabled = false;
            this.btnEsaldi3.Location = new System.Drawing.Point(584, 194);
            this.btnEsaldi3.Name = "btnEsaldi3";
            this.btnEsaldi3.Size = new System.Drawing.Size(101, 54);
            this.btnEsaldi3.TabIndex = 3;
            this.btnEsaldi3.Text = "Esaldi 3";
            this.btnEsaldi3.UseVisualStyleBackColor = true;
            this.btnEsaldi3.Click += new System.EventHandler(this.btnEsaldi3_Click);
            // 
            // btnEsaldi4
            // 
            this.btnEsaldi4.Enabled = false;
            this.btnEsaldi4.Location = new System.Drawing.Point(131, 283);
            this.btnEsaldi4.Name = "btnEsaldi4";
            this.btnEsaldi4.Size = new System.Drawing.Size(101, 54);
            this.btnEsaldi4.TabIndex = 4;
            this.btnEsaldi4.Text = "Esaldi 4";
            this.btnEsaldi4.UseVisualStyleBackColor = true;
            this.btnEsaldi4.Click += new System.EventHandler(this.btnEsaldi4_Click);
            // 
            // btnEsaldi5
            // 
            this.btnEsaldi5.Enabled = false;
            this.btnEsaldi5.Location = new System.Drawing.Point(355, 283);
            this.btnEsaldi5.Name = "btnEsaldi5";
            this.btnEsaldi5.Size = new System.Drawing.Size(101, 54);
            this.btnEsaldi5.TabIndex = 5;
            this.btnEsaldi5.Text = "Esaldi 5";
            this.btnEsaldi5.UseVisualStyleBackColor = true;
            this.btnEsaldi5.Click += new System.EventHandler(this.btnEsaldi5_Click);
            // 
            // btnLotu
            // 
            this.btnLotu.Enabled = false;
            this.btnLotu.Location = new System.Drawing.Point(584, 283);
            this.btnLotu.Name = "btnLotu";
            this.btnLotu.Size = new System.Drawing.Size(101, 54);
            this.btnLotu.TabIndex = 6;
            this.btnLotu.Text = "Lotu";
            this.btnLotu.UseVisualStyleBackColor = true;
            this.btnLotu.Click += new System.EventHandler(this.btnLotu_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Location = new System.Drawing.Point(244, 358);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(101, 54);
            this.btnGarbitu.TabIndex = 7;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Location = new System.Drawing.Point(468, 358);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(101, 54);
            this.btnIrten.TabIndex = 8;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnLotu);
            this.Controls.Add(this.btnEsaldi5);
            this.Controls.Add(this.btnEsaldi4);
            this.Controls.Add(this.btnEsaldi3);
            this.Controls.Add(this.btnEsaldi2);
            this.Controls.Add(this.txtEsaldia);
            this.Controls.Add(this.btnEsaldi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEsaldi1;
        private TextBox txtEsaldia;
        private Button btnEsaldi2;
        private Button btnEsaldi3;
        private Button btnEsaldi4;
        private Button btnEsaldi5;
        private Button btnLotu;
        private Button btnGarbitu;
        private Button btnIrten;
    }
}