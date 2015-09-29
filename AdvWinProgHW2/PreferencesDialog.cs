using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfControlLibrary1;

namespace AdvWinProgHW2
{
    public partial class PreferencesDialog : BaseForm
    {
        public PreferencesDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void textBoxEWidth_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxEWidth != null)
            {
                if (Int32.Parse(textBoxEWidth.Text) < 20 || Int32.Parse(textBoxEWidth.Text) > 500)
                {
                    errorProviderEWidth.SetError(textBoxEWidth, "Put number between 20 and 500");
                    e.Cancel = true;
                }
            }
        }

        private void textBoxRHeight_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxRHeight != null)
            {
                if (Int32.Parse(textBoxRHeight.Text) < 20 || Int32.Parse(textBoxRHeight.Text) > 500)
                {
                    errorProviderRHeight.SetError(textBoxRHeight, "Put number between 20 and 500");
                    e.Cancel = true;
                }
            }

        }

        private void textBoxERatio_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxERatio != null)
            {
                if (Int32.Parse(textBoxERatio.Text) < 20 || Int32.Parse(textBoxERatio.Text) > 500)
                {
                    errorProviderERatio.SetError(textBoxERatio, "Put number between 20 and 500");
                    e.Cancel = true;
                }
            }

        }
    }
}
