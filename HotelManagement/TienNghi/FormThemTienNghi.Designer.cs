namespace HotelManagement.TienNghi
{
    partial class FormThemTienNghi
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
            LabelThemTienNghi = new Label();
            label1 = new Label();
            txtTenTN = new TextBox();
            btnThoat = new Button();
            btnThemMoi = new Button();
            txtMaTN = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // LabelThemTienNghi
            // 
            LabelThemTienNghi.AutoSize = true;
            LabelThemTienNghi.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelThemTienNghi.ForeColor = Color.FromArgb(192, 0, 0);
            LabelThemTienNghi.Location = new Point(140, 25);
            LabelThemTienNghi.Margin = new Padding(4, 0, 4, 0);
            LabelThemTienNghi.Name = "LabelThemTienNghi";
            LabelThemTienNghi.Size = new Size(231, 41);
            LabelThemTienNghi.TabIndex = 1;
            LabelThemTienNghi.Text = "Thêm tiện nghi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 95);
            label2.Name = "label2";
            label2.Size = new Size(116, 24);
            label2.TabIndex = 16;
            label2.Text = "Mã tiện nghi";
            // 
            // txtMaTN
            // 
            txtMaTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaTN.Location = new Point(175, 92);
            txtMaTN.Margin = new Padding(3, 4, 3, 4);
            txtMaTN.Name = "txtMaTN";
            txtMaTN.Size = new Size(280, 28);
            txtMaTN.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 155);
            label1.Name = "label1";
            label1.Size = new Size(124, 24);
            label1.TabIndex = 2;
            label1.Text = "Tên tiện nghi";
            // 
            // txtTenTN
            // 
            txtTenTN.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenTN.Location = new Point(175, 152);
            txtTenTN.Margin = new Padding(3, 4, 3, 4);
            txtTenTN.Name = "txtTenTN";
            txtTenTN.Size = new Size(280, 28);
            txtTenTN.TabIndex = 3;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThemMoi.Location = new Point(110, 220);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(120, 42);
            btnThemMoi.TabIndex = 14;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(260, 220);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 42);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormThemTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(txtMaTN);
            Controls.Add(label2);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(txtTenTN);
            Controls.Add(label1);
            Controls.Add(LabelThemTienNghi);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormThemTienNghi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm tiện nghi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LabelThemTienNghi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.Label label2;
    }
}
