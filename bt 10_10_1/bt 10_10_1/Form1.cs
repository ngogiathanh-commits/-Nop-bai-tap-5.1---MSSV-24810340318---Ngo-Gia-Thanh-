namespace bt_10_10_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            epCheck.Clear();

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                epCheck.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                epCheck.SetError(txtMatKhau, "Mật khẩu không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text))
            {
                epCheck.SetError(txtXacNhanMatKhau, "Vui lòng nhập lại mật khẩu!");
                isValid = false;
            }
            else if (txtXacNhanMatKhau.Text != txtMatKhau.Text)
            {
                epCheck.SetError(txtXacNhanMatKhau, "Mật khẩu xác nhận không trùng khớp!");
                isValid = false;
            }

            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            DateTime ngayHienTai = DateTime.Today;

            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            if (ngaySinh > ngayHienTai.AddYears(-tuoi))
            {
                tuoi--; // Điều chỉnh nếu chưa đến ngày sinh trong năm hiện tại
            }

            if (tuoi < 18)
            {
                epCheck.SetError(dtpNgaySinh, "Bạn phải từ 18 tuổi trở lên để đăng ký!");
                isValid = false;
            }

            if (!chkDieuKhoan.Checked)
            {
                epCheck.SetError(chkDieuKhoan, "Bạn phải đồng ý với điều khoản dịch vụ!");
                isValid = false;
            }

            if (isValid)
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();

            dtpNgaySinh.Value = DateTime.Now;

            rdoNam.Checked = true;
            rdoNu.Checked = false;
            chkDieuKhoan.Checked = false;

            epCheck.Clear();

            txtTenDangNhap.Focus();
        }
    }
}
