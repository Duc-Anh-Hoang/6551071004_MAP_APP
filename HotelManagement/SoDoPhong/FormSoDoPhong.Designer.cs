namespace HotelManagement.SoDoPhong
{
    partial class FormSoDoPhong
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel4 = new Panel();
            rdbTatCaPhong = new RadioButton();
            rdbPhongChuaDon = new RadioButton();
            rdbPhongDaDonDep = new RadioButton();
            label2 = new Label();
            panel3 = new Panel();
            rdbTatCaLoaiPhong = new RadioButton();
            rdbPhongVipDoi = new RadioButton();
            rdbPhongVipDon = new RadioButton();
            rdbPhongThuongDoi = new RadioButton();
            rdbPhongThuongDon = new RadioButton();
            label1 = new Label();
            panel2 = new Panel();
            rdbTatCaTrangThaiPhong = new RadioButton();
            rdbPhongDangSuaChua = new RadioButton();
            rdbPhongDangThue = new RadioButton();
            rdbPhongDaDat = new RadioButton();
            rdbPhongTrong = new RadioButton();
            LabelTrangThaiPhong = new Label();
            panel5 = new Panel();
            btnDatPhong = new Button();
            pictureBox1 = new PictureBox();
            txtSearchMaPhong = new TextBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dtNgayChon = new DateTimePicker();
            toolTip1 = new ToolTip(components);
            dataGridViewPhong = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.GreenYellow;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 640);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(rdbTatCaPhong);
            panel4.Controls.Add(rdbPhongChuaDon);
            panel4.Controls.Add(rdbPhongDaDonDep);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(4, 320);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 115);
            panel4.TabIndex = 8;
            // 
            // rdbTatCaPhong
            // 
            rdbTatCaPhong.AutoSize = true;
            rdbTatCaPhong.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbTatCaPhong.Location = new Point(10, 80);
            rdbTatCaPhong.Name = "rdbTatCaPhong";
            rdbTatCaPhong.Size = new Size(62, 20);
            rdbTatCaPhong.TabIndex = 4;
            rdbTatCaPhong.TabStop = true;
            rdbTatCaPhong.Text = "Tất cả";
            rdbTatCaPhong.UseVisualStyleBackColor = true;
            rdbTatCaPhong.CheckedChanged += rdbTatCaPhong_CheckedChanged;
            // 
            // rdbPhongChuaDon
            // 
            rdbPhongChuaDon.AutoSize = true;
            rdbPhongChuaDon.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongChuaDon.Location = new Point(10, 56);
            rdbPhongChuaDon.Name = "rdbPhongChuaDon";
            rdbPhongChuaDon.Size = new Size(106, 20);
            rdbPhongChuaDon.TabIndex = 3;
            rdbPhongChuaDon.TabStop = true;
            rdbPhongChuaDon.Text = "Chưa dọn dẹp";
            rdbPhongChuaDon.UseVisualStyleBackColor = true;
            rdbPhongChuaDon.CheckedChanged += rdbPhongChuaDon_CheckedChanged;
            // 
            // rdbPhongDaDonDep
            // 
            rdbPhongDaDonDep.AutoSize = true;
            rdbPhongDaDonDep.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongDaDonDep.Location = new Point(10, 32);
            rdbPhongDaDonDep.Name = "rdbPhongDaDonDep";
            rdbPhongDaDonDep.Size = new Size(93, 20);
            rdbPhongDaDonDep.TabIndex = 2;
            rdbPhongDaDonDep.TabStop = true;
            rdbPhongDaDonDep.Text = "Đã dọn dẹp";
            rdbPhongDaDonDep.UseVisualStyleBackColor = true;
            rdbPhongDaDonDep.CheckedChanged += rdbPhongDaDonDep_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Tình trạng dọn dẹp";
            // 
            // panel3
            // 
            panel3.Controls.Add(rdbTatCaLoaiPhong);
            panel3.Controls.Add(rdbPhongVipDoi);
            panel3.Controls.Add(rdbPhongVipDon);
            panel3.Controls.Add(rdbPhongThuongDoi);
            panel3.Controls.Add(rdbPhongThuongDon);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(4, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 155);
            panel3.TabIndex = 7;
            // 
            // rdbTatCaLoaiPhong
            // 
            rdbTatCaLoaiPhong.AutoSize = true;
            rdbTatCaLoaiPhong.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbTatCaLoaiPhong.Location = new Point(10, 128);
            rdbTatCaLoaiPhong.Name = "rdbTatCaLoaiPhong";
            rdbTatCaLoaiPhong.Size = new Size(103, 20);
            rdbTatCaLoaiPhong.TabIndex = 7;
            rdbTatCaLoaiPhong.TabStop = true;
            rdbTatCaLoaiPhong.Text = "Tất cả phòng";
            rdbTatCaLoaiPhong.UseVisualStyleBackColor = true;
            rdbTatCaLoaiPhong.CheckedChanged += rdbTatCaLoaiPhong_CheckedChanged;
            // 
            // rdbPhongVipDoi
            // 
            rdbPhongVipDoi.AutoSize = true;
            rdbPhongVipDoi.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongVipDoi.Location = new Point(10, 104);
            rdbPhongVipDoi.Name = "rdbPhongVipDoi";
            rdbPhongVipDoi.Size = new Size(108, 20);
            rdbPhongVipDoi.TabIndex = 5;
            rdbPhongVipDoi.TabStop = true;
            rdbPhongVipDoi.Text = "Phòng VIP đôi";
            rdbPhongVipDoi.UseVisualStyleBackColor = true;
            rdbPhongVipDoi.CheckedChanged += rdbPhongVipDoi_CheckedChanged;
            // 
            // rdbPhongVipDon
            // 
            rdbPhongVipDon.AutoSize = true;
            rdbPhongVipDon.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongVipDon.Location = new Point(10, 80);
            rdbPhongVipDon.Name = "rdbPhongVipDon";
            rdbPhongVipDon.Size = new Size(111, 20);
            rdbPhongVipDon.TabIndex = 4;
            rdbPhongVipDon.TabStop = true;
            rdbPhongVipDon.Text = "Phòng VIP đơn";
            rdbPhongVipDon.UseVisualStyleBackColor = true;
            rdbPhongVipDon.CheckedChanged += rdbPhongVipDon_CheckedChanged;
            // 
            // rdbPhongThuongDoi
            // 
            rdbPhongThuongDoi.AutoSize = true;
            rdbPhongThuongDoi.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongThuongDoi.Location = new Point(10, 56);
            rdbPhongThuongDoi.Name = "rdbPhongThuongDoi";
            rdbPhongThuongDoi.Size = new Size(130, 20);
            rdbPhongThuongDoi.TabIndex = 3;
            rdbPhongThuongDoi.TabStop = true;
            rdbPhongThuongDoi.Text = "Phòng thường đôi";
            rdbPhongThuongDoi.UseVisualStyleBackColor = true;
            rdbPhongThuongDoi.CheckedChanged += rdbPhongThuongDoi_CheckedChanged;
            // 
            // rdbPhongThuongDon
            // 
            rdbPhongThuongDon.AutoSize = true;
            rdbPhongThuongDon.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongThuongDon.Location = new Point(10, 32);
            rdbPhongThuongDon.Name = "rdbPhongThuongDon";
            rdbPhongThuongDon.Size = new Size(133, 20);
            rdbPhongThuongDon.TabIndex = 2;
            rdbPhongThuongDon.TabStop = true;
            rdbPhongThuongDon.Text = "Phòng thường đơn";
            rdbPhongThuongDon.UseVisualStyleBackColor = true;
            rdbPhongThuongDon.CheckedChanged += rdbPhongThuongDon_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Loại phòng";
            // 
            // panel2
            // 
            panel2.Controls.Add(rdbTatCaTrangThaiPhong);
            panel2.Controls.Add(rdbPhongDangSuaChua);
            panel2.Controls.Add(rdbPhongDangThue);
            panel2.Controls.Add(rdbPhongDaDat);
            panel2.Controls.Add(rdbPhongTrong);
            panel2.Controls.Add(LabelTrangThaiPhong);
            panel2.Location = new Point(4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 155);
            panel2.TabIndex = 1;
            // 
            // rdbTatCaTrangThaiPhong
            // 
            rdbTatCaTrangThaiPhong.AutoSize = true;
            rdbTatCaTrangThaiPhong.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbTatCaTrangThaiPhong.Location = new Point(10, 128);
            rdbTatCaTrangThaiPhong.Name = "rdbTatCaTrangThaiPhong";
            rdbTatCaTrangThaiPhong.Size = new Size(103, 20);
            rdbTatCaTrangThaiPhong.TabIndex = 6;
            rdbTatCaTrangThaiPhong.TabStop = true;
            rdbTatCaTrangThaiPhong.Text = "Tất cả phòng";
            rdbTatCaTrangThaiPhong.UseVisualStyleBackColor = true;
            rdbTatCaTrangThaiPhong.CheckedChanged += rdbTatCaTrangThaiPhong_CheckedChanged;
            // 
            // rdbPhongDangSuaChua
            // 
            rdbPhongDangSuaChua.AutoSize = true;
            rdbPhongDangSuaChua.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongDangSuaChua.Location = new Point(10, 104);
            rdbPhongDangSuaChua.Name = "rdbPhongDangSuaChua";
            rdbPhongDangSuaChua.Size = new Size(153, 20);
            rdbPhongDangSuaChua.TabIndex = 5;
            rdbPhongDangSuaChua.TabStop = true;
            rdbPhongDangSuaChua.Text = "Phòng đang sửa chữa";
            rdbPhongDangSuaChua.UseVisualStyleBackColor = true;
            rdbPhongDangSuaChua.CheckedChanged += rdbPhongDangSuaChua_CheckedChanged;
            // 
            // rdbPhongDangThue
            // 
            rdbPhongDangThue.AutoSize = true;
            rdbPhongDangThue.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongDangThue.Location = new Point(10, 80);
            rdbPhongDangThue.Name = "rdbPhongDangThue";
            rdbPhongDangThue.Size = new Size(125, 20);
            rdbPhongDangThue.TabIndex = 4;
            rdbPhongDangThue.TabStop = true;
            rdbPhongDangThue.Text = "Phòng đang thuê";
            rdbPhongDangThue.UseVisualStyleBackColor = true;
            rdbPhongDangThue.CheckedChanged += rdbPhongDangThue_CheckedChanged;
            // 
            // rdbPhongDaDat
            // 
            rdbPhongDaDat.AutoSize = true;
            rdbPhongDaDat.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongDaDat.Location = new Point(10, 56);
            rdbPhongDaDat.Name = "rdbPhongDaDat";
            rdbPhongDaDat.Size = new Size(103, 20);
            rdbPhongDaDat.TabIndex = 3;
            rdbPhongDaDat.TabStop = true;
            rdbPhongDaDat.Text = "Phòng đã đặt";
            rdbPhongDaDat.UseVisualStyleBackColor = true;
            rdbPhongDaDat.CheckedChanged += rdbPhongDaDat_CheckedChanged;
            // 
            // rdbPhongTrong
            // 
            rdbPhongTrong.AutoSize = true;
            rdbPhongTrong.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPhongTrong.Location = new Point(10, 32);
            rdbPhongTrong.Name = "rdbPhongTrong";
            rdbPhongTrong.Size = new Size(96, 20);
            rdbPhongTrong.TabIndex = 2;
            rdbPhongTrong.TabStop = true;
            rdbPhongTrong.Text = "Phòng trống";
            rdbPhongTrong.UseVisualStyleBackColor = true;
            rdbPhongTrong.CheckedChanged += rdbPhongTrong_CheckedChanged;
            // 
            // LabelTrangThaiPhong
            // 
            LabelTrangThaiPhong.AutoSize = true;
            LabelTrangThaiPhong.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTrangThaiPhong.Location = new Point(6, 6);
            LabelTrangThaiPhong.Name = "LabelTrangThaiPhong";
            LabelTrangThaiPhong.Size = new Size(130, 20);
            LabelTrangThaiPhong.TabIndex = 1;
            LabelTrangThaiPhong.Text = "Trạng thái phòng";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(btnDatPhong);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(txtSearchMaPhong);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dateTimePicker2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(dtNgayChon);
            panel5.Location = new Point(245, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(730, 52);
            panel5.TabIndex = 1;
            // 
            // btnDatPhong
            // 
            btnDatPhong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDatPhong.BackColor = Color.FromArgb(192, 192, 255);
            btnDatPhong.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatPhong.ForeColor = Color.Blue;
            btnDatPhong.Location = new Point(610, 8);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(115, 36);
            btnDatPhong.TabIndex = 3;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = true;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(340, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtSearchMaPhong
            // 
            txtSearchMaPhong.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchMaPhong.Location = new Point(370, 18);
            txtSearchMaPhong.Name = "txtSearchMaPhong";
            txtSearchMaPhong.PlaceholderText = "Mã phòng...";
            txtSearchMaPhong.Size = new Size(120, 22);
            txtSearchMaPhong.TabIndex = 4;
            txtSearchMaPhong.TextChanged += txtSearchMaPhong_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(190, 4);
            label4.Name = "label4";
            label4.Size = new Size(47, 13);
            label4.TabIndex = 3;
            label4.Text = "Chọn giờ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(190, 20);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(130, 20);
            dateTimePicker2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 4);
            label3.Name = "label3";
            label3.Size = new Size(58, 13);
            label3.TabIndex = 1;
            label3.Text = "Chọn ngày";
            // 
            // dtNgayChon
            // 
            dtNgayChon.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtNgayChon.Format = DateTimePickerFormat.Short;
            dtNgayChon.Location = new Point(10, 20);
            dtNgayChon.Name = "dtNgayChon";
            dtNgayChon.Size = new Size(160, 20);
            dtNgayChon.TabIndex = 0;
            dtNgayChon.ValueChanged += dtNgayChon_ValueChanged;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Nhập số phòng";
            // 
            // dataGridViewPhong
            // 
            dataGridViewPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPhong.Location = new Point(245, 58);
            dataGridViewPhong.Name = "dataGridViewPhong";
            dataGridViewPhong.RowHeadersWidth = 30;
            dataGridViewPhong.RowTemplate.Height = 28;
            dataGridViewPhong.Size = new Size(730, 578);
            dataGridViewPhong.TabIndex = 4;
            // 
            // FormSoDoPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(980, 640);
            Controls.Add(dataGridViewPhong);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "FormSoDoPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sơ đồ phòng";
            Load += FormSoDoPhong_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelTrangThaiPhong;
        private System.Windows.Forms.RadioButton rdbPhongDangSuaChua;
        private System.Windows.Forms.RadioButton rdbPhongDangThue;
        private System.Windows.Forms.RadioButton rdbPhongDaDat;
        private System.Windows.Forms.RadioButton rdbPhongTrong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdbTatCaPhong;
        private System.Windows.Forms.RadioButton rdbPhongChuaDon;
        private System.Windows.Forms.RadioButton rdbPhongDaDonDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbPhongVipDoi;
        private System.Windows.Forms.RadioButton rdbPhongVipDon;
        private System.Windows.Forms.RadioButton rdbPhongThuongDoi;
        private System.Windows.Forms.RadioButton rdbPhongThuongDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTatCaTrangThaiPhong;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtNgayChon;
        private System.Windows.Forms.RadioButton rdbTatCaLoaiPhong;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
    }
}
