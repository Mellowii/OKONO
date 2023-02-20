using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace đồ_án
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void ĐăngNhập_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string con_str = @"Data Source=LAPTOP-PK4QUC28;Initial Catalog=OKONO;User ID=sa;Password=123456";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();

                string TaiKhoan = txtTaiKhoan.Text;
                string MatKhau = txtMatKhau.Text;
                string query = "select count(*) from DangNhap where TaiKhoan = @tk and MatKhau = @mk";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", TaiKhoan));
                cmd.Parameters.Add(new SqlParameter("@mk", MatKhau));
                int soluong = (int)cmd.ExecuteScalar();

                conn.Close();

                if (soluong == 1)
                {
                    MessageBox.Show("Đăng nhập thành công !");
                    this.DialogResult = DialogResult.OK;
                    TrangChu tc = new TrangChu();
                    tc.ShowDialog();
      
                }
                else
                {
                    MessageBox.Show("Tài khoản mật khẩu không chính xác");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            Application.Exit();
        }
    }
}

