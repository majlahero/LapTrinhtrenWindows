namespace WinFormsApp
{
    partial class FGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGiaoVien));
            btnLoad = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            date = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtCMND = new TextBox();
            txtTen = new TextBox();
            lblNgaySinh = new Label();
            lblTen = new Label();
            lblCMND = new Label();
            lblDiaChi = new Label();
            DataGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGV).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(487, 54);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 25;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(328, 270);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(200, 270);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 23;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(54, 270);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 22;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click_1;
            // 
            // date
            // 
            date.Location = new Point(162, 186);
            date.Name = "date";
            date.Size = new Size(241, 23);
            date.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(162, 103);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(241, 23);
            txtDiaChi.TabIndex = 20;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(162, 150);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(241, 23);
            txtCMND.TabIndex = 19;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(162, 59);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(241, 23);
            txtTen.TabIndex = 18;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(28, 192);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(127, 15);
            lblNgaySinh.TabIndex = 17;
            lblNgaySinh.Text = "Ngay Thang Nam Sinh";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(28, 62);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(60, 15);
            lblTen.TabIndex = 16;
            lblTen.Text = "Ho va Ten";
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Location = new Point(28, 153);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(43, 15);
            lblCMND.TabIndex = 15;
            lblCMND.Text = "CMND";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(28, 106);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(45, 15);
            lblDiaChi.TabIndex = 14;
            lblDiaChi.Text = "Dia Chi";
            // 
            // DataGV
            // 
            DataGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGV.Location = new Point(596, 40);
            DataGV.Name = "DataGV";
            DataGV.Size = new Size(441, 370);
            DataGV.TabIndex = 13;
            // 
            // FGiaoVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1064, 450);
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
            Controls.Add(DataGV);
            Name = "FGiaoVien";
            Text = "FGiaoVien";
            Load += FGiaoVien_Load;
            ((System.ComponentModel.ISupportInitialize)DataGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DateTimePicker date;
        private TextBox txtDiaChi;
        private TextBox txtCMND;
        private TextBox txtTen;
        private Label lblNgaySinh;
        private Label lblTen;
        private Label lblCMND;
        private Label lblDiaChi;
        private DataGridView DataGV;
    }
}