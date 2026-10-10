namespace bt_10_10_1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtXacNhanMatKhau = new TextBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            chkDieuKhoan = new CheckBox();
            btnDangKy = new Button();
            btnLamMoi = new Button();
            epCheck = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtXacNhanMatKhau);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 172);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Location = new Point(164, 114);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.Size = new Size(241, 27);
            txtXacNhanMatKhau.TabIndex = 5;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(164, 75);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(241, 27);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(164, 38);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(241, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 117);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 3;
            label3.Text = "Xác nhận mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoNu);
            groupBox2.Controls.Add(rdoNam);
            groupBox2.Controls.Add(dtpNgaySinh);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(483, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 172);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin bổ sung";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(227, 78);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 4;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Location = new Point(89, 78);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 3;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(89, 36);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(117, 27);
            dtpNgaySinh.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 78);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 1;
            label5.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 41);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh:";
            // 
            // chkDieuKhoan
            // 
            chkDieuKhoan.AutoSize = true;
            chkDieuKhoan.Location = new Point(273, 190);
            chkDieuKhoan.Name = "chkDieuKhoan";
            chkDieuKhoan.Size = new Size(253, 24);
            chkDieuKhoan.TabIndex = 3;
            chkDieuKhoan.Text = "Tôi đồng ý với điều khoản dịch vụ";
            chkDieuKhoan.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(273, 236);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 4;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(432, 236);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDangKy);
            Controls.Add(chkDieuKhoan);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký Tài Khoản";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtXacNhanMatKhau;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private DateTimePicker dtpNgaySinh;
        private Label label5;
        private Label label4;
        private CheckBox chkDieuKhoan;
        private Button btnDangKy;
        private Button btnLamMoi;
        private ErrorProvider epCheck;
    }
}
