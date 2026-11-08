namespace HotelManagement.HoaDon
{
    partial class FormDanhSachHoaDon
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
            dtgDanhSachHoaDon = new DataGridView();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            btnXuatExcel = new Button();
            dtpNgayLap = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachHoaDon
            // 
            dtgDanhSachHoaDon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachHoaDon.Location = new Point(12, 60);
            dtgDanhSachHoaDon.Margin = new Padding(3, 4, 3, 4);
            dtgDanhSachHoaDon.Name = "dtgDanhSachHoaDon";
            dtgDanhSachHoaDon.RowHeadersWidth = 51;
            dtgDanhSachHoaDon.RowTemplate.Height = 32;
            dtgDanhSachHoaDon.Size = new Size(956, 560);
            dtgDanhSachHoaDon.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(60, 15);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm theo mã HĐ, tên KH, CCCD...";
            txtTimKiem.Size = new Size(260, 30);
            txtTimKiem.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.Location = new Point(818, 10);
            btnXuatExcel.Margin = new Padding(3, 4, 3, 4);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(150, 42);
            btnXuatExcel.TabIndex = 28;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(340, 15);
            dtpNgayLap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.ShowCheckBox = true;
            dtpNgayLap.Size = new Size(220, 29);
            dtpNgayLap.TabIndex = 29;
            // 
            // FormDanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 630);
            Controls.Add(dtpNgayLap);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Controls.Add(dtgDanhSachHoaDon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDanhSachHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách hóa đơn";
            Load += FormDanhSachHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDanhSachHoaDon;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
    }
}
