using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfControlLibrary1
{
    public partial class BaseForm : Form
    {
        Point downP = Point.Empty;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downP = new Point(e.X, e.Y);
        }

        private void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downP == Point.Empty) return;
            Point newLoc = new Point(this.Left + e.X - downP.X,
                                    this.Right + e.Y - downP.X);
            this.Location = newLoc;
        }

        private void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downP = Point.Empty;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
