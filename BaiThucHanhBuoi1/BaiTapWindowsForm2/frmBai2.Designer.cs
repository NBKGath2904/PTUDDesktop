namespace BaiTapWindowsForm2
{
    partial class frmBai2
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
            this.lblSoThu1 = new System.Windows.Forms.Label();
            this.lblSoThu2 = new System.Windows.Forms.Label();
            this.lblKQL = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtSoThu1 = new System.Windows.Forms.TextBox();
            this.txtSoThu2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.btnXKQ = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoThu1
            // 
            this.lblSoThu1.AutoSize = true;
            this.lblSoThu1.Location = new System.Drawing.Point(55, 28);
            this.lblSoThu1.Name = "lblSoThu1";
            this.lblSoThu1.Size = new System.Drawing.Size(75, 16);
            this.lblSoThu1.TabIndex = 0;
            this.lblSoThu1.Text = "Số thứ nhất:";
            // 
            // lblSoThu2
            // 
            this.lblSoThu2.AutoSize = true;
            this.lblSoThu2.Location = new System.Drawing.Point(55, 55);
            this.lblSoThu2.Name = "lblSoThu2";
            this.lblSoThu2.Size = new System.Drawing.Size(68, 16);
            this.lblSoThu2.TabIndex = 1;
            this.lblSoThu2.Text = "Số thứ hai:";
            this.lblSoThu2.Click += new System.EventHandler(this.lblSoThu2_Click);
            // 
            // lblKQL
            // 
            this.lblKQL.AutoSize = true;
            this.lblKQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQL.Location = new System.Drawing.Point(133, 287);
            this.lblKQL.Name = "lblKQL";
            this.lblKQL.Size = new System.Drawing.Size(106, 25);
            this.lblKQL.TabIndex = 2;
            this.lblKQL.Text = "Kết quả là:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(245, 287);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(17, 25);
            this.lblKQ.TabIndex = 3;
            this.lblKQ.Text = ".";
            this.lblKQ.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSoThu1
            // 
            this.txtSoThu1.Location = new System.Drawing.Point(136, 22);
            this.txtSoThu1.Name = "txtSoThu1";
            this.txtSoThu1.Size = new System.Drawing.Size(125, 22);
            this.txtSoThu1.TabIndex = 0;
            // 
            // txtSoThu2
            // 
            this.txtSoThu2.Location = new System.Drawing.Point(136, 50);
            this.txtSoThu2.Name = "txtSoThu2";
            this.txtSoThu2.Size = new System.Drawing.Size(125, 22);
            this.txtSoThu2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChia);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Location = new System.Drawing.Point(136, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 153);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Location = new System.Drawing.Point(6, 66);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(48, 20);
            this.rdTru.TabIndex = 1;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            this.rdTru.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Checked = true;
            this.rdCong.Location = new System.Drawing.Point(6, 40);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(60, 20);
            this.rdCong.TabIndex = 0;
            this.rdCong.TabStop = true;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(6, 92);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(60, 20);
            this.rdNhan.TabIndex = 2;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(6, 120);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(55, 20);
            this.rdChia.TabIndex = 3;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            // 
            // btnXKQ
            // 
            this.btnXKQ.Location = new System.Drawing.Point(138, 257);
            this.btnXKQ.Name = "btnXKQ";
            this.btnXKQ.Size = new System.Drawing.Size(113, 27);
            this.btnXKQ.TabIndex = 2;
            this.btnXKQ.Text = "Xem kết quả";
            this.btnXKQ.UseVisualStyleBackColor = true;
            this.btnXKQ.Click += new System.EventHandler(this.btnXKQ_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoThu2);
            this.Controls.Add(this.txtSoThu1);
            this.Controls.Add(this.lblKQL);
            this.Controls.Add(this.lblSoThu2);
            this.Controls.Add(this.lblSoThu1);
            this.Controls.Add(this.lblKQ);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.frmBai2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoThu1;
        private System.Windows.Forms.Label lblSoThu2;
        private System.Windows.Forms.Label lblKQL;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtSoThu1;
        private System.Windows.Forms.TextBox txtSoThu2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.Button btnXKQ;
    }
}