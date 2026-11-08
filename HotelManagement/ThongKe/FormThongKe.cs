using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.ThongKe
{
    public partial class FormThongKe : Form
    {
        private readonly CultureInfo viVN = new CultureInfo("vi-VN");

        private sealed class ThongKeLoaiPhong
        {
            public string TenLP { get; set; } = "";
            public decimal DoanhThu { get; set; }
            public int SoLuotDat { get; set; }
        }

        private sealed class ThongKeDichVu
        {
            public string TenDV { get; set; } = "";
            public int SoLuong { get; set; }
            public decimal DoanhThu { get; set; }
            public Color Mau { get; set; }
        }

        private List<ThongKeLoaiPhong> _duLieuLoaiPhong = new List<ThongKeLoaiPhong>();
        private List<ThongKeDichVu> _duLieuDichVu = new List<ThongKeDichVu>();

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            // Default: From 1st day of current month to today (or past 30 days)
            DateTime today = DateTime.Today;
            dtpTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpDenNgay.Value = today;

            TaiDuLieuThongKe();
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            TaiDuLieuThongKe();
        }

        private void TaiDuLieuThongKe()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var db = new HotelManagementContext();

                // 1. Invoices in range
                var hoaDons = db.HoaDons
                    .AsNoTracking()
                    .Where(h => h.NgHd >= tuNgay && h.NgHd <= denNgay && h.DaXoa != true)
                    .Select(h => new
                    {
                        h.MaHd,
                        h.NgHd,
                        h.MaCtdp,
                        TienPhong = h.MaCtdpNavigation.ThanhTien ?? 0m,
                        MaPH = h.MaCtdpNavigation.MaPh,
                        TenLP = h.MaCtdpNavigation.MaPhNavigation.MaLphNavigation.TenLph,
                        DichVus = h.MaCtdpNavigation.Ctdvs
                            .Where(v => v.DaXoa != true)
                            .Select(v => new
                            {
                                v.MaDv,
                                TenDV = v.MaDvNavigation.TenDv,
                                v.Sl,
                                DonGia = v.MaDvNavigation.DonGia,
                                ThanhTien = v.ThanhTien ?? (v.Sl * v.MaDvNavigation.DonGia)
                            }).ToList()
                    })
                    .ToList();

                // 2. Active booking details (Ctdps) in range to accurately reflect bookings
                var chiTietDatPhongs = db.Ctdps
                    .AsNoTracking()
                    .Where(c => c.CheckIn >= tuNgay && c.CheckIn <= denNgay && c.DaXoa != true)
                    .Select(c => new
                    {
                        c.MaCtdp,
                        c.MaPh,
                        TenLP = c.MaPhNavigation.MaLphNavigation.TenLph,
                        c.ThanhTien
                    })
                    .ToList();

                // Top cards
                decimal tongTienPhong = hoaDons.Sum(h => h.TienPhong);
                decimal tongTienDV = hoaDons.SelectMany(h => h.DichVus).Sum(v => v.ThanhTien);
                int soPhongDat = chiTietDatPhongs.Count > 0 ? chiTietDatPhongs.Count : hoaDons.Count;

                lblDoanhThuPhongVal.Text = tongTienPhong.ToString("N0", viVN) + " VND";
                lblDoanhThuDVVal.Text = tongTienDV.ToString("N0", viVN) + " VND";
                lblSoPhongDatVal.Text = soPhongDat.ToString();

                // Group by Room Type
                var allRoomTypes = db.LoaiPhongs
                    .AsNoTracking()
                    .Select(l => l.TenLph)
                    .ToList();

                _duLieuLoaiPhong = allRoomTypes.Select(tenLP =>
                {
                    decimal dtPhong = hoaDons.Where(h => h.TenLP == tenLP).Sum(h => h.TienPhong);
                    int luotDat = chiTietDatPhongs.Where(c => c.TenLP == tenLP).Count();
                    if (luotDat == 0)
                        luotDat = hoaDons.Where(h => h.TenLP == tenLP).Count();

                    return new ThongKeLoaiPhong
                    {
                        TenLP = tenLP,
                        DoanhThu = dtPhong,
                        SoLuotDat = luotDat
                    };
                }).ToList();

                // Top Room by Revenue
                var topLpDoanhThu = _duLieuLoaiPhong.OrderByDescending(x => x.DoanhThu).FirstOrDefault(x => x.DoanhThu > 0);
                if (topLpDoanhThu != null)
                {
                    lblTopLpDoanhThuVal.Text = $"{topLpDoanhThu.TenLP} ({topLpDoanhThu.DoanhThu.ToString("N0", viVN)} VND)";
                }
                else
                {
                    lblTopLpDoanhThuVal.Text = "Chưa có dữ liệu";
                }

                // Top Room by Bookings
                var topLpDat = _duLieuLoaiPhong.OrderByDescending(x => x.SoLuotDat).FirstOrDefault(x => x.SoLuotDat > 0);
                if (topLpDat != null)
                {
                    lblTopLpDatVal.Text = $"{topLpDat.TenLP} ({topLpDat.SoLuotDat} lượt)";
                }
                else
                {
                    lblTopLpDatVal.Text = "Chưa có dữ liệu";
                }

                // Group by Service
                var allDVs = hoaDons.SelectMany(h => h.DichVus).ToList();
                var dvGroups = allDVs.GroupBy(v => v.TenDV)
                    .Select(g => new
                    {
                        TenDV = g.Key,
                        SoLuong = g.Sum(x => x.Sl),
                        DoanhThu = g.Sum(x => x.ThanhTien)
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                // Top Service by Revenue
                var topDV = dvGroups.FirstOrDefault();
                if (topDV != null && topDV.DoanhThu > 0)
                {
                    lblTopDVVal.Text = $"{topDV.TenDV} ({topDV.DoanhThu.ToString("N0", viVN)} VND)";
                }
                else
                {
                    lblTopDVVal.Text = "Chưa có dữ liệu";
                }

                Color[] bangMau = new Color[]
                {
                    Color.FromArgb(235, 115, 87),
                    Color.FromArgb(46, 184, 184),
                    Color.FromArgb(92, 184, 92),
                    Color.FromArgb(240, 173, 78),
                    Color.FromArgb(155, 89, 182),
                    Color.FromArgb(52, 152, 219)
                };

                _duLieuDichVu = dvGroups.Select((g, i) => new ThongKeDichVu
                {
                    TenDV = g.TenDV,
                    SoLuong = g.SoLuong,
                    DoanhThu = g.DoanhThu,
                    Mau = bangMau[i % bangMau.Length]
                }).ToList();

                picChartDichVu.Invalidate();
                picChartDoanhThu.Invalidate();
                picChartDatPhong.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picChartDichVu_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picChartDichVu.Width;
            int h = picChartDichVu.Height;

            if (_duLieuDichVu.Count == 0 || _duLieuDichVu.All(x => x.SoLuong == 0))
            {
                using var font = new Font("Segoe UI", 10.5F, FontStyle.Italic);
                using var brush = new SolidBrush(Color.Gray);
                g.DrawString("Không có dịch vụ nào được dùng trong khoảng thời gian này.", font, brush, new RectangleF(10, 50, w - 20, 50));
                return;
            }

            int totalSL = _duLieuDichVu.Sum(x => x.SoLuong);
            int pieSize = Math.Min(160, Math.Min(w / 2, h - 20));
            Rectangle pieRect = new Rectangle(15, (h - pieSize) / 2, pieSize, pieSize);

            float currentAngle = -90f;
            foreach (var item in _duLieuDichVu)
            {
                if (item.SoLuong <= 0) continue;
                float sweepAngle = (float)item.SoLuong / totalSL * 360f;
                using var brush = new SolidBrush(item.Mau);
                g.FillPie(brush, pieRect, currentAngle, sweepAngle);
                currentAngle += sweepAngle;
            }

            // Draw center circle for donut look
            int innerSize = (int)(pieSize * 0.45);
            Rectangle innerRect = new Rectangle(pieRect.X + (pieSize - innerSize) / 2, pieRect.Y + (pieSize - innerSize) / 2, innerSize, innerSize);
            using (var whiteBrush = new SolidBrush(Color.White))
            {
                g.FillEllipse(whiteBrush, innerRect);
            }

            // Draw Legend
            int legendX = pieRect.Right + 20;
            int legendY = 20;
            using var textFont = new Font("Segoe UI", 9F);
            using var textBrush = new SolidBrush(Color.FromArgb(50, 50, 50));

            foreach (var item in _duLieuDichVu.Take(6))
            {
                using var squareBrush = new SolidBrush(item.Mau);
                g.FillRectangle(squareBrush, legendX, legendY + 2, 12, 12);

                string legendText = $"{item.TenDV} ({item.SoLuong})";
                g.DrawString(legendText, textFont, textBrush, legendX + 18, legendY);
                legendY += 24;
                if (legendY > h - 25) break;
            }
        }

        private void picChartDoanhThu_Paint(object sender, PaintEventArgs e)
        {
            VeBieuDoCot(e.Graphics, picChartDoanhThu.Width, picChartDoanhThu.Height,
                _duLieuLoaiPhong.Select(x => x.TenLP).ToList(),
                _duLieuLoaiPhong.Select(x => x.DoanhThu).ToList(),
                "Doanh thu (VND)",
                Color.FromArgb(54, 162, 235),
                isCurrency: true);
        }

        private void picChartDatPhong_Paint(object sender, PaintEventArgs e)
        {
            VeBieuDoCot(e.Graphics, picChartDatPhong.Width, picChartDatPhong.Height,
                _duLieuLoaiPhong.Select(x => x.TenLP).ToList(),
                _duLieuLoaiPhong.Select(x => (decimal)x.SoLuotDat).ToList(),
                "Số lượng đặt",
                Color.FromArgb(75, 192, 192),
                isCurrency: false);
        }

        private void VeBieuDoCot(Graphics g, int width, int height, List<string> labels, List<decimal> values, string legendTitle, Color barColor, bool isCurrency)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int leftPadding = isCurrency ? 90 : 50;
            int rightPadding = 30;
            int topPadding = 25;
            int bottomPadding = 45;

            int plotWidth = width - leftPadding - rightPadding;
            int plotHeight = height - topPadding - bottomPadding;

            if (plotWidth <= 0 || plotHeight <= 0) return;

            decimal maxVal = values.Count > 0 ? values.Max() : 0m;
            if (maxVal <= 0) maxVal = isCurrency ? 1000000m : 4m;
            else maxVal *= 1.2m; // add 20% headroom

            // Draw Y-axis grid lines and labels
            int numSteps = 4;
            using var gridPen = new Pen(Color.FromArgb(230, 230, 230));
            using var font = new Font("Segoe UI", 8.5F);
            using var axisBrush = new SolidBrush(Color.DimGray);

            for (int i = 0; i <= numSteps; i++)
            {
                decimal stepVal = (maxVal / numSteps) * i;
                int y = topPadding + plotHeight - (int)((stepVal / maxVal) * plotHeight);

                g.DrawLine(gridPen, leftPadding, y, leftPadding + plotWidth, y);

                string label = isCurrency ? stepVal.ToString("N0", viVN) : stepVal.ToString("0.#");
                SizeF size = g.MeasureString(label, font);
                g.DrawString(label, font, axisBrush, leftPadding - size.Width - 6, y - size.Height / 2);
            }

            // Draw X and Y main axis
            using var axisPen = new Pen(Color.FromArgb(180, 180, 180), 1.5f);
            g.DrawLine(axisPen, leftPadding, topPadding, leftPadding, topPadding + plotHeight);
            g.DrawLine(axisPen, leftPadding, topPadding + plotHeight, leftPadding + plotWidth, topPadding + plotHeight);

            // Draw Bars
            int count = labels.Count;
            if (count > 0)
            {
                int barSlotWidth = plotWidth / count;
                int barWidth = Math.Min(60, (int)(barSlotWidth * 0.55));

                using var barBrush = new SolidBrush(barColor);
                using var barBorderPen = new Pen(Color.FromArgb(barColor.R / 2, barColor.G / 2, barColor.B / 2), 1);

                for (int i = 0; i < count; i++)
                {
                    decimal val = i < values.Count ? values[i] : 0m;
                    int barHeight = (int)((val / maxVal) * plotHeight);
                    int x = leftPadding + (i * barSlotWidth) + (barSlotWidth - barWidth) / 2;
                    int y = topPadding + plotHeight - barHeight;

                    if (barHeight > 0)
                    {
                        g.FillRectangle(barBrush, x, y, barWidth, barHeight);
                        g.DrawRectangle(barBorderPen, x, y, barWidth, barHeight);
                    }

                    // X-axis label
                    string name = labels[i];
                    SizeF nameSize = g.MeasureString(name, font);
                    g.DrawString(name, font, axisBrush, x + (barWidth - nameSize.Width) / 2, topPadding + plotHeight + 6);
                }
            }

            // Draw Legend at top right
            int legSquare = 12;
            int legX = width - rightPadding - 140;
            int legY = 6;
            using var legBrush = new SolidBrush(barColor);
            g.FillRectangle(legBrush, legX, legY + 2, legSquare, legSquare);
            g.DrawString(legendTitle, font, axisBrush, legX + legSquare + 6, legY);
        }
    }
}
