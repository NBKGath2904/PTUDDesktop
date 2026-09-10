using MyForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap2_Bai2
{
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }


        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtEmail.Text = "";
            this.txtmxtSoDT.Text = "";
            this.rdNam.Checked = true;

            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);

            foreach (object ob in this.lbHocPhanDay.Items)
                this.lbDanhSachHP.Items.Add(ob);

            this.lbHocPhanDay.Items.Clear();
        }


        //Lấy thông tin của giảng viên được nhập trên form
        public GiangVien GetGiangVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";

            GiangVien gv = new GiangVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtEmail.Text;
            gv.SoDT = this.txtmxtSoDT.Text;

            string ngoaiNgu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaiNgu += chklbNgoaiNgu.Items[i] + ";";

            gv.NgoaiNgu = ngoaiNgu.Split(';');

            DanhMucHocPhan dshp = new DanhMucHocPhan();
            foreach (object hp in lbHocPhanDay.Items)
                dshp.Them(new HocPhan(hp.ToString()));

            gv.dsHocPhan = dshp;

            return gv;
        }

        private void chklbNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmGiangVien_Load_1(object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn/";
            this.linklbLienHe.Links.Add(0, lienHe.Length, lienHe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void btnThongBao_Click_1(object sender, EventArgs e)
        {
            frmTBGiangVien frm = new frmTBGiangVien();
            frm.SetText(GetGiangVien().ToString());
            frm.ShowDialog();
        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {
            int i = this.lbDanhSachHP.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbHocPhanDay.Items.Add(lbDanhSachHP.SelectedItems[i]);
                this.lbDanhSachHP.Items.Remove(lbDanhSachHP.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int i = this.lbHocPhanDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachHP.Items.Add(lbHocPhanDay.SelectedItems[i]);
                this.lbHocPhanDay.Items.Remove(lbHocPhanDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strLink = e.Link.LinkData.ToString();
            Process.Start(strLink);
        }
    }
}
