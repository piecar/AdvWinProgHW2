using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvWinProgHW2
{
    public partial class FormDialogBase : Form
    {
        public FormDialogBase()
        {
            InitializeComponent();
            PanelMid.BackColor = Color.Transparent;
            PanelMid.BackgroundImage = this.BackgroundImage;
        }
    }
}
