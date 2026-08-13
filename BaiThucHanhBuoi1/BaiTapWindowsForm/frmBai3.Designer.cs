namespace BaiTapWindowsForm
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
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblSoN = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTongAB = new System.Windows.Forms.RadioButton();
            this.rdTinhDay1_N = new System.Windows.Forms.RadioButton();
            this.btnKQ = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lblXuatKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(60, 51);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(45, 16);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số a =";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(60, 79);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(45, 16);
            this.lblSoB.TabIndex = 1;
            this.lblSoB.Text = "Số b =";
            // 
            // lblSoN
            // 
            this.lblSoN.AutoSize = true;
            this.lblSoN.Location = new System.Drawing.Point(62, 104);
            this.lblSoN.Name = "lblSoN";
            this.lblSoN.Size = new System.Drawing.Size(44, 16);
            this.lblSoN.TabIndex = 1;
            this.lblSoN.Text = "Số n =";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(136, 51);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(100, 22);
            this.txtSoA.TabIndex = 2;
            this.txtSoA.Text = "0";
            this.txtSoA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(136, 79);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(100, 22);
            this.txtSoB.TabIndex = 2;
            this.txtSoB.Text = "0";
            this.txtSoB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(136, 104);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(100, 22);
            this.txtSoN.TabIndex = 2;
            this.txtSoN.Text = "0";
            this.txtSoN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhDay1_N);
            this.groupBox1.Controls.Add(this.rdTongAB);
            this.groupBox1.Location = new System.Drawing.Point(63, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán:";
            // 
            // rdTongAB
            // 
            this.rdTongAB.AutoSize = true;
            this.rdTongAB.Checked = true;
            this.rdTongAB.Location = new System.Drawing.Point(19, 36);
            this.rdTongAB.Name = "rdTongAB";
            this.rdTongAB.Size = new System.Drawing.Size(108, 20);
            this.rdTongAB.TabIndex = 0;
            this.rdTongAB.TabStop = true;
            this.rdTongAB.Text = "Tính tổng a, b";
            this.rdTongAB.UseVisualStyleBackColor = true;
            this.rdTongAB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdTinhDay1_N
            // 
            this.rdTinhDay1_N.AutoSize = true;
            this.rdTinhDay1_N.Location = new System.Drawing.Point(19, 62);
            this.rdTinhDay1_N.Name = "rdTinhDay1_N";
            this.rdTinhDay1_N.Size = new System.Drawing.Size(142, 20);
            this.rdTinhDay1_N.TabIndex = 1;
            this.rdTinhDay1_N.Text = "Tính tổng từ 1 đến n";
            this.rdTinhDay1_N.UseVisualStyleBackColor = true;
            // 
            // btnKQ
            // 
            this.btnKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKQ.Location = new System.Drawing.Point(94, 264);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(130, 37);
            this.btnKQ.TabIndex = 4;
            this.btnKQ.Text = "Xem kết quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(62, 304);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(111, 25);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "Kết quả là: ";
            // 
            // lblXuatKQ
            // 
            this.lblXuatKQ.AutoSize = true;
            this.lblXuatKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXuatKQ.Location = new System.Drawing.Point(179, 311);
            this.lblXuatKQ.Name = "lblXuatKQ";
            this.lblXuatKQ.Size = new System.Drawing.Size(13, 20);
            this.lblXuatKQ.TabIndex = 6;
            this.lblXuatKQ.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblXuatKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblSoN);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblSoN;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhDay1_N;
        private System.Windows.Forms.RadioButton rdTongAB;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label lblXuatKQ;
    }
}