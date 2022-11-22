namespace Ariketa2
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPausoa = new System.Windows.Forms.TextBox();
            this.txtZenbakia = new System.Windows.Forms.TextBox();
            this.btnHurrengoa = new System.Windows.Forms.Button();
            this.btnGarbitu = new System.Windows.Forms.Button();
            this.btnIrten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPausoa
            // 
            this.txtPausoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPausoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPausoa.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtPausoa.Location = new System.Drawing.Point(67, 86);
            this.txtPausoa.Name = "txtPausoa";
            this.txtPausoa.ReadOnly = true;
            this.txtPausoa.Size = new System.Drawing.Size(156, 39);
            this.txtPausoa.TabIndex = 1;
            this.txtPausoa.Text = "1. Zenbakia";
            // 
            // txtZenbakia
            // 
            this.txtZenbakia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtZenbakia.Location = new System.Drawing.Point(267, 86);
            this.txtZenbakia.Name = "txtZenbakia";
            this.txtZenbakia.Size = new System.Drawing.Size(435, 39);
            this.txtZenbakia.TabIndex = 2;
            // 
            // btnHurrengoa
            // 
            this.btnHurrengoa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHurrengoa.Location = new System.Drawing.Point(67, 247);
            this.btnHurrengoa.Name = "btnHurrengoa";
            this.btnHurrengoa.Size = new System.Drawing.Size(156, 42);
            this.btnHurrengoa.TabIndex = 3;
            this.btnHurrengoa.Text = "Hurrengoa";
            this.btnHurrengoa.UseVisualStyleBackColor = true;
            this.btnHurrengoa.Click += new System.EventHandler(this.btnHurrengoa_Click);
            // 
            // btnGarbitu
            // 
            this.btnGarbitu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGarbitu.Location = new System.Drawing.Point(311, 247);
            this.btnGarbitu.Name = "btnGarbitu";
            this.btnGarbitu.Size = new System.Drawing.Size(156, 42);
            this.btnGarbitu.TabIndex = 4;
            this.btnGarbitu.Text = "Garbitu";
            this.btnGarbitu.UseVisualStyleBackColor = true;
            this.btnGarbitu.Click += new System.EventHandler(this.btnGarbitu_Click);
            // 
            // btnIrten
            // 
            this.btnIrten.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIrten.Location = new System.Drawing.Point(546, 247);
            this.btnIrten.Name = "btnIrten";
            this.btnIrten.Size = new System.Drawing.Size(156, 42);
            this.btnIrten.TabIndex = 5;
            this.btnIrten.Text = "Irten";
            this.btnIrten.UseVisualStyleBackColor = true;
            this.btnIrten.Click += new System.EventHandler(this.btnIrten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.btnIrten);
            this.Controls.Add(this.btnGarbitu);
            this.Controls.Add(this.btnHurrengoa);
            this.Controls.Add(this.txtZenbakia);
            this.Controls.Add(this.txtPausoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtPausoa;
        private TextBox txtZenbakia;
        private Button btnHurrengoa;
        private Button btnGarbitu;
        private Button btnIrten;
    }
}