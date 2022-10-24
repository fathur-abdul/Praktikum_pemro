namespace P6_1_1204075
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
            this.BVisual = new System.Windows.Forms.Button();
            this.Bc = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BVisual
            // 
            this.BVisual.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BVisual.Location = new System.Drawing.Point(66, 79);
            this.BVisual.Name = "BVisual";
            this.BVisual.Size = new System.Drawing.Size(109, 38);
            this.BVisual.TabIndex = 0;
            this.BVisual.Text = "Visual Basic";
            this.BVisual.UseVisualStyleBackColor = true;
            this.BVisual.Click += new System.EventHandler(this.BVisual_Click);
            this.BVisual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BVisual_MouseMove);
            // 
            // Bc
            // 
            this.Bc.ForeColor = System.Drawing.Color.Red;
            this.Bc.Location = new System.Drawing.Point(343, 79);
            this.Bc.Name = "Bc";
            this.Bc.Size = new System.Drawing.Size(109, 38);
            this.Bc.TabIndex = 1;
            this.Bc.Text = "C#";
            this.Bc.UseVisualStyleBackColor = true;
            this.Bc.Click += new System.EventHandler(this.Bc_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(12, 400);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(109, 38);
            this.BClose.TabIndex = 2;
            this.BClose.Text = "Close";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.Bc);
            this.Controls.Add(this.BVisual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BVisual;
        private System.Windows.Forms.Button Bc;
        private System.Windows.Forms.Button BClose;
    }
}

