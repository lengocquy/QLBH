namespace QuanLyBanXe.Us_ChucNang
{
    partial class Us_Order
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

        #region Component Designer generated code

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Us_Order));
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dtgwOrder = new System.Windows.Forms.DataGridView();
            this.dtgwTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwTenDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwMauXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeeDetailOrder = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxSearch.BackColor = System.Drawing.Color.Black;
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.ForeColor = System.Drawing.Color.White;
            this.tbxSearch.Location = new System.Drawing.Point(745, 32);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(374, 36);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.Text = "Tìm kiếm theo tên khách hàng";
            this.tbxSearch.WordWrap = false;
            this.tbxSearch.Enter += new System.EventHandler(this.tbxSearch_Enter);
            this.tbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyDown);
            this.tbxSearch.Leave += new System.EventHandler(this.tbxSearch_Leave);
            // 
            // dtgwOrder
            // 
            this.dtgwOrder.AllowUserToAddRows = false;
            this.dtgwOrder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgwOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgwOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgwOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgwOrder.BackgroundColor = System.Drawing.Color.White;
            this.dtgwOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgwOrder.CausesValidation = false;
            this.dtgwOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgwOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgwOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgwOrder.ColumnHeadersHeight = 50;
            this.dtgwOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtgwOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgwOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgwOrder.EnableHeadersVisualStyles = false;
            this.dtgwOrder.GridColor = System.Drawing.Color.White;
            this.dtgwOrder.Location = new System.Drawing.Point(0, 89);
            this.dtgwOrder.MultiSelect = false;
            this.dtgwOrder.Name = "dtgwOrder";
            this.dtgwOrder.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgwOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgwOrder.RowHeadersVisible = false;
            this.dtgwOrder.RowHeadersWidth = 50;
            this.dtgwOrder.RowTemplate.Height = 24;
            this.dtgwOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgwOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgwOrder.Size = new System.Drawing.Size(1137, 625);
            this.dtgwOrder.TabIndex = 4;
            this.dtgwOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgwOrder_CellClick);
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
            this.dtgwCMND.Width = 119;
            // 
            // dtgwTenDongXe
            // 
            this.dtgwTenDongXe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtgwTenDongXe.DataPropertyName = "DongXe";
            this.dtgwTenDongXe.FillWeight = 89.54314F;
            this.dtgwTenDongXe.HeaderText = "Dòng Xe";
            this.dtgwTenDongXe.Name = "dtgwTenDongXe";
            this.dtgwTenDongXe.ReadOnly = true;
            this.dtgwTenDongXe.Width = 136;
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
            this.dtgwMauXe.Width = 128;
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
            this.dtgwThanhTien.Width = 160;
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
            this.dtgwNgayLap.Width = 136;
            // 
            // btnSeeDetailOrder
            // 
            this.btnSeeDetailOrder.BackColor = System.Drawing.Color.Red;
            this.btnSeeDetailOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeDetailOrder.FlatAppearance.BorderSize = 0;
            this.btnSeeDetailOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeeDetailOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSeeDetailOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeDetailOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeDetailOrder.ForeColor = System.Drawing.Color.White;
            this.btnSeeDetailOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnSeeDetailOrder.Image")));
            this.btnSeeDetailOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeDetailOrder.Location = new System.Drawing.Point(22, 26);
            this.btnSeeDetailOrder.Name = "btnSeeDetailOrder";
            this.btnSeeDetailOrder.Size = new System.Drawing.Size(168, 44);
            this.btnSeeDetailOrder.TabIndex = 5;
            this.btnSeeDetailOrder.Text = "         Xem chi tiết";
            this.btnSeeDetailOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeDetailOrder.UseVisualStyleBackColor = false;
            this.btnSeeDetailOrder.Click += new System.EventHandler(this.btnSeeDetailOrder_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(365, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 42);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Red;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(211, 26);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(148, 44);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "         Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // Us_Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnSeeDetailOrder);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtgwOrder);
            this.Controls.Add(this.tbxSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Us_Order";
            this.Size = new System.Drawing.Size(1137, 714);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnSeeDetailOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwTenDongXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwMauXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwNgayLap;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dtgwOrder;
    }
}
