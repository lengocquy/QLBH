namespace QuanLyBanXe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnSilde = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnWareHouse = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.pnHead = new System.Windows.Forms.Panel();
            this.btnHiden = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnFill = new System.Windows.Forms.Panel();
            this.dragControl1 = new QuanLyBanXe.ControlClass.DragControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 752);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pnSilde);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnAccount);
            this.panel2.Controls.Add(this.btnWareHouse);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.btnSales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 714);
            this.panel2.TabIndex = 0;
            // 
            // pnSilde
            // 
            this.pnSilde.BackColor = System.Drawing.Color.Yellow;
            this.pnSilde.Location = new System.Drawing.Point(0, 0);
            this.pnSilde.Name = "pnSilde";
            this.pnSilde.Size = new System.Drawing.Size(5, 105);
            this.pnSilde.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetting.Location = new System.Drawing.Point(5, 432);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(137, 105);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Thiếp lập";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSettting_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccount.Location = new System.Drawing.Point(5, 321);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(137, 105);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWareHouse.FlatAppearance.BorderSize = 0;
            this.btnWareHouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWareHouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnWareHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWareHouse.ForeColor = System.Drawing.Color.White;
            this.btnWareHouse.Image = ((System.Drawing.Image)(resources.GetObject("btnWareHouse.Image")));
            this.btnWareHouse.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWareHouse.Location = new System.Drawing.Point(5, 216);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Size = new System.Drawing.Size(137, 105);
            this.btnWareHouse.TabIndex = 3;
            this.btnWareHouse.Text = "Nhà kho ";
            this.btnWareHouse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWareHouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWareHouse.UseVisualStyleBackColor = true;
            this.btnWareHouse.Click += new System.EventHandler(this.btnWareHouse_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrder.Location = new System.Drawing.Point(5, 105);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(137, 105);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Đơn bán xe";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSales
            // 
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.Location = new System.Drawing.Point(5, 0);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(137, 105);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Bán hàng";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // pnHead
            // 
            this.pnHead.Controls.Add(this.btnHiden);
            this.pnHead.Controls.Add(this.btnClose);
            this.pnHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHead.Location = new System.Drawing.Point(144, 0);
            this.pnHead.Name = "pnHead";
            this.pnHead.Size = new System.Drawing.Size(1137, 38);
            this.pnHead.TabIndex = 1;
            // 
            // btnHiden
            // 
            this.btnHiden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHiden.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHiden.FlatAppearance.BorderSize = 0;
            this.btnHiden.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHiden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHiden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHiden.Image = ((System.Drawing.Image)(resources.GetObject("btnHiden.Image")));
            this.btnHiden.Location = new System.Drawing.Point(1045, 0);
            this.btnHiden.Name = "btnHiden";
            this.btnHiden.Size = new System.Drawing.Size(46, 38);
            this.btnHiden.TabIndex = 1;
            this.btnHiden.UseVisualStyleBackColor = true;
            this.btnHiden.Click += new System.EventHandler(this.btnHiden_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1091, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnFill
            // 
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnFill.Location = new System.Drawing.Point(144, 38);
            this.pnFill.Name = "pnFill";
            this.pnFill.Size = new System.Drawing.Size(1137, 714);
            this.pnFill.TabIndex = 2;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnHead;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 752);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.pnHead);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnHead;
        private System.Windows.Forms.Button btnHiden;
        private System.Windows.Forms.Button btnClose;
        private ControlClass.DragControl dragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnWareHouse;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel pnFill;
        private System.Windows.Forms.Panel pnSilde;
        private System.Windows.Forms.Button btnSetting;
    }
}

