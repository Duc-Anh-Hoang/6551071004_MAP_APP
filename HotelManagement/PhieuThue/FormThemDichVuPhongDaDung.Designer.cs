namespace HotelManagement.PhieuThue
{
    partial class FormThemDichVuPhongDaDung
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnThoat = new Button();
            btnThemDV = new Button();
            lbSoCTPhieu = new Label();
            lbSoPhong = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            LabelThemTienNghi = new Label();
            label1 = new Label();
            txtMaDV = new TextBox();
            label2 = new Label();
            cbTenDV = new ComboBox();
            label3 = new Label();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            label4 = new Label();
            lbThanhTien = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(410, 440);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 48);
            btnThoat.TabIndex = 34;
            btnThoat.Text = "OK";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThemDV
            // 
            btnThemDV.BackColor = Color.Orchid;
            btnThemDV.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemDV.Location = new Point(220, 440);
            btnThemDV.Margin = new Padding(3, 4, 3, 4);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(160, 48);
            btnThemDV.TabIndex = 33;
            btnThemDV.Text = "Thêm dịch vụ";
            btnThemDV.UseVisualStyleBackColor = false;
            btnThemDV.Click += btnThemDV_Click;
            // 
            // lbSoCTPhieu
            // 
            lbSoCTPhieu.AutoSize = true;
            lbSoCTPhieu.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoCTPhieu.ForeColor = Color.Green;
            lbSoCTPhieu.Location = new Point(430, 80);
            lbSoCTPhieu.Name = "lbSoCTPhieu";
            lbSoCTPhieu.Size = new Size(100, 26);
            lbSoCTPhieu.TabIndex = 31;
            lbSoCTPhieu.Text = "label2";
            // 
            // lbSoPhong
            // 
            lbSoPhong.AutoSize = true;
            lbSoPhong.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoPhong.ForeColor = Color.FromArgb(192, 64, 0);
            lbSoPhong.Location = new Point(80, 80);
            lbSoPhong.Name = "lbSoPhong";
            lbSoPhong.Size = new Size(100, 26);
            lbSoPhong.TabIndex = 30;
            lbSoPhong.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.PhieuThue;
            pictureBox2.Location = new Point(375, 68);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Phong;
            pictureBox1.Location = new Point(25, 68);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // LabelThemTienNghi
            // 
            LabelThemTienNghi.AutoSize = true;
            LabelThemTienNghi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelThemTienNghi.ForeColor = Color.FromArgb(192, 0, 0);
            LabelThemTienNghi.Location = new Point(220, 15);
            LabelThemTienNghi.Margin = new Padding(4, 0, 4, 0);
            LabelThemTienNghi.Name = "LabelThemTienNghi";
            LabelThemTienNghi.Size = new Size(310, 41);
            LabelThemTienNghi.TabIndex = 27;
            LabelThemTienNghi.Text = "Thêm dịch vụ phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 35;
            label1.Text = "Mã dịch vụ";
            // 
            // txtMaDV
            // 
            txtMaDV.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaDV.Location = new Point(135, 22);
            txtMaDV.Margin = new Padding(3, 4, 3, 4);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.ReadOnly = true;
            txtMaDV.Size = new Size(180, 29);
            txtMaDV.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(340, 25);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 37;
            label2.Text = "Tên dịch vụ";
            // 
            // cbTenDV
            // 
            cbTenDV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenDV.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTenDV.FormattingEnabled = true;
            cbTenDV.Location = new Point(460, 22);
            cbTenDV.Margin = new Padding(3, 4, 3, 4);
            cbTenDV.Name = "cbTenDV";
            cbTenDV.Size = new Size(230, 32);
            cbTenDV.TabIndex = 38;
            cbTenDV.SelectedIndexChanged += cbTenDV_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 95);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 39;
            label3.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoLuong.Location = new Point(135, 92);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.MaxLength = 6;
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(180, 29);
            txtSoLuong.TabIndex = 40;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDonGia.Location = new Point(460, 92);
            txtDonGia.Margin = new Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(230, 29);
            txtDonGia.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(340, 95);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 41;
            label4.Text = "Đơn giá";
            // 
            // lbThanhTien
            // 
            lbThanhTien.AutoSize = true;
            lbThanhTien.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThanhTien.ForeColor = Color.FromArgb(192, 0, 0);
            lbThanhTien.Location = new Point(200, 160);
            lbThanhTien.Margin = new Padding(4, 0, 4, 0);
            lbThanhTien.Name = "lbThanhTien";
            lbThanhTien.Size = new Size(183, 37);
            lbThanhTien.TabIndex = 43;
            lbThanhTien.Text = "Thành tiền: 0";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaDV);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbTenDV);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(lbThanhTien);
            panel1.Location = new Point(25, 140);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 220);
            panel1.TabIndex = 44;
            // 
            // FormThemDichVuPhongDaDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 520);
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnThemDV);
            Controls.Add(lbSoCTPhieu);
            Controls.Add(lbSoPhong);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(LabelThemTienNghi);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormThemDichVuPhongDaDung";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm dịch vụ đã dùng theo phòng";
            Load += FormThemDichVuPhongDaDung_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label lbSoCTPhieu;
        private System.Windows.Forms.Label lbSoPhong;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelThemTienNghi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Panel panel1;
    }
}
