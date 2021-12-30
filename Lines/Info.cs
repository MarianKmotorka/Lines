using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lines
{
    public partial class InfoForm : Form
    {
        bool b = true;

        public InfoForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            b = !b;
            if (b)
                label1.ForeColor = Color.FromArgb(255,255,255);
            else
                label1.ForeColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }
    }
}
