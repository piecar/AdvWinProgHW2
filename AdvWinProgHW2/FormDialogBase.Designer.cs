namespace AdvWinProgHW2
{
    partial class FormDialogBase
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
            this.userControlName1 = new AdvWinProgHW2.UserControlName();
            this.userControlCourse1 = new AdvWinProgHW2.UserControlCourse();
            this.PanelMid = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // userControlName1
            // 
            this.userControlName1.BackColor = System.Drawing.Color.Yellow;
            this.userControlName1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControlName1.Location = new System.Drawing.Point(0, 226);
            this.userControlName1.Name = "userControlName1";
            this.userControlName1.Size = new System.Drawing.Size(284, 35);
            this.userControlName1.TabIndex = 0;
            // 
            // userControlCourse1
            // 
            this.userControlCourse1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlCourse1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userControlCourse1.Location = new System.Drawing.Point(0, 0);
            this.userControlCourse1.Name = "userControlCourse1";
            this.userControlCourse1.Size = new System.Drawing.Size(284, 93);
            this.userControlCourse1.TabIndex = 1;
            // 
            // PanelMid
            // 
            this.PanelMid.AllowDrop = true;
            this.PanelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMid.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelMid.Location = new System.Drawing.Point(0, 93);
            this.PanelMid.Name = "PanelMid";
            this.PanelMid.Size = new System.Drawing.Size(284, 133);
            this.PanelMid.TabIndex = 2;
            // 
            // FormDialogBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PanelMid);
            this.Controls.Add(this.userControlCourse1);
            this.Controls.Add(this.userControlName1);
            this.Name = "FormDialogBase";
            this.Text = "FormDialogBase";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlName userControlName1;
        private UserControlCourse userControlCourse1;
        private System.Windows.Forms.Panel PanelMid;
    }
}