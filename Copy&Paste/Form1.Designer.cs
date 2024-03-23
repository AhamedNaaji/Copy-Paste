namespace Copy_Paste
{
    partial class CopyPaste
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
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.txtPaste = new System.Windows.Forms.TextBox();
            this.btncopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCopy
            // 
            this.txtCopy.BackColor = System.Drawing.Color.Black;
            this.txtCopy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopy.ForeColor = System.Drawing.Color.White;
            this.txtCopy.Location = new System.Drawing.Point(12, 12);
            this.txtCopy.Multiline = true;
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(399, 269);
            this.txtCopy.TabIndex = 0;
            // 
            // txtPaste
            // 
            this.txtPaste.BackColor = System.Drawing.Color.Black;
            this.txtPaste.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaste.ForeColor = System.Drawing.Color.White;
            this.txtPaste.Location = new System.Drawing.Point(420, 12);
            this.txtPaste.Multiline = true;
            this.txtPaste.Name = "txtPaste";
            this.txtPaste.Size = new System.Drawing.Size(399, 269);
            this.txtPaste.TabIndex = 1;
            // 
            // btncopy
            // 
            this.btncopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncopy.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncopy.Location = new System.Drawing.Point(49, 287);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(317, 66);
            this.btncopy.TabIndex = 2;
            this.btncopy.Text = "Copy";
            this.btncopy.UseVisualStyleBackColor = false;
            this.btncopy.Click += new System.EventHandler(this.btncopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPaste.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.Location = new System.Drawing.Point(459, 287);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(317, 66);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // CopyPaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(831, 360);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btncopy);
            this.Controls.Add(this.txtPaste);
            this.Controls.Add(this.txtCopy);
            this.Name = "CopyPaste";
            this.Text = "Copy & Paste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCopy;
        private System.Windows.Forms.TextBox txtPaste;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.Button btnPaste;
    }
}

