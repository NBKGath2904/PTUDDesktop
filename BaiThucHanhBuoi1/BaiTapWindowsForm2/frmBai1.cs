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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void lblTB_Click(object sender, EventArgs e)
        {

        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            tb.MaThietBi = "TB01";
            tb.TenThietBi = "IPhone 17 ProMax màu cam 1TB";
            tb.NuocSanXuat = "Trung Quốc";
            tb.DonGia = 30000000;
            tb.SoLuong = 2;

            lblThongBao.Text = tb.HienThi();
        }
    }
}
