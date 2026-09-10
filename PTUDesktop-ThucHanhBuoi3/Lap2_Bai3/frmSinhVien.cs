using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap2_Bai3
{
    public partial class frmSinhVien : Form
    {
        private qlsv qlsv;

        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            if (cn.Length > 0)
                cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvSinhVIen.Items.Add(lvitem);
        }

        private void LoadListView()
        {
            this.lvSinhVIen.Items.Clear();
            foreach (SinhVien sv in qlsv.dsSinhVien)
            {
                ThemSV(sv);
            }
        }

        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.comboBox1.Text;
            sv.Hinh = this.txtHinh.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemChecked(i))
                    cn.Add(checkedListBox1.Items[i].ToString());
            sv.ChuyenNganh = cn;
            return sv;
        }

        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
                cn.Add(t);
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }

        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.comboBox1.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pictureBox1.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;

            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                this.checkedListBox1.SetItemChecked(i, false);

            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                    if (s.CompareTo(this.checkedListBox1.Items[i]) == 0)
                        this.checkedListBox1.SetItemChecked(i, true);
            }
        }
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            kqsua = qlsv.Sua(sv, sv.MaSo, SoSanhTheoMa);
            if (kqsua)
            {
                this.LoadListView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pictureBox1.ImageLocation = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < this.checkedListBox1.Items.Count - 1;
                i++)
                this.checkedListBox1.SetItemChecked(i, false);
        }
        

        private void lvSinhVIen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVIen.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVIen.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void asd(object sender, EventArgs e)
        {

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new qlsv();
            qlsv.DocTuFile("DanhSachSV.txt");
            LoadListView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private int SoSanhTheoMa(object sv1, object sv2)
        {
            SinhVien sv = sv2 as SinhVien;
            return sv.MaSo.CompareTo(sv1);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVIen.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVIen.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            qlsv.Them(GetSinhVien());
            this.LoadListView();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialogHinh = new OpenFileDialog())
            {
                openFileDialogHinh.Filter = "Image File (*.bmp; *.jpg; *.png)| *.bmp; *.jpg; *.png";
                openFileDialogHinh.FilterIndex = 1;
                if ( openFileDialogHinh.ShowDialog() == DialogResult.OK )
                {
                    txtHinh.Text = openFileDialogHinh.FileName;
                    this.pictureBox1.Image = Image.FromFile(txtHinh.Text);
                }
            }
        }
    }
}
