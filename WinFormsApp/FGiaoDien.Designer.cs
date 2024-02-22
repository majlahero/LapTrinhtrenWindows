namespace WinFormsApp
{
    partial class FGiaoDien
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
            btnGiaoVien = new Button();
            btnHocSinh = new Button();
            SuspendLayout();
            // 
            // btnGiaoVien
            // 
            btnGiaoVien.BackgroundImage = Properties.Resources.background1;
            btnGiaoVien.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGiaoVien.Location = new Point(50, 65);
            btnGiaoVien.Name = "btnGiaoVien";
            btnGiaoVien.Size = new Size(241, 315);
            btnGiaoVien.TabIndex = 0;
            btnGiaoVien.Text = "Giao Vien";
            btnGiaoVien.UseVisualStyleBackColor = true;
            btnGiaoVien.Click += btnGiaoVien_Click_1;
            // 
            // btnHocSinh
            // 
            btnHocSinh.BackgroundImage = Properties.Resources.backgroup41;
            btnHocSinh.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHocSinh.Location = new Point(455, 65);
            btnHocSinh.Name = "btnHocSinh";
            btnHocSinh.Size = new Size(241, 315);
            btnHocSinh.TabIndex = 1;
            btnHocSinh.Text = "Hoc Sinh";
            btnHocSinh.UseVisualStyleBackColor = true;
            btnHocSinh.Click += btnHocSinh_Click_1;
            // 
            // FGiaoDien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroup3;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHocSinh);
            Controls.Add(btnGiaoVien);
            Name = "FGiaoDien";
            Text = "FGiaoDien";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGiaoVien;
        private Button btnHocSinh;
    }
}