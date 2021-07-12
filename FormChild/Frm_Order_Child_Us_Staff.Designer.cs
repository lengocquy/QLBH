namespace QuanLyBanXe.FormChild
{
    partial class Frm_Order_Child_Us_Staff
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dtgwOrder = new System.Windows.Forms.DataGridView();
            this.dtgwTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwTenDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwMauXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgwNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(974, 502);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.dtgwOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgwOrder.EnableHeadersVisualStyles = false;
            this.dtgwOrder.GridColor = System.Drawing.Color.White;
            this.dtgwOrder.Location = new System.Drawing.Point(0, 0);
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
            this.dtgwOrder.Size = new System.Drawing.Size(1105, 478);
            this.dtgwOrder.TabIndex = 5;
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
            // Frm_Order_Child_Us_Staff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1105, 569);
            this.Controls.Add(this.dtgwOrder);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Order_Child_Us_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Order_Child_Us_Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dtgwOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dtgwOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwTenDongXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwMauXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgwNgayLap;
    }
}