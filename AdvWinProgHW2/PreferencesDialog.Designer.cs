namespace AdvWinProgHW2
{
    partial class PreferencesDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesDialog));
            this.textBoxEWidth = new System.Windows.Forms.TextBox();
            this.textBoxERatio = new System.Windows.Forms.TextBox();
            this.textBoxRHeight = new System.Windows.Forms.TextBox();
            this.textBoxRRatio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.errorProviderEWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRHeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderERatio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRRatio = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderERatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEWidth
            // 
            this.textBoxEWidth.Location = new System.Drawing.Point(173, 57);
            this.textBoxEWidth.Name = "textBoxEWidth";
            this.textBoxEWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxEWidth.TabIndex = 2;
            this.textBoxEWidth.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEWidth_Validating);
            // 
            // textBoxERatio
            // 
            this.textBoxERatio.Location = new System.Drawing.Point(173, 134);
            this.textBoxERatio.Name = "textBoxERatio";
            this.textBoxERatio.Size = new System.Drawing.Size(100, 20);
            this.textBoxERatio.TabIndex = 3;
            this.textBoxERatio.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxERatio_Validating);
            // 
            // textBoxRHeight
            // 
            this.textBoxRHeight.Location = new System.Drawing.Point(173, 93);
            this.textBoxRHeight.Name = "textBoxRHeight";
            this.textBoxRHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxRHeight.TabIndex = 4;
            this.textBoxRHeight.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxRHeight_Validating);
            // 
            // textBoxRRatio
            // 
            this.textBoxRRatio.Location = new System.Drawing.Point(173, 172);
            this.textBoxRRatio.Name = "textBoxRRatio";
            this.textBoxRRatio.Size = new System.Drawing.Size(100, 20);
            this.textBoxRRatio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Elipse Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rectangular Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Elipse Ratio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rectangular Ratio";
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(36, 266);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(227, 266);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(127, 266);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 12;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // errorProviderEWidth
            // 
            this.errorProviderEWidth.ContainerControl = this;
            // 
            // errorProviderRHeight
            // 
            this.errorProviderRHeight.ContainerControl = this;
            // 
            // errorProviderERatio
            // 
            this.errorProviderERatio.ContainerControl = this;
            // 
            // errorProviderRRatio
            // 
            this.errorProviderRRatio.ContainerControl = this;
            // 
            // PreferencesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(328, 301);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRRatio);
            this.Controls.Add(this.textBoxRHeight);
            this.Controls.Add(this.textBoxERatio);
            this.Controls.Add(this.textBoxEWidth);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesDialog";
            this.Text = "PreferencesDialog";
            this.Controls.SetChildIndex(this.textBoxEWidth, 0);
            this.Controls.SetChildIndex(this.textBoxERatio, 0);
            this.Controls.SetChildIndex(this.textBoxRHeight, 0);
            this.Controls.SetChildIndex(this.textBoxRRatio, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.buttonOk, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonApply, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderERatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEWidth;
        private System.Windows.Forms.TextBox textBoxERatio;
        private System.Windows.Forms.TextBox textBoxRHeight;
        private System.Windows.Forms.TextBox textBoxRRatio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ErrorProvider errorProviderEWidth;
        private System.Windows.Forms.ErrorProvider errorProviderRHeight;
        private System.Windows.Forms.ErrorProvider errorProviderERatio;
        private System.Windows.Forms.ErrorProvider errorProviderRRatio;
    }
}