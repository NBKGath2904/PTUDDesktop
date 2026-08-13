using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void frmBai3_Load(object sender, EventArgs e)
        {

        }

        private void lblTen_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatKQ_Click(object sender, EventArgs e)
        {
            int kq = 0;
            long gt = 1;
            if (rdHoTen.Checked)
            {
                lblXuatHT.Text = txtHo.Text + " " + txtTen.Text;
            }
            else
            {
                int n = int.Parse(txtN.Text);
                kq = (int)Ham.GiaiThua(n, gt);
            }
            lblKQGT.Text = kq.ToString();
        }
    }
}
