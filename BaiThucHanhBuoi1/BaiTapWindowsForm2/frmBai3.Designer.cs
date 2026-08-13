namespace BaiTapWindowsForm2
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
            this.lblHo = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblXuatHT = new System.Windows.Forms.Label();
            this.btnXuatKQ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGT = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lblKQGT = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(234, 24);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(61, 16);
            this.lblHo.TabIndex = 0;
            this.lblHo.Text = "Nhập họ:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(234, 67);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(64, 16);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Nhập tên:";
            this.lblTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(328, 61);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 22);
            this.txtTen.TabIndex = 2;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(328, 18);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 22);
            this.txtHo.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(233, 146);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(91, 20);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và Tên:";
            this.lblHoTen.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // lblXuatHT
            // 
            this.lblXuatHT.AutoSize = true;
            this.lblXuatHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXuatHT.Location = new System.Drawing.Point(342, 146);
            this.lblXuatHT.Name = "lblXuatHT";
            this.lblXuatHT.Size = new System.Drawing.Size(13, 20);
            this.lblXuatHT.TabIndex = 1;
            this.lblXuatHT.Text = ".";
            this.lblXuatHT.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // btnXuatKQ
            // 
            this.btnXuatKQ.Location = new System.Drawing.Point(12, 118);
            this.btnXuatKQ.Name = "btnXuatKQ";
            this.btnXuatKQ.Size = new System.Drawing.Size(118, 23);
            this.btnXuatKQ.TabIndex = 3;
            this.btnXuatKQ.Text = "Xuất kết quả";
            this.btnXuatKQ.UseVisualStyleBackColor = true;
            this.btnXuatKQ.Click += new System.EventHandler(this.btnXuatKQ_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGT);
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn :";
            // 
            // rdGT
            // 
            this.rdGT.AutoSize = true;
            this.rdGT.Location = new System.Drawing.Point(6, 59);
            this.rdGT.Name = "rdGT";
            this.rdGT.Size = new System.Drawing.Size(80, 20);
            this.rdGT.TabIndex = 1;
            this.rdGT.Text = "Giai thừa";
            this.rdGT.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Checked = true;
            this.rdHoTen.Location = new System.Drawing.Point(6, 33);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(85, 20);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.TabStop = true;
            this.rdHoTen.Text = "Họ và tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(234, 211);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(53, 16);
            this.lblGT.TabIndex = 0;
            this.lblGT.Text = "Nhập n:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(233, 252);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(71, 20);
            this.lblKQ.TabIndex = 1;
            this.lblKQ.Text = "Kết quả:";
            this.lblKQ.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // lblKQGT
            // 
            this.lblKQGT.AutoSize = true;
            this.lblKQGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQGT.Location = new System.Drawing.Point(342, 252);
            this.lblKQGT.Name = "lblKQGT";
            this.lblKQGT.Size = new System.Drawing.Size(13, 20);
            this.lblKQGT.TabIndex = 1;
            this.lblKQGT.Text = ".";
            this.lblKQGT.Click += new System.EventHandler(this.lblTen_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(328, 205);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 2;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXuatKQ);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblKQGT);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblXuatHT);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHo);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblXuatHT;
        private System.Windows.Forms.Button btnXuatKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdGT;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label lblKQGT;
        private System.Windows.Forms.TextBox txtN;
    }
}