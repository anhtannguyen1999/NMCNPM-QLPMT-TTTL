namespace GUI
{
    partial class fThemBenhNhanVaoDanhSachKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemBenhNhanVaoDanhSachKham));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.btnThemVaoDanhSach = new System.Windows.Forms.Button();
            this.grvDanhSachKham = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaKhoiDS = new System.Windows.Forms.Button();
            this.tbxMaBenhNhan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachKham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DANH SÁCH KHÁM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày khám:";
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoTen.Location = new System.Drawing.Point(167, 186);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.ReadOnly = true;
            this.tbxHoTen.Size = new System.Drawing.Size(327, 30);
            this.tbxHoTen.TabIndex = 2;
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(170, 102);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(179, 26);
            this.dtpNgayKham.TabIndex = 2;
            this.dtpNgayKham.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnThemVaoDanhSach
            // 
            this.btnThemVaoDanhSach.BackColor = System.Drawing.Color.White;
            this.btnThemVaoDanhSach.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoDanhSach.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVaoDanhSach.Image")));
            this.btnThemVaoDanhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVaoDanhSach.Location = new System.Drawing.Point(284, 221);
            this.btnThemVaoDanhSach.Name = "btnThemVaoDanhSach";
            this.btnThemVaoDanhSach.Size = new System.Drawing.Size(210, 53);
            this.btnThemVaoDanhSach.TabIndex = 4;
            this.btnThemVaoDanhSach.Text = "Thêm bệnh nhân";
            this.btnThemVaoDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoDanhSach.UseVisualStyleBackColor = false;
            this.btnThemVaoDanhSach.Click += new System.EventHandler(this.btnThemVaoDanhSach_Click);
            // 
            // grvDanhSachKham
            // 
            this.grvDanhSachKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDanhSachKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT});
            this.grvDanhSachKham.Location = new System.Drawing.Point(6, 31);
            this.grvDanhSachKham.Name = "grvDanhSachKham";
            this.grvDanhSachKham.ReadOnly = true;
            this.grvDanhSachKham.RowTemplate.Height = 24;
            this.grvDanhSachKham.Size = new System.Drawing.Size(705, 349);
            this.grvDanhSachKham.TabIndex = 5;
            this.grvDanhSachKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDanhSachKham_CellClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvDanhSachKham);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 409);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khám";
            // 
            // btnXoaKhoiDS
            // 
            this.btnXoaKhoiDS.BackColor = System.Drawing.Color.White;
            this.btnXoaKhoiDS.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaKhoiDS.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKhoiDS.Image")));
            this.btnXoaKhoiDS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKhoiDS.Location = new System.Drawing.Point(167, 222);
            this.btnXoaKhoiDS.Name = "btnXoaKhoiDS";
            this.btnXoaKhoiDS.Size = new System.Drawing.Size(111, 52);
            this.btnXoaKhoiDS.TabIndex = 3;
            this.btnXoaKhoiDS.Text = "  Xóa";
            this.btnXoaKhoiDS.UseVisualStyleBackColor = false;
            this.btnXoaKhoiDS.Click += new System.EventHandler(this.btnXoaKhoiDS_Click);
            // 
            // tbxMaBenhNhan
            // 
            this.tbxMaBenhNhan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaBenhNhan.Location = new System.Drawing.Point(167, 146);
            this.tbxMaBenhNhan.Name = "tbxMaBenhNhan";
            this.tbxMaBenhNhan.Size = new System.Drawing.Size(327, 30);
            this.tbxMaBenhNhan.TabIndex = 1;
            this.tbxMaBenhNhan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbxMaBenhNhan_KeyUp);
            // 
            // fThemBenhNhanVaoDanhSachKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(769, 676);
            this.Controls.Add(this.tbxMaBenhNhan);
            this.Controls.Add(this.btnXoaKhoiDS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemVaoDanhSach);
            this.Controls.Add(this.dtpNgayKham);
            this.Controls.Add(this.tbxHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fThemBenhNhanVaoDanhSachKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách khám";
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachKham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Button btnThemVaoDanhSach;
        private System.Windows.Forms.DataGridView grvDanhSachKham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.Button btnXoaKhoiDS;
        private System.Windows.Forms.TextBox tbxMaBenhNhan;
    }
}