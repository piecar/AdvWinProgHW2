namespace AdvWinProgHW2
{
    partial class UserControlOath
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOath
            // 
            this.labelOath.AutoSize = true;
            this.labelOath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOath.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelOath.Location = new System.Drawing.Point(0, 0);
            this.labelOath.Name = "labelOath";
            this.labelOath.Size = new System.Drawing.Size(357, 60);
            this.labelOath.TabIndex = 0;
            this.labelOath.Text = "I understand that this homework will be the basis for a quiz.\r\n\r\n      It is in m" +
    "y best interest to do the homework and study all the\r\n      code for the homewor" +
    "k.\r\n";
            // 
            // UserControlOath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelOath);
            this.Name = "UserControlOath";
            this.Size = new System.Drawing.Size(364, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOath;
    }
}
