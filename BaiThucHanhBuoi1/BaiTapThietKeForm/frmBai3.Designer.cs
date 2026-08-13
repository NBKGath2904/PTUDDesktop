namespace BaiTapThietKeForm
{
    partial class frmBai3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTuMoi = new System.Windows.Forms.Label();
            this.lblNghia = new System.Windows.Forms.Label();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.btnThemTu = new System.Windows.Forms.Button();
            this.lblDSTuMoi = new System.Windows.Forms.Label();
            this.lblNghiaCuaTu = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNghiaCuaTu2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTuMoi
            // 
            this.lblTuMoi.AutoSize = true;
            this.lblTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuMoi.Location = new System.Drawing.Point(12, 39);
            this.lblTuMoi.Name = "lblTuMoi";
            this.lblTuMoi.Size = new System.Drawing.Size(64, 20);
            this.lblTuMoi.TabIndex = 0;
            this.lblTuMoi.Text = "Từ mới: ";
            // 
            // lblNghia
            // 
            this.lblNghia.AutoSize = true;
            this.lblNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNghia.Location = new System.Drawing.Point(12, 74);
            this.lblNghia.Name = "lblNghia";
            this.lblNghia.Size = new System.Drawing.Size(106, 20);
            this.lblNghia.TabIndex = 1;
            this.lblNghia.Text = "Nghĩa của từ: ";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuMoi.Location = new System.Drawing.Point(127, 39);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(167, 26);
            this.txtTuMoi.TabIndex = 2;
            // 
            // txtNghia
            // 
            this.txtNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNghia.Location = new System.Drawing.Point(127, 76);
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(167, 26);
            this.txtNghia.TabIndex = 3;
            // 
            // btnThemTu
            // 
            this.btnThemTu.Location = new System.Drawing.Point(161, 121);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(89, 23);
            this.btnThemTu.TabIndex = 4;
            this.btnThemTu.Text = "Thêm từ mới";
            this.btnThemTu.UseVisualStyleBackColor = true;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // lblDSTuMoi
            // 
            this.lblDSTuMoi.AutoSize = true;
            this.lblDSTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSTuMoi.Location = new System.Drawing.Point(31, 198);
            this.lblDSTuMoi.Name = "lblDSTuMoi";
            this.lblDSTuMoi.Size = new System.Drawing.Size(133, 20);
            this.lblDSTuMoi.TabIndex = 5;
            this.lblDSTuMoi.Text = "Danh sách từ mới";
            // 
            // lblNghiaCuaTu
            // 
            this.lblNghiaCuaTu.AutoSize = true;
            this.lblNghiaCuaTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNghiaCuaTu.Location = new System.Drawing.Point(393, 198);
            this.lblNghiaCuaTu.Name = "lblNghiaCuaTu";
            this.lblNghiaCuaTu.Size = new System.Drawing.Size(98, 20);
            this.lblNghiaCuaTu.TabIndex = 6;
            this.lblNghiaCuaTu.Text = "Nghĩa của từ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 186);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtNghiaCuaTu2
            // 
            this.txtNghiaCuaTu2.Location = new System.Drawing.Point(397, 221);
            this.txtNghiaCuaTu2.Multiline = true;
            this.txtNghiaCuaTu2.Name = "txtNghiaCuaTu2";
            this.txtNghiaCuaTu2.ReadOnly = true;
            this.txtNghiaCuaTu2.Size = new System.Drawing.Size(352, 186);
            this.txtNghiaCuaTu2.TabIndex = 9;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNghiaCuaTu2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblNghiaCuaTu);
            this.Controls.Add(this.lblDSTuMoi);
            this.Controls.Add(this.btnThemTu);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.lblNghia);
            this.Controls.Add(this.lblTuMoi);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuMoi;
        private System.Windows.Forms.Label lblNghia;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghia;
        private System.Windows.Forms.Button btnThemTu;
        private System.Windows.Forms.Label lblDSTuMoi;
        private System.Windows.Forms.Label lblNghiaCuaTu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNghiaCuaTu2;
    }
}