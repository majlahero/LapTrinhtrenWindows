using System.Data.SqlClient;

namespace WinFormsApp
{
    partial class FHocSinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Data = new DataGridView();
            lblDiaChi = new Label();
            lblCMND = new Label();
            lblTen = new Label();
            lblNgaySinh = new Label();
            txtTen = new TextBox();
            txtCMND = new TextBox();
            txtDiaChi = new TextBox();
            date = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)Data).BeginInit();
            SuspendLayout();
            // 
            // Data
            // 
            Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data.Location = new Point(580, 12);
            Data.Name = "Data";
            Data.Size = new Size(441, 370);
            Data.TabIndex = 0;
            Data.CellContentClick += Data_CellContentClick;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(12, 78);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(45, 15);
            lblDiaChi.TabIndex = 1;
            lblDiaChi.Text = "Dia Chi";
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Location = new Point(12, 125);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(43, 15);
            lblCMND.TabIndex = 2;
            lblCMND.Text = "CMND";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(12, 34);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(60, 15);
            lblTen.TabIndex = 3;
            lblTen.Text = "Ho va Ten";
            lblTen.Click += label3_Click;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(12, 166);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(127, 15);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngay Thang Nam Sinh";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(146, 31);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(241, 23);
            txtTen.TabIndex = 5;
            txtTen.TextChanged += textBox1_TextChanged;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(145, 122);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(241, 23);
            txtCMND.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(145, 75);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(241, 23);
            txtDiaChi.TabIndex = 7;
            // 
            // date
            // 
            date.Location = new Point(145, 160);
            date.Name = "date";
            date.Size = new Size(241, 23);
            date.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(38, 242);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(184, 242);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(312, 242);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(471, 26);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // FHocSinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroup4;
            ClientSize = new Size(1148, 464);
            Controls.Add(btnLoad);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(date);
            Controls.Add(txtDiaChi);
            Controls.Add(txtCMND);
            Controls.Add(txtTen);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblTen);
            Controls.Add(lblCMND);
            Controls.Add(lblDiaChi);
            Controls.Add(Data);
            Name = "FHocSinh";
            Text = "FHocSinh";
            Load += FLogin_Load;
            ((System.ComponentModel.ISupportInitialize)Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Data;
        private Label lblDiaChi;
        private Label lblCMND;
        private Label lblTen;
        private Label lblNgaySinh;
        private TextBox txtTen;
        private TextBox txtCMND;
        private TextBox txtDiaChi;
        private DateTimePicker date;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLoad;

        

    }
}
