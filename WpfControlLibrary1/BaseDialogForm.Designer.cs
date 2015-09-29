namespace WpfControlLibrary1
{
    partial class BaseDialogForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlCourse1 = new WpfControlLibrary1.UserControlCourse();
            this.userControlName1 = new WpfControlLibrary1.UserControlName();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 251);
            this.panel1.TabIndex = 2;
            // 
            // userControlCourse1
            // 
            this.userControlCourse1.BackColor = System.Drawing.Color.Transparent;
            this.userControlCourse1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControlCourse1.Location = new System.Drawing.Point(0, 0);
            this.userControlCourse1.Name = "userControlCourse1";
            this.userControlCourse1.Size = new System.Drawing.Size(404, 58);
            this.userControlCourse1.TabIndex = 1;
            // 
            // userControlName1
            // 
            this.userControlName1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControlName1.Location = new System.Drawing.Point(0, 309);
            this.userControlName1.Name = "userControlName1";
            this.userControlName1.Size = new System.Drawing.Size(404, 61);
            this.userControlName1.TabIndex = 0;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlCourse1);
            this.Controls.Add(this.userControlName1);
            this.Name = "BaseDialogForm";
            this.Text = "BaseDialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlName userControlName1;
        private UserControlCourse userControlCourse1;
        protected System.Windows.Forms.Panel panel1;
    }
}