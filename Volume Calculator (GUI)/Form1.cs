using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume_Calculator__GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volume_Calculator__GUI_.SphereCalculator SphereCalc = new Volume_Calculator__GUI_.SphereCalculator();
            SphereCalc.ShowDialog();
        }
    }
}
