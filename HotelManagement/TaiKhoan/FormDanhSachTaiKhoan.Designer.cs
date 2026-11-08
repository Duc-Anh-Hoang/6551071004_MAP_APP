namespace HotelManagement.TaiKhoan
{
    partial class FormDanhSachTaiKhoan
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
            btnThemMoi = new Button();
            dtgDanhSachTaiKhoan = new DataGridView();
            btnXuatExcel = new Button();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTaiKhoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.BackColor = Color.LightPink;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.Location = new Point(818, 10);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(150, 42);
            btnThemMoi.TabIndex = 30;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // dtgDanhSachTaiKhoan
            // 
            dtgDanhSachTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachTaiKhoan.Location = new Point(12, 60);
            dtgDanhSachTaiKhoan.Name = "dtgDanhSachTaiKhoan";
            dtgDanhSachTaiKhoan.RowHeadersWidth = 51;
            dtgDanhSachTaiKhoan.RowTemplate.Height = 32;
            dtgDanhSachTaiKhoan.Size = new Size(956, 560);
            dtgDanhSachTaiKhoan.TabIndex = 29;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.Location = new Point(650, 10);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(150, 42);
            btnXuatExcel.TabIndex = 28;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(60, 15);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm theo tên TK, mã NV, tên NV...";
            txtTimKiem.Size = new Size(260, 30);
            txtTimKiem.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(15, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // FormDanhSachTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 630);
            Controls.Add(btnThemMoi);
            Controls.Add(dtgDanhSachTaiKhoan);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách tài khoản";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTaiKhoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridView dtgDanhSachTaiKhoan;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
