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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

        }

        private void lblSoThu2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtXemKQ_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void btnXKQ_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoThu1.Text);
            int b = int.Parse(txtSoThu2.Text);
            double kq = 0;
            if (rdCong.Checked)
            {
                TinhToan.Cong(a, b, ref kq);
            }
            else if (rdTru.Checked)
            {
                TinhToan.Tru(a, b, ref kq);
            }
            else if (rdNhan.Checked)
            {
                TinhToan.Nhan(a, b, ref kq);
            }
            else if (rdChia.Checked)
            {
                TinhToan.Chia(a, b, ref kq);
            }
            lblKQ.Text = kq.ToString();
        }
    }
}
