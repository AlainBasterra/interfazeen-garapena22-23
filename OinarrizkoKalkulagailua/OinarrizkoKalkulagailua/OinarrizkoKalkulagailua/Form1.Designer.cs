namespace OinarrizkoKalkulagailua
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
            this.btnGehi = new System.Windows.Forms.Button();
            this.btnKen = new System.Windows.Forms.Button();
            this.btnBider = new System.Windows.Forms.Button();
            this.btnZati = new System.Windows.Forms.Button();
            this.txtZenbaki1 = new System.Windows.Forms.TextBox();
            this.txtZenbaki2 = new System.Windows.Forms.TextBox();
            this.btnIrten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGehi
            // 
            this.btnGehi.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGehi.Location = new System.Drawing.Point(294, 233);
            this.btnGehi.Name = "btnGehi";
            this.btnGehi.Size = new System.Drawing.Size(115, 107);
            this.btnGehi.TabIndex = 0;
            this.btnGehi.Text = "+";
            this.btnGehi.UseVisualStyleBackColor = true;
            this.btnGehi.Click += new System.EventHandler(this.btnGehi_Click);
            // 
            // btnKen
            // 
            this.btnKen.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKen.Location = new System.Drawing.Point(473, 233);
            this.btnKen.Name = "btnKen";
            this.btnKen.Size = new System.Drawing.Size(115, 107);
            this.btnKen.TabIndex = 1;
            this.btnKen.Text = "-";
            this.btnKen.UseVisualStyleBackColor = true;
            this.btnKen.Click += new System.EventHandler(this.btnKen_Click);
            // 
            // btnBider
            // 
            this.btnBider.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBider.Location = new System.Drawing.Point(294, 388);
            this.btnBider.Name = "btnBider";
            this.btnBider.Size = new System.Drawing.Size(115, 107);
            this.btnBider.TabIndex = 2;
            this.btnBider.Text = "x";
            this.btnBider.UseVisualStyleBackColor = true;
            this.btnBider.Click += new System.EventHandler(this.btnBider_Click);
            // 
            // btnZati
            // 
            this.btnZati.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnZati.Location = new System.Drawing.Point(473, 388);
            this.btnZati.Name = "btnZati";
            this.btnZati.Size = new System.Drawing.Size(115, 107);
            this.btnZati.TabIndex = 3;
            this.btnZati.Text = "/";
            this.btnZati.UseVisualStyleBackColor = true;
            this.btnZati.Click += new System.EventHandler(this.btnZati_Click);
            // 
            // txtZenbaki1
            // 
            this.txtZenbaki1.Location = new System.Drawing.Point(62, 125);
            this.txtZenbaki1.Name = "txtZenbaki1";
            this.txtZenbaki1.Size = new System.Drawing.Size(251, 23);
            this.txtZenbaki1.TabIndex = 4;
            this.txtZenbaki1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZenbaki1_KeyPress);
            // 
            // txtZenbaki2
            // 
            this.txtZenbaki2.Location = new System.Drawing.Point(578, 125);
            this.txtZenbaki2.Name = "txtZenbaki2";
            this.txtZenbaki2.Size = new System.Drawing.Size(251, 23);
            this.txtZenbaki2.TabIndex = 5;
            this.txtZenbaki2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZenbaki2_KeyPress);
            // 
            // btnIrten
            // 
            this.btnIrten.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIrten.Location = new System.Drawing.Point(814, 551);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(88, 45);
            this.btnIrten.TabIndex = 6;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 608);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.txtZenbaki2);
            this.Controls.Add(this.txtZenbaki1);
            this.Controls.Add(this.btnZati);
            this.Controls.Add(this.btnBider);
            this.Controls.Add(this.btnKen);
            this.Controls.Add(this.btnGehi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGehi;
        private Button btnKen;
        private Button btnBider;
        private Button btnZati;
        private TextBox txtZenbaki1;
        private TextBox txtZenbaki2;
        private Button btnIrten;
    }
}