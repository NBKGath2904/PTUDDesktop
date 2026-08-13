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
            this.lblTuMoi.Location = new System.Drawing.Point(16, 48);
            this.lblTuMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuMoi.Name = "lblTuMoi";
            this.lblTuMoi.Size = new System.Drawing.Size(83, 25);
            this.lblTuMoi.TabIndex = 0;
            this.lblTuMoi.Text = "Từ mới: ";
            // 
            // lblNghia
            // 
            this.lblNghia.AutoSize = true;
            this.lblNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNghia.Location = new System.Drawing.Point(16, 91);
            this.lblNghia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNghia.Name = "lblNghia";
            this.lblNghia.Size = new System.Drawing.Size(132, 25);
            this.lblNghia.TabIndex = 1;
            this.lblNghia.Text = "Nghĩa của từ: ";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuMoi.Location = new System.Drawing.Point(169, 48);
            this.txtTuMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(221, 30);
            this.txtTuMoi.TabIndex = 0;
            // 
            // txtNghia
            // 
            this.txtNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNghia.Location = new System.Drawing.Point(169, 94);
            this.txtNghia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(221, 30);
            this.txtNghia.TabIndex = 1;
            // 
            // btnThemTu
            // 
            this.btnThemTu.Location = new System.Drawing.Point(215, 149);
            this.btnThemTu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(119, 28);
            this.btnThemTu.TabIndex = 2;
            this.btnThemTu.Text = "Thêm từ mới";
            this.btnThemTu.UseVisualStyleBackColor = true;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // lblDSTuMoi
            // 
            this.lblDSTuMoi.AutoSize = true;
            this.lblDSTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSTuMoi.Location = new System.Drawing.Point(41, 244);
            this.lblDSTuMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDSTuMoi.Name = "lblDSTuMoi";
            this.lblDSTuMoi.Size = new System.Drawing.Size(163, 25);
            this.lblDSTuMoi.TabIndex = 5;
            this.lblDSTuMoi.Text = "Danh sách từ mới";
            // 
            // lblNghiaCuaTu
            // 
            this.lblNghiaCuaTu.AutoSize = true;
            this.lblNghiaCuaTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNghiaCuaTu.Location = new System.Drawing.Point(524, 244);
            this.lblNghiaCuaTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNghiaCuaTu.Name = "lblNghiaCuaTu";
            this.lblNghiaCuaTu.Size = new System.Drawing.Size(121, 25);
            this.lblNghiaCuaTu.TabIndex = 6;
            this.lblNghiaCuaTu.Text = "Nghĩa của từ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 272);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(460, 228);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtNghiaCuaTu2
            // 
            this.txtNghiaCuaTu2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNghiaCuaTu2.Location = new System.Drawing.Point(529, 272);
            this.txtNghiaCuaTu2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNghiaCuaTu2.Multiline = true;
            this.txtNghiaCuaTu2.Name = "txtNghiaCuaTu2";
            this.txtNghiaCuaTu2.ReadOnly = true;
            this.txtNghiaCuaTu2.Size = new System.Drawing.Size(468, 228);
            this.txtNghiaCuaTu2.TabIndex = 9;
            this.txtNghiaCuaTu2.TextChanged += new System.EventHandler(this.txtNghiaCuaTu2_TextChanged);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtNghiaCuaTu2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblNghiaCuaTu);
            this.Controls.Add(this.lblDSTuMoi);
            this.Controls.Add(this.btnThemTu);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.lblNghia);
            this.Controls.Add(this.lblTuMoi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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