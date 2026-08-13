using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            listBox1.Items.Add(txtTuMoi.Text);
            list.Add(tu);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
