using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_1_1204075
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BVisual_Click(object sender, EventArgs e)
        {

        }

        private void BVisual_MouseMove(object sender, MouseEventArgs e)
        {
            BVisual.Top -= e.Y;
            BVisual.Left -= e.X;
            if (BVisual.Top < -16 || BVisual.Top > 160)
                BVisual.Top = 73;
            if (BVisual.Left < -64 || BVisual.Left > 384)
                BVisual.Left = 160;
        }

        private void Bc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct!");
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
