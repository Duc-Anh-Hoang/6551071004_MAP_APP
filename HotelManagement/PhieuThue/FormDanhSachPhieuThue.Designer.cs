namespace HotelManagement.PhieuThue
{
    partial class FormDanhSachPhieuThue
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
            dtgDanhSachPhieuThue = new DataGridView();
            btnDatPhong = new Button();
            btnXuatExcel = new Button();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhieuThue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachPhieuThue
            // 
            dtgDanhSachPhieuThue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachPhieuThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachPhieuThue.Location = new Point(12, 60);
            dtgDanhSachPhieuThue.Margin = new Padding(3, 4, 3, 4);
            dtgDanhSachPhieuThue.Name = "dtgDanhSachPhieuThue";
            dtgDanhSachPhieuThue.RowHeadersWidth = 51;
            dtgDanhSachPhieuThue.RowTemplate.Height = 32;
            dtgDanhSachPhieuThue.Size = new Size(956, 560);
            dtgDanhSachPhieuThue.TabIndex = 9;
            dtgDanhSachPhieuThue.CellContentClick += dtgDanhSachPhieuThue_CellContentClick;
            // 
            // btnDatPhong
            // 
            btnDatPhong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDatPhong.BackColor = Color.MediumSpringGreen;
            btnDatPhong.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatPhong.Location = new Point(818, 10);
            btnDatPhong.Margin = new Padding(3, 4, 3, 4);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(150, 42);
            btnDatPhong.TabIndex = 8;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.Location = new Point(650, 10);
            btnXuatExcel.Margin = new Padding(3, 4, 3, 4);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(150, 42);
            btnXuatExcel.TabIndex = 7;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(60, 15);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm theo mã, khách hàng...";
            txtTimKiem.Size = new Size(260, 30);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormDanhSachPhieuThue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 630);
            Controls.Add(dtgDanhSachPhieuThue);
            Controls.Add(btnDatPhong);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDanhSachPhieuThue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách phiếu thuê";
            Load += FormDanhSachPhieuThue_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhieuThue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDanhSachPhieuThue;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
