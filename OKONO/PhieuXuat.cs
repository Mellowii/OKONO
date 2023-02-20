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
    public partial class PhieuXuat : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PK4QUC28;Initial Catalog=OKONO;User ID=sa;Password=123456");
        public PhieuXuat()
        {
            InitializeComponent();
        }

        private void PhieuXuat_Load(object sender, EventArgs e)
        {
           
        
            HienThi();
        }
        public void HienThi()
        {
            con.Open();
            String sqlSelect = @"SELECT PhieuXuat.MaPhieuXuat, NgayXuat,MaKH,MaNV, TongTien
                               FROM PhieuXuat, (SELECT PhieuXuat.MaPhieuXuat, sum(ThanhTien) as TongTien  
                               FROM PhieuXuat 
                               INNER JOIN CTPXuat ON PhieuXuat.MaPhieuXuat=CTPXuat.MaPhieuXuat 	
                               Group By PhieuXuat.MaPhieuXuat) as BTG
                               where PhieuXuat.MaPhieuXuat = BTG.MaPhieuXuat";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlpx.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO PhieuXuat VALUES (@MaPhieuXuat,@NgayXuat,@MaKH,@MaNV)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("MaPhieuXuat", txt_mapx.Text);
            cmd.Parameters.AddWithValue("NgayXuat", txt_ngayxuat.Text);
            cmd.Parameters.AddWithValue("MaKH", txt_makh.Text);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM PhieuXuat WHERE MaPhieuXuat=@MaPhieuXuat";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaPhieuXuat", txt_mapx.Text);
            cmd.Parameters.AddWithValue("Ngayxuat", txt_ngayxuat.Text);
            cmd.Parameters.AddWithValue("MaKH", txt_makh.Text);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE PhieuXuat SET NgayXuat=@NgayXuat, MaKH=@MaKH, MaNV=@MaNV WHERE MaPhieuXuat=@MaPhieuXuat";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaPhieuXuat", txt_mapx.Text);
            cmd.Parameters.AddWithValue("Ngayxuat", txt_ngayxuat.Text);
            cmd.Parameters.AddWithValue("MaKH", txt_makh.Text);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            txt_mapx.Text = "";
            txt_ngayxuat.Text = "";
            txt_makh.Text = "";
            txt_manv.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CTPXuat ctiet = new CTPXuat();
            ctiet.ShowDialog();
        }

        private void dgv_qlpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong != -1)

            {
                txt_mapx.Text = dgv_qlpx.Rows[dong].Cells[0].Value.ToString();
                txt_ngayxuat.Text = dgv_qlpx.Rows[dong].Cells[1].Value.ToString();
                txt_makh.Text = dgv_qlpx.Rows[dong].Cells[2].Value.ToString();
                txt_manv.Text = dgv_qlpx.Rows[dong].Cells[3].Value.ToString();
                txt_ttien.Text = dgv_qlpx.Rows[dong].Cells[4].Value.ToString();
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

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM PhieuXuat WHERE MaPhieuXuat like'%" + txtTimKiem.Text.Trim() + "%';";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlCommand dataAdapter = new SqlCommand(sqlSearch, con);
            DataTable dtbTimKiem = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlpx.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
        }
    }
}
