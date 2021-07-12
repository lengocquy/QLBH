namespace QuanLyBanXe
{
    partial class Frm_ThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThongKe));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgwOrderThongKe = new System.Windows.Forms.DataGridView();
            this.dtgwTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwTenDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwMauXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwOrderThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1141, 56);
            this.label1.TabIndex = 57;
            this.label1.Text = "Thông Kê Hóa Đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgwOrderThongKe
            // 
            this.dtgwOrderThongKe.AllowUserToAddRows = false;
            this.dtgwOrderThongKe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgwOrderThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgwOrderThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgwOrderThongKe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgwOrderThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dtgwOrderThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgwOrderThongKe.CausesValidation = false;
            this.dtgwOrderThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgwOrderThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgwOrderThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgwOrderThongKe.ColumnHeadersHeight = 50;
            this.dtgwOrderThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgwTenKH,
            this.dtgwCMND,
            this.dtgwTenDongXe,
            this.dtgwTenXe,
            this.dtgwMauXe,
            this.dtgwThanhTien,
            this.dtgwNgayLap});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgwOrderThongKe.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgwOrderThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgwOrderThongKe.EnableHeadersVisualStyles = false;
            this.dtgwOrderThongKe.GridColor = System.Drawing.Color.White;
            this.dtgwOrderThongKe.Location = new System.Drawing.Point(0, 56);
            this.dtgwOrderThongKe.MultiSelect = false;
            this.dtgwOrderThongKe.Name = "dtgwOrderThongKe";
            this.dtgwOrderThongKe.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgwOrderThongKe.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgwOrderThongKe.RowHeadersVisible = false;
            this.dtgwOrderThongKe.RowHeadersWidth = 50;
            this.dtgwOrderThongKe.RowTemplate.Height = 24;
            this.dtgwOrderThongKe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgwOrderThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgwOrderThongKe.Size = new System.Drawing.Size(1141, 569);
            this.dtgwOrderThongKe.TabIndex = 58;
            this.dtgwOrderThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwOrderThongKe_CellContentClick);
            // 
            // dtgwTenKH
            // 
            this.dtgwTenKH.DataPropertyName = "TenKH";
            this.dtgwTenKH.FillWeight = 152.2843F;
            this.dtgwTenKH.HeaderText = "Họ Và Tên";
            this.dtgwTenKH.Name = "dtgwTenKH";
            this.dtgwTenKH.ReadOnly = true;
            // 
            // dtgwCMND
            // 
            this.dtgwCMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtgwCMND.DataPropertyName = "CMND";
            this.dtgwCMND.HeaderText = "CMND";
            this.dtgwCMND.Name = "dtgwCMND";
            this.dtgwCMND.ReadOnly = true;
            this.dtgwCMND.Width = 99;
            // 
            // dtgwTenDongXe
            // 
            this.dtgwTenDongXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtgwTenDongXe.DataPropertyName = "DongXe";
            this.dtgwTenDongXe.FillWeight = 89.54314F;
            this.dtgwTenDongXe.HeaderText = "Dòng Xe";
            this.dtgwTenDongXe.Name = "dtgwTenDongXe";
            this.dtgwTenDongXe.ReadOnly = true;
            this.dtgwTenDongXe.Width = 115;
            // 
            // dtgwTenXe
            // 
            this.dtgwTenXe.DataPropertyName = "TenXe";
            this.dtgwTenXe.FillWeight = 89.54314F;
            this.dtgwTenXe.HeaderText = "Tên Xe";
            this.dtgwTenXe.Name = "dtgwTenXe";
            this.dtgwTenXe.ReadOnly = true;
            // 
            // dtgwMauXe
            // 
            this.dtgwMauXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtgwMauXe.DataPropertyName = "MauXe";
            this.dtgwMauXe.FillWeight = 89.54314F;
            this.dtgwMauXe.HeaderText = "Màu Xe";
            this.dtgwMauXe.Name = "dtgwMauXe";
            this.dtgwMauXe.ReadOnly = true;
            this.dtgwMauXe.Width = 107;
            // 
            // dtgwThanhTien
            // 
            this.dtgwThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtgwThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.dtgwThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgwThanhTien.FillWeight = 89.54314F;
            this.dtgwThanhTien.HeaderText = "Thành Tiền";
            this.dtgwThanhTien.Name = "dtgwThanhTien";
            this.dtgwThanhTien.ReadOnly = true;
            this.dtgwThanhTien.Width = 131;
            // 
            // dtgwNgayLap
            // 
            this.dtgwNgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtgwNgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dtgwNgayLap.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgwNgayLap.FillWeight = 89.54314F;
            this.dtgwNgayLap.HeaderText = "Ngày lập";
            this.dtgwNgayLap.Name = "dtgwNgayLap";
            this.dtgwNgayLap.ReadOnly = true;
            this.dtgwNgayLap.Width = 113;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(969, 647);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 45);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.CalendarForeColor = System.Drawing.Color.Red;
            this.dtpkFromDate.CalendarMonthBackground = System.Drawing.Color.Lime;
            this.dtpkFromDate.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtpkFromDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpkFromDate.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.dtpkFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFromDate.Location = new System.Drawing.Point(13, 632);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(173, 28);
            this.dtpkFromDate.TabIndex = 60;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkToDate.Location = new System.Drawing.Point(12, 673);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(173, 28);
            this.dtpkToDate.TabIndex = 60;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Red;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(203, 647);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(191, 45);
            this.btnThongKe.TabIndex = 59;
            this.btnThongKe.Text = "         Thông kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 718);
            this.Controls.Add(this.dtpkToDate);
            this.Controls.Add(this.dtpkFromDate);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtgwOrderThongKe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dtgwOrderThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DataGridView dtgwOrderThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwTenDongXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwMauXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwNgayLap;
    }
}