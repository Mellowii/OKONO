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
    public partial class KhachHangcs : Form
    {
        SqlConnection con;
        public KhachHangcs()
        {
            InitializeComponent();
        }

        private void KhachHangcs_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-PK4QUC28;Initial Catalog=OKONO;User ID=sa;Password=123456");
            con.Open();
            HienThi();
        }
        public void HienThi()
        {
            string sqlSelect = "SELECT * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlkh.DataSource = dt;
        }

        private void KhachHangcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO KhachHang VALUES (@MaKH, @TenKH, @DiaChi, @SDT, @Email)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("MaKH", txt_makh.Text);
            cmd.Parameters.AddWithValue("TenKH", txt_tenkh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txt_dckh.Text);
            cmd.Parameters.AddWithValue("SDT", txt_sdtkh.Text);
            cmd.Parameters.AddWithValue("Email", txt_email.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM KhachHang WHERE MaKH=@MaKH";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaKH", txt_makh.Text);
            cmd.Parameters.AddWithValue("TenKH", txt_tenkh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txt_dckh.Text);
            cmd.Parameters.AddWithValue("SDT", txt_sdtkh.Text);
            cmd.Parameters.AddWithValue("Email", txt_email.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE KhachHang  SET TenKH=@TenKH, DiaChi=@DiaChi, SDT=@SDT, Email=@Email WHERE MaKH=@MaKH";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaKH", txt_makh.Text);
            cmd.Parameters.AddWithValue("TenKH", txt_tenkh.Text);
            cmd.Parameters.AddWithValue("DiaChi", txt_dckh.Text);
            cmd.Parameters.AddWithValue("SDT", txt_sdtkh.Text);
            cmd.Parameters.AddWithValue("Email", txt_email.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_dckh.Text = "";
            txt_sdtkh.Text = "";
            txt_email.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM KhachHang WHERE MaKH like'%" + txtTimKiem.Text.Trim() + "%';";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlCommand dataAdapter = new SqlCommand(sqlSearch, con);
            DataTable dtbTimKiem = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlkh.DataSource = dt;
        }

        private void dgv_qlkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong != -1)
            {
                txt_makh.Text = dgv_qlkh.Rows[dong].Cells[0].Value.ToString();
                txt_tenkh.Text = dgv_qlkh.Rows[dong].Cells[1].Value.ToString();
                txt_dckh.Text = dgv_qlkh.Rows[dong].Cells[2].Value.ToString();
                txt_sdtkh.Text = dgv_qlkh.Rows[dong].Cells[3].Value.ToString();
                txt_email.Text = dgv_qlkh.Rows[dong].Cells[4].Value.ToString();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("THÔNG BÁO", "BẠN MUỐN ĐÓNG FORM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // đóng form
                this.Close();
            }
            else
            {
                //xử lí khác
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
        }
    }
}

