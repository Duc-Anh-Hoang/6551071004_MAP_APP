namespace HotelManagement.PhieuThue
{
    partial class FormChiTietPhieuThue
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
            lbSoPhieu = new Label();
            lbHoTenKH = new Label();
            lbThoiGianLP = new Label();
            lbHoTenNV = new Label();
            dtgDanhSachCTPT = new DataGridView();
            btnThoat = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachCTPT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbSoPhieu
            // 
            lbSoPhieu.Anchor = AnchorStyles.Top;
            lbSoPhieu.AutoSize = true;
            lbSoPhieu.BackColor = Color.Transparent;
            lbSoPhieu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoPhieu.Location = new Point(270, 15);
            lbSoPhieu.Margin = new Padding(4, 0, 4, 0);
            lbSoPhieu.Name = "lbSoPhieu";
            lbSoPhieu.Size = new Size(390, 41);
            lbSoPhieu.TabIndex = 6;
            lbSoPhieu.Text = "Chi tiết phiếu thuê {số phiếu}";
            lbSoPhieu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbHoTenKH
            // 
            lbHoTenKH.AutoSize = true;
            lbHoTenKH.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHoTenKH.ForeColor = Color.FromArgb(0, 0, 192);
            lbHoTenKH.Location = new Point(65, 80);
            lbHoTenKH.Name = "lbHoTenKH";
            lbHoTenKH.Size = new Size(169, 24);
            lbHoTenKH.TabIndex = 8;
            lbHoTenKH.Text = "Họ tên khách hàng";
            // 
            // lbThoiGianLP
            // 
            lbThoiGianLP.Anchor = AnchorStyles.Top;
            lbThoiGianLP.AutoSize = true;
            lbThoiGianLP.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbThoiGianLP.ForeColor = Color.FromArgb(0, 0, 192);
            lbThoiGianLP.Location = new Point(410, 80);
            lbThoiGianLP.Name = "lbThoiGianLP";
            lbThoiGianLP.Size = new Size(171, 24);
            lbThoiGianLP.TabIndex = 10;
            lbThoiGianLP.Text = "Thời gian lập phiếu";
            // 
            // lbHoTenNV
            // 
            lbHoTenNV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbHoTenNV.AutoSize = true;
            lbHoTenNV.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHoTenNV.ForeColor = Color.FromArgb(0, 0, 192);
            lbHoTenNV.Location = new Point(745, 80);
            lbHoTenNV.Name = "lbHoTenNV";
            lbHoTenNV.Size = new Size(155, 24);
            lbHoTenNV.TabIndex = 12;
            lbHoTenNV.Text = "Họ tên nhân viên";
            // 
            // dtgDanhSachCTPT
            // 
            dtgDanhSachCTPT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachCTPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachCTPT.Location = new Point(20, 130);
            dtgDanhSachCTPT.Margin = new Padding(3, 4, 3, 4);
            dtgDanhSachCTPT.Name = "dtgDanhSachCTPT";
            dtgDanhSachCTPT.RowHeadersWidth = 51;
            dtgDanhSachCTPT.RowTemplate.Height = 36;
            dtgDanhSachCTPT.Size = new Size(920, 360);
            dtgDanhSachCTPT.TabIndex = 13;
            dtgDanhSachCTPT.CellClick += dtgDanhSachCTPT_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom;
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(415, 510);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(130, 48);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "OK";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.NhanVien1;
            pictureBox3.Location = new Point(700, 70);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.CalendarPick;
            pictureBox2.Location = new Point(365, 70);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Name;
            pictureBox1.Location = new Point(20, 70);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormChiTietPhieuThue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 570);
            Controls.Add(btnThoat);
            Controls.Add(dtgDanhSachCTPT);
            Controls.Add(lbHoTenNV);
            Controls.Add(pictureBox3);
            Controls.Add(lbThoiGianLP);
            Controls.Add(pictureBox2);
            Controls.Add(lbHoTenKH);
            Controls.Add(pictureBox1);
            Controls.Add(lbSoPhieu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChiTietPhieuThue";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết phiếu thuê";
            Load += FormChiTietPhieuThue_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachCTPT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbSoPhieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHoTenKH;
        private System.Windows.Forms.Label lbThoiGianLP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbHoTenNV;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dtgDanhSachCTPT;
        private System.Windows.Forms.Button btnThoat;
    }
}
