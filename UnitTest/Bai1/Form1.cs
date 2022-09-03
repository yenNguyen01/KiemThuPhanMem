using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x, kq;
            int n;
            x = double.Parse(txtX.Text);
            n = Int32.Parse(txtN.Text);
            kq = DeQuy.Power(x, n);
            txtKQ.Text = kq.ToString();

        }
    }
}
