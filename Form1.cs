using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3_cong2so
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            // txtso1
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);

            ketqua = so1 + so2;

            txtKQ.Text = ketqua. ToString();
        }

        private void txtso1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
