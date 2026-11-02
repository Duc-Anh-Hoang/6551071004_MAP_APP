namespace HotelManagement.ChiTietTienNghi
{
    partial class FormDanhSachChiTietTienNghi
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
            dtgDanhSachTienNghiTheoLoaiPhong = new DataGridView();
            label1 = new Label();
            lblTenLoaiPhong = new Label();
            btnThoat = new Button();
            btnCapNhat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTienNghiTheoLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachTienNghiTheoLoaiPhong
            // 
            dtgDanhSachTienNghiTheoLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachTienNghiTheoLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachTienNghiTheoLoaiPhong.Location = new Point(12, 100);
            dtgDanhSachTienNghiTheoLoaiPhong.Margin = new Padding(3, 4, 3, 4);
            dtgDanhSachTienNghiTheoLoaiPhong.Name = "dtgDanhSachTienNghiTheoLoaiPhong";
            dtgDanhSachTienNghiTheoLoaiPhong.RowHeadersWidth = 30;
            dtgDanhSachTienNghiTheoLoaiPhong.RowTemplate.Height = 32;
            dtgDanhSachTienNghiTheoLoaiPhong.Size = new Size(656, 340);
            dtgDanhSachTienNghiTheoLoaiPhong.TabIndex = 0;
            dtgDanhSachTienNghiTheoLoaiPhong.CellClick += dtgDanhSachTienNghiTheoLoaiPhong_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(140, 20);
            label1.Name = "label1";
            label1.Size = new Size(420, 29);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH TIỆN NGHI HIỆN CÓ";
            // 
            // lblTenLoaiPhong
            // 
            lblTenLoaiPhong.AutoSize = true;
            lblTenLoaiPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenLoaiPhong.ForeColor = Color.Blue;
            lblTenLoaiPhong.Location = new Point(230, 60);
            lblTenLoaiPhong.Name = "lblTenLoaiPhong";
            lblTenLoaiPhong.Size = new Size(157, 25);
            lblTenLoaiPhong.TabIndex = 2;
            lblTenLoaiPhong.Text = "Tên loại phòng";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom;
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(360, 460);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 42);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Bottom;
            btnCapNhat.BackColor = Color.Moccasin;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(200, 460);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(120, 42);
            btnCapNhat.TabIndex = 16;
            btnCapNhat.Text = "Thêm mới";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // FormDanhSachChiTietTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 520);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(lblTenLoaiPhong);
            Controls.Add(label1);
            Controls.Add(dtgDanhSachTienNghiTheoLoaiPhong);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDanhSachChiTietTienNghi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý các tiện nghi theo loại phòng";
            Load += FormDanhSachChiTietTienNghi_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTienNghiTheoLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDanhSachTienNghiTheoLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenLoaiPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
    }
}
