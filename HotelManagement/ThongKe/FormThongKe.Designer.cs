namespace HotelManagement.ThongKe
{
    partial class FormThongKe
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
            pnlHeader = new Panel();
            btnXemThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblTuNgay = new Label();
            pnlCards = new Panel();
            cardSoPhongDat = new Panel();
            lblSoPhongDatVal = new Label();
            lblSoPhongDatTitle = new Label();
            picSoPhongDat = new PictureBox();
            cardDoanhThuDV = new Panel();
            lblDoanhThuDVVal = new Label();
            lblDoanhThuDVTitle = new Label();
            picDoanhThuDV = new PictureBox();
            cardDoanhThuPhong = new Panel();
            lblDoanhThuPhongVal = new Label();
            lblDoanhThuPhongTitle = new Label();
            picDoanhThuPhong = new PictureBox();
            pnlMainContainer = new Panel();
            pnlRight = new Panel();
            pnlChartDatPhong = new Panel();
            lblTitleChartDatPhong = new Label();
            picChartDatPhong = new PictureBox();
            pnlChartDoanhThu = new Panel();
            lblTitleChartDoanhThu = new Label();
            picChartDoanhThu = new PictureBox();
            pnlLeft = new Panel();
            pnlChartDichVu = new Panel();
            lblTitleChartDV = new Label();
            picChartDichVu = new PictureBox();
            pnlTopDV = new Panel();
            lblTopDVVal = new Label();
            lblTopDVTitle = new Label();
            picTopDV = new PictureBox();
            pnlTopLpDat = new Panel();
            lblTopLpDatVal = new Label();
            lblTopLpDatTitle = new Label();
            picTopLpDat = new PictureBox();
            pnlTopLpDoanhThu = new Panel();
            lblTopLpDoanhThuVal = new Label();
            lblTopLpDoanhThuTitle = new Label();
            picTopLpDoanhThu = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlCards.SuspendLayout();
            cardSoPhongDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSoPhongDat).BeginInit();
            cardDoanhThuDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDoanhThuDV).BeginInit();
            cardDoanhThuPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDoanhThuPhong).BeginInit();
            pnlMainContainer.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlChartDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChartDatPhong).BeginInit();
            pnlChartDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChartDoanhThu).BeginInit();
            pnlLeft.SuspendLayout();
            pnlChartDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChartDichVu).BeginInit();
            pnlTopDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTopDV).BeginInit();
            pnlTopLpDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTopLpDat).BeginInit();
            pnlTopLpDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTopLpDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(235, 240, 248);
            pnlHeader.Controls.Add(btnXemThongKe);
            pnlHeader.Controls.Add(dtpDenNgay);
            pnlHeader.Controls.Add(lblDenNgay);
            pnlHeader.Controls.Add(dtpTuNgay);
            pnlHeader.Controls.Add(lblTuNgay);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(980, 48);
            pnlHeader.TabIndex = 0;
            // 
            // btnXemThongKe
            // 
            btnXemThongKe.BackColor = Color.SteelBlue;
            btnXemThongKe.FlatAppearance.BorderSize = 0;
            btnXemThongKe.FlatStyle = FlatStyle.Flat;
            btnXemThongKe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnXemThongKe.ForeColor = Color.White;
            btnXemThongKe.Location = new Point(710, 8);
            btnXemThongKe.Name = "btnXemThongKe";
            btnXemThongKe.Size = new Size(130, 32);
            btnXemThongKe.TabIndex = 4;
            btnXemThongKe.Text = "Xem thống kê";
            btnXemThongKe.UseVisualStyleBackColor = false;
            btnXemThongKe.Click += btnXemThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 10F);
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(480, 10);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(180, 29);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDenNgay.ForeColor = Color.FromArgb(64, 64, 64);
            lblDenNgay.Location = new Point(395, 13);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(84, 23);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 10F);
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(175, 10);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(180, 29);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTuNgay.ForeColor = Color.FromArgb(64, 64, 64);
            lblTuNgay.Location = new Point(95, 13);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(71, 23);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày";
            // 
            // pnlCards
            // 
            pnlCards.Controls.Add(cardSoPhongDat);
            pnlCards.Controls.Add(cardDoanhThuDV);
            pnlCards.Controls.Add(cardDoanhThuPhong);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(0, 48);
            pnlCards.Name = "pnlCards";
            pnlCards.Padding = new Padding(12, 8, 12, 8);
            pnlCards.Size = new Size(980, 78);
            pnlCards.TabIndex = 1;
            // 
            // cardSoPhongDat
            // 
            cardSoPhongDat.BackColor = Color.FromArgb(92, 184, 92);
            cardSoPhongDat.Controls.Add(lblSoPhongDatVal);
            cardSoPhongDat.Controls.Add(lblSoPhongDatTitle);
            cardSoPhongDat.Controls.Add(picSoPhongDat);
            cardSoPhongDat.Location = new Point(648, 8);
            cardSoPhongDat.Name = "cardSoPhongDat";
            cardSoPhongDat.Size = new Size(310, 62);
            cardSoPhongDat.TabIndex = 2;
            // 
            // lblSoPhongDatVal
            // 
            lblSoPhongDatVal.AutoSize = true;
            lblSoPhongDatVal.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblSoPhongDatVal.ForeColor = Color.White;
            lblSoPhongDatVal.Location = new Point(70, 28);
            lblSoPhongDatVal.Name = "lblSoPhongDatVal";
            lblSoPhongDatVal.Size = new Size(27, 31);
            lblSoPhongDatVal.TabIndex = 2;
            lblSoPhongDatVal.Text = "0";
            // 
            // lblSoPhongDatTitle
            // 
            lblSoPhongDatTitle.AutoSize = true;
            lblSoPhongDatTitle.Font = new Font("Segoe UI", 9.5F);
            lblSoPhongDatTitle.ForeColor = Color.WhiteSmoke;
            lblSoPhongDatTitle.Location = new Point(70, 6);
            lblSoPhongDatTitle.Name = "lblSoPhongDatTitle";
            lblSoPhongDatTitle.Size = new Size(106, 21);
            lblSoPhongDatTitle.TabIndex = 1;
            lblSoPhongDatTitle.Text = "Số phòng đặt";
            // 
            // picSoPhongDat
            // 
            picSoPhongDat.Image = Properties.Resources.SoPhongDat;
            picSoPhongDat.Location = new Point(12, 9);
            picSoPhongDat.Name = "picSoPhongDat";
            picSoPhongDat.Size = new Size(44, 44);
            picSoPhongDat.SizeMode = PictureBoxSizeMode.Zoom;
            picSoPhongDat.TabIndex = 0;
            picSoPhongDat.TabStop = false;
            // 
            // cardDoanhThuDV
            // 
            cardDoanhThuDV.BackColor = Color.FromArgb(46, 184, 184);
            cardDoanhThuDV.Controls.Add(lblDoanhThuDVVal);
            cardDoanhThuDV.Controls.Add(lblDoanhThuDVTitle);
            cardDoanhThuDV.Controls.Add(picDoanhThuDV);
            cardDoanhThuDV.Location = new Point(330, 8);
            cardDoanhThuDV.Name = "cardDoanhThuDV";
            cardDoanhThuDV.Size = new Size(308, 62);
            cardDoanhThuDV.TabIndex = 1;
            // 
            // lblDoanhThuDVVal
            // 
            lblDoanhThuDVVal.AutoSize = true;
            lblDoanhThuDVVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDoanhThuDVVal.ForeColor = Color.White;
            lblDoanhThuDVVal.Location = new Point(70, 28);
            lblDoanhThuDVVal.Name = "lblDoanhThuDVVal";
            lblDoanhThuDVVal.Size = new Size(79, 30);
            lblDoanhThuDVVal.TabIndex = 2;
            lblDoanhThuDVVal.Text = "0 VND";
            // 
            // lblDoanhThuDVTitle
            // 
            lblDoanhThuDVTitle.AutoSize = true;
            lblDoanhThuDVTitle.Font = new Font("Segoe UI", 9.5F);
            lblDoanhThuDVTitle.ForeColor = Color.WhiteSmoke;
            lblDoanhThuDVTitle.Location = new Point(70, 6);
            lblDoanhThuDVTitle.Name = "lblDoanhThuDVTitle";
            lblDoanhThuDVTitle.Size = new Size(137, 21);
            lblDoanhThuDVTitle.TabIndex = 1;
            lblDoanhThuDVTitle.Text = "Doanh thu dịch vụ";
            // 
            // picDoanhThuDV
            // 
            picDoanhThuDV.Image = Properties.Resources.DichVu;
            picDoanhThuDV.Location = new Point(12, 9);
            picDoanhThuDV.Name = "picDoanhThuDV";
            picDoanhThuDV.Size = new Size(44, 44);
            picDoanhThuDV.SizeMode = PictureBoxSizeMode.Zoom;
            picDoanhThuDV.TabIndex = 0;
            picDoanhThuDV.TabStop = false;
            // 
            // cardDoanhThuPhong
            // 
            cardDoanhThuPhong.BackColor = Color.FromArgb(235, 115, 87);
            cardDoanhThuPhong.Controls.Add(lblDoanhThuPhongVal);
            cardDoanhThuPhong.Controls.Add(lblDoanhThuPhongTitle);
            cardDoanhThuPhong.Controls.Add(picDoanhThuPhong);
            cardDoanhThuPhong.Location = new Point(12, 8);
            cardDoanhThuPhong.Name = "cardDoanhThuPhong";
            cardDoanhThuPhong.Size = new Size(308, 62);
            cardDoanhThuPhong.TabIndex = 0;
            // 
            // lblDoanhThuPhongVal
            // 
            lblDoanhThuPhongVal.AutoSize = true;
            lblDoanhThuPhongVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDoanhThuPhongVal.ForeColor = Color.White;
            lblDoanhThuPhongVal.Location = new Point(70, 28);
            lblDoanhThuPhongVal.Name = "lblDoanhThuPhongVal";
            lblDoanhThuPhongVal.Size = new Size(79, 30);
            lblDoanhThuPhongVal.TabIndex = 2;
            lblDoanhThuPhongVal.Text = "0 VND";
            // 
            // lblDoanhThuPhongTitle
            // 
            lblDoanhThuPhongTitle.AutoSize = true;
            lblDoanhThuPhongTitle.Font = new Font("Segoe UI", 9.5F);
            lblDoanhThuPhongTitle.ForeColor = Color.WhiteSmoke;
            lblDoanhThuPhongTitle.Location = new Point(70, 6);
            lblDoanhThuPhongTitle.Name = "lblDoanhThuPhongTitle";
            lblDoanhThuPhongTitle.Size = new Size(164, 21);
            lblDoanhThuPhongTitle.TabIndex = 1;
            lblDoanhThuPhongTitle.Text = "Doanh thu thuê phòng";
            // 
            // picDoanhThuPhong
            // 
            picDoanhThuPhong.Image = Properties.Resources.DoanhThuThue;
            picDoanhThuPhong.Location = new Point(12, 9);
            picDoanhThuPhong.Name = "picDoanhThuPhong";
            picDoanhThuPhong.Size = new Size(44, 44);
            picDoanhThuPhong.SizeMode = PictureBoxSizeMode.Zoom;
            picDoanhThuPhong.TabIndex = 0;
            picDoanhThuPhong.TabStop = false;
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.AutoScroll = true;
            pnlMainContainer.Controls.Add(pnlRight);
            pnlMainContainer.Controls.Add(pnlLeft);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(0, 126);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Padding = new Padding(12, 4, 12, 8);
            pnlMainContainer.Size = new Size(980, 504);
            pnlMainContainer.TabIndex = 2;
            // 
            // pnlRight
            // 
            pnlRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlRight.Controls.Add(pnlChartDatPhong);
            pnlRight.Controls.Add(pnlChartDoanhThu);
            pnlRight.Location = new Point(390, 4);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(578, 492);
            pnlRight.TabIndex = 1;
            // 
            // pnlChartDatPhong
            // 
            pnlChartDatPhong.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChartDatPhong.BackColor = Color.White;
            pnlChartDatPhong.BorderStyle = BorderStyle.FixedSingle;
            pnlChartDatPhong.Controls.Add(lblTitleChartDatPhong);
            pnlChartDatPhong.Controls.Add(picChartDatPhong);
            pnlChartDatPhong.Location = new Point(0, 252);
            pnlChartDatPhong.Name = "pnlChartDatPhong";
            pnlChartDatPhong.Size = new Size(578, 238);
            pnlChartDatPhong.TabIndex = 1;
            // 
            // lblTitleChartDatPhong
            // 
            lblTitleChartDatPhong.AutoSize = true;
            lblTitleChartDatPhong.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblTitleChartDatPhong.ForeColor = Color.FromArgb(60, 60, 60);
            lblTitleChartDatPhong.Location = new Point(10, 6);
            lblTitleChartDatPhong.Name = "lblTitleChartDatPhong";
            lblTitleChartDatPhong.Size = new Size(169, 25);
            lblTitleChartDatPhong.TabIndex = 0;
            lblTitleChartDatPhong.Text = "Số phòng được đặt";
            // 
            // picChartDatPhong
            // 
            picChartDatPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picChartDatPhong.Location = new Point(5, 32);
            picChartDatPhong.Name = "picChartDatPhong";
            picChartDatPhong.Size = new Size(566, 198);
            picChartDatPhong.TabIndex = 1;
            picChartDatPhong.TabStop = false;
            picChartDatPhong.Paint += picChartDatPhong_Paint;
            // 
            // pnlChartDoanhThu
            // 
            pnlChartDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlChartDoanhThu.BackColor = Color.White;
            pnlChartDoanhThu.BorderStyle = BorderStyle.FixedSingle;
            pnlChartDoanhThu.Controls.Add(lblTitleChartDoanhThu);
            pnlChartDoanhThu.Controls.Add(picChartDoanhThu);
            pnlChartDoanhThu.Location = new Point(0, 0);
            pnlChartDoanhThu.Name = "pnlChartDoanhThu";
            pnlChartDoanhThu.Size = new Size(578, 244);
            pnlChartDoanhThu.TabIndex = 0;
            // 
            // lblTitleChartDoanhThu
            // 
            lblTitleChartDoanhThu.AutoSize = true;
            lblTitleChartDoanhThu.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            lblTitleChartDoanhThu.ForeColor = Color.FromArgb(60, 60, 60);
            lblTitleChartDoanhThu.Location = new Point(10, 6);
            lblTitleChartDoanhThu.Name = "lblTitleChartDoanhThu";
            lblTitleChartDoanhThu.Size = new Size(205, 25);
            lblTitleChartDoanhThu.TabIndex = 0;
            lblTitleChartDoanhThu.Text = "Doanh thu thuê phòng";
            // 
            // picChartDoanhThu
            // 
            picChartDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picChartDoanhThu.Location = new Point(5, 32);
            picChartDoanhThu.Name = "picChartDoanhThu";
            picChartDoanhThu.Size = new Size(566, 204);
            picChartDoanhThu.TabIndex = 1;
            picChartDoanhThu.TabStop = false;
            picChartDoanhThu.Paint += picChartDoanhThu_Paint;
            // 
            // pnlLeft
            // 
            pnlLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlLeft.Controls.Add(pnlChartDichVu);
            pnlLeft.Controls.Add(pnlTopDV);
            pnlLeft.Controls.Add(pnlTopLpDat);
            pnlLeft.Controls.Add(pnlTopLpDoanhThu);
            pnlLeft.Location = new Point(12, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(368, 492);
            pnlLeft.TabIndex = 0;
            // 
            // pnlChartDichVu
            // 
            pnlChartDichVu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChartDichVu.BackColor = Color.White;
            pnlChartDichVu.BorderStyle = BorderStyle.FixedSingle;
            pnlChartDichVu.Controls.Add(lblTitleChartDV);
            pnlChartDichVu.Controls.Add(picChartDichVu);
            pnlChartDichVu.Location = new Point(0, 200);
            pnlChartDichVu.Name = "pnlChartDichVu";
            pnlChartDichVu.Size = new Size(368, 290);
            pnlChartDichVu.TabIndex = 3;
            // 
            // lblTitleChartDV
            // 
            lblTitleChartDV.AutoSize = true;
            lblTitleChartDV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitleChartDV.ForeColor = Color.FromArgb(60, 60, 60);
            lblTitleChartDV.Location = new Point(10, 6);
            lblTitleChartDV.Name = "lblTitleChartDV";
            lblTitleChartDV.Size = new Size(207, 23);
            lblTitleChartDV.TabIndex = 0;
            lblTitleChartDV.Text = "Các dịch vụ được sử dụng";
            // 
            // picChartDichVu
            // 
            picChartDichVu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picChartDichVu.Location = new Point(5, 32);
            picChartDichVu.Name = "picChartDichVu";
            picChartDichVu.Size = new Size(356, 250);
            picChartDichVu.TabIndex = 1;
            picChartDichVu.TabStop = false;
            picChartDichVu.Paint += picChartDichVu_Paint;
            // 
            // pnlTopDV
            // 
            pnlTopDV.BackColor = Color.FromArgb(245, 245, 245);
            pnlTopDV.BorderStyle = BorderStyle.FixedSingle;
            pnlTopDV.Controls.Add(lblTopDVVal);
            pnlTopDV.Controls.Add(lblTopDVTitle);
            pnlTopDV.Controls.Add(picTopDV);
            pnlTopDV.Location = new Point(0, 132);
            pnlTopDV.Name = "pnlTopDV";
            pnlTopDV.Size = new Size(368, 58);
            pnlTopDV.TabIndex = 2;
            // 
            // lblTopDVVal
            // 
            lblTopDVVal.AutoSize = true;
            lblTopDVVal.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTopDVVal.ForeColor = Color.FromArgb(41, 128, 185);
            lblTopDVVal.Location = new Point(54, 28);
            lblTopDVVal.Name = "lblTopDVVal";
            lblTopDVVal.Size = new Size(92, 21);
            lblTopDVVal.TabIndex = 2;
            lblTopDVVal.Text = "Chưa có DL";
            // 
            // lblTopDVTitle
            // 
            lblTopDVTitle.AutoSize = true;
            lblTopDVTitle.Font = new Font("Segoe UI", 9F);
            lblTopDVTitle.ForeColor = Color.DimGray;
            lblTopDVTitle.Location = new Point(54, 6);
            lblTopDVTitle.Name = "lblTopDVTitle";
            lblTopDVTitle.Size = new Size(183, 20);
            lblTopDVTitle.TabIndex = 1;
            lblTopDVTitle.Text = "Dịch vụ doanh thu cao nhất";
            // 
            // picTopDV
            // 
            picTopDV.Image = Properties.Resources.top3;
            picTopDV.Location = new Point(10, 10);
            picTopDV.Name = "picTopDV";
            picTopDV.Size = new Size(36, 36);
            picTopDV.SizeMode = PictureBoxSizeMode.Zoom;
            picTopDV.TabIndex = 0;
            picTopDV.TabStop = false;
            // 
            // pnlTopLpDat
            // 
            pnlTopLpDat.BackColor = Color.FromArgb(245, 245, 245);
            pnlTopLpDat.BorderStyle = BorderStyle.FixedSingle;
            pnlTopLpDat.Controls.Add(lblTopLpDatVal);
            pnlTopLpDat.Controls.Add(lblTopLpDatTitle);
            pnlTopLpDat.Controls.Add(picTopLpDat);
            pnlTopLpDat.Location = new Point(0, 66);
            pnlTopLpDat.Name = "pnlTopLpDat";
            pnlTopLpDat.Size = new Size(368, 58);
            pnlTopLpDat.TabIndex = 1;
            // 
            // lblTopLpDatVal
            // 
            lblTopLpDatVal.AutoSize = true;
            lblTopLpDatVal.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTopLpDatVal.ForeColor = Color.FromArgb(39, 174, 96);
            lblTopLpDatVal.Location = new Point(54, 28);
            lblTopLpDatVal.Name = "lblTopLpDatVal";
            lblTopLpDatVal.Size = new Size(92, 21);
            lblTopLpDatVal.TabIndex = 2;
            lblTopLpDatVal.Text = "Chưa có DL";
            // 
            // lblTopLpDatTitle
            // 
            lblTopLpDatTitle.AutoSize = true;
            lblTopLpDatTitle.Font = new Font("Segoe UI", 9F);
            lblTopLpDatTitle.ForeColor = Color.DimGray;
            lblTopLpDatTitle.Location = new Point(54, 6);
            lblTopLpDatTitle.Name = "lblTopLpDatTitle";
            lblTopLpDatTitle.Size = new Size(204, 20);
            lblTopLpDatTitle.TabIndex = 1;
            lblTopLpDatTitle.Text = "Loại phòng được đặt nhiều nhất";
            // 
            // picTopLpDat
            // 
            picTopLpDat.Image = Properties.Resources.top2;
            picTopLpDat.Location = new Point(10, 10);
            picTopLpDat.Name = "picTopLpDat";
            picTopLpDat.Size = new Size(36, 36);
            picTopLpDat.SizeMode = PictureBoxSizeMode.Zoom;
            picTopLpDat.TabIndex = 0;
            picTopLpDat.TabStop = false;
            // 
            // pnlTopLpDoanhThu
            // 
            pnlTopLpDoanhThu.BackColor = Color.FromArgb(245, 245, 245);
            pnlTopLpDoanhThu.BorderStyle = BorderStyle.FixedSingle;
            pnlTopLpDoanhThu.Controls.Add(lblTopLpDoanhThuVal);
            pnlTopLpDoanhThu.Controls.Add(lblTopLpDoanhThuTitle);
            pnlTopLpDoanhThu.Controls.Add(picTopLpDoanhThu);
            pnlTopLpDoanhThu.Location = new Point(0, 0);
            pnlTopLpDoanhThu.Name = "pnlTopLpDoanhThu";
            pnlTopLpDoanhThu.Size = new Size(368, 58);
            pnlTopLpDoanhThu.TabIndex = 0;
            // 
            // lblTopLpDoanhThuVal
            // 
            lblTopLpDoanhThuVal.AutoSize = true;
            lblTopLpDoanhThuVal.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTopLpDoanhThuVal.ForeColor = Color.FromArgb(192, 57, 43);
            lblTopLpDoanhThuVal.Location = new Point(54, 28);
            lblTopLpDoanhThuVal.Name = "lblTopLpDoanhThuVal";
            lblTopLpDoanhThuVal.Size = new Size(92, 21);
            lblTopLpDoanhThuVal.TabIndex = 2;
            lblTopLpDoanhThuVal.Text = "Chưa có DL";
            // 
            // lblTopLpDoanhThuTitle
            // 
            lblTopLpDoanhThuTitle.AutoSize = true;
            lblTopLpDoanhThuTitle.Font = new Font("Segoe UI", 9F);
            lblTopLpDoanhThuTitle.ForeColor = Color.DimGray;
            lblTopLpDoanhThuTitle.Location = new Point(54, 6);
            lblTopLpDoanhThuTitle.Name = "lblTopLpDoanhThuTitle";
            lblTopLpDoanhThuTitle.Size = new Size(207, 20);
            lblTopLpDoanhThuTitle.TabIndex = 1;
            lblTopLpDoanhThuTitle.Text = "Loại phòng doanh thu cao nhất";
            // 
            // picTopLpDoanhThu
            // 
            picTopLpDoanhThu.Image = Properties.Resources.top1;
            picTopLpDoanhThu.Location = new Point(10, 10);
            picTopLpDoanhThu.Name = "picTopLpDoanhThu";
            picTopLpDoanhThu.Size = new Size(36, 36);
            picTopLpDoanhThu.SizeMode = PictureBoxSizeMode.Zoom;
            picTopLpDoanhThu.TabIndex = 0;
            picTopLpDoanhThu.TabStop = false;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(980, 630);
            Controls.Add(pnlMainContainer);
            Controls.Add(pnlCards);
            Controls.Add(pnlHeader);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo thống kê tình hình kinh doanh";
            Load += FormThongKe_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCards.ResumeLayout(false);
            cardSoPhongDat.ResumeLayout(false);
            cardSoPhongDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSoPhongDat).EndInit();
            cardDoanhThuDV.ResumeLayout(false);
            cardDoanhThuDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDoanhThuDV).EndInit();
            cardDoanhThuPhong.ResumeLayout(false);
            cardDoanhThuPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDoanhThuPhong).EndInit();
            pnlMainContainer.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlChartDatPhong.ResumeLayout(false);
            pnlChartDatPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChartDatPhong).EndInit();
            pnlChartDoanhThu.ResumeLayout(false);
            pnlChartDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChartDoanhThu).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlChartDichVu.ResumeLayout(false);
            pnlChartDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChartDichVu).EndInit();
            pnlTopDV.ResumeLayout(false);
            pnlTopDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTopDV).EndInit();
            pnlTopLpDat.ResumeLayout(false);
            pnlTopLpDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTopLpDat).EndInit();
            pnlTopLpDoanhThu.ResumeLayout(false);
            pnlTopLpDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTopLpDoanhThu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTuNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnXemThongKe;
        private Panel pnlCards;
        private Panel cardDoanhThuPhong;
        private PictureBox picDoanhThuPhong;
        private Label lblDoanhThuPhongTitle;
        private Label lblDoanhThuPhongVal;
        private Panel cardDoanhThuDV;
        private Label lblDoanhThuDVVal;
        private Label lblDoanhThuDVTitle;
        private PictureBox picDoanhThuDV;
        private Panel cardSoPhongDat;
        private Label lblSoPhongDatVal;
        private Label lblSoPhongDatTitle;
        private PictureBox picSoPhongDat;
        private Panel pnlMainContainer;
        private Panel pnlLeft;
        private Panel pnlRight;
        private Panel pnlTopLpDoanhThu;
        private PictureBox picTopLpDoanhThu;
        private Label lblTopLpDoanhThuTitle;
        private Label lblTopLpDoanhThuVal;
        private Panel pnlTopLpDat;
        private Label lblTopLpDatVal;
        private Label lblTopLpDatTitle;
        private PictureBox picTopLpDat;
        private Panel pnlTopDV;
        private Label lblTopDVVal;
        private Label lblTopDVTitle;
        private PictureBox picTopDV;
        private Panel pnlChartDichVu;
        private Label lblTitleChartDV;
        private PictureBox picChartDichVu;
        private Panel pnlChartDoanhThu;
        private Label lblTitleChartDoanhThu;
        private PictureBox picChartDoanhThu;
        private Panel pnlChartDatPhong;
        private Label lblTitleChartDatPhong;
        private PictureBox picChartDatPhong;
    }
}
