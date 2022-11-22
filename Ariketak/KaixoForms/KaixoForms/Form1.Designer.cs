namespace KaixoForms
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
            this.btnErakutsi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnErakutsi
            // 
            this.btnErakutsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErakutsi.Location = new System.Drawing.Point(54, 62);
            this.btnErakutsi.Name = "btnErakutsi";
            this.btnErakutsi.Size = new System.Drawing.Size(393, 88);
            this.btnErakutsi.TabIndex = 0;
            this.btnErakutsi.Text = "Mezua Erakutsi";
            this.btnErakutsi.UseVisualStyleBackColor = true;
            this.btnErakutsi.Click += new System.EventHandler(this.btnErakutsi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 213);
            this.Controls.Add(this.btnErakutsi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnErakutsi;
    }
}

