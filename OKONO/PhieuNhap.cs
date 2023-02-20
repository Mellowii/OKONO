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
    public partial class PhieuNhap : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PK4QUC28;Initial Catalog=OKONO;User ID=sa;Password=123456");
        public PhieuNhap()
        {
            InitializeComponent();
        }
        public void HienThi()
        {
            con.Open();
            String sqlSelect = @"SELECT PhieuNhap.MaPhieuNhap, NgayNhap,MaNCC,MaNV, TongTien
                               FROM PhieuNhap, (SELECT PhieuNhap.MaPhieuNhap, sum(ThanhTien) as TongTien  
                               FROM PhieuNhap 
                               INNER JOIN CTPNhap ON PhieuNhap.MaPhieuNhap=CTPNhap.MaPhieuNhap 	
                               Group By PhieuNhap.MaPhieuNhap) as BTG
                               where PhieuNhap.MaPhieuNhap = BTG.MaPhieuNhap";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlpn.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO PhieuNhap VALUES (@MaPhieuNhap,@NgayNhap,@MaNCC,@MaNV)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("MaPhieuNhap", txt_mapn.Text);
            cmd.Parameters.AddWithValue("NgayNhap", txt_ngaynhap.Text);
            cmd.Parameters.AddWithValue("MaNCC", txt_mancc.Text);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Generated. Details: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM PhieuNhap WHERE MaPhieuNhap=@MaPhieuNhap";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaPhieuNhap", txt_mapn.Text);
            cmd.Parameters.AddWithValue("NgayNhap", txt_ngaynhap.Text);
            cmd.Parameters.AddWithValue("MaNCC", txt_mancc.Text);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Generated. Details: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE PhieuNhap SET NgayNhap=@NgayNhap, MaNCC=@MaNCC, MaNV=@MaNV WHERE MaMaPhieuNha=@MaMaPhieuNhap";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaPhieuNhap", txt_mapn.Text);
            cmd.Parameters.AddWithValue("NgayNhap", txt_ngaynhap.Text);
            cmd.Parameters.AddWithValue("MaNCC", txt_mancc.Text);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Generated. Details: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_mapn.Text = "";
            txt_ngaynhap.Text = "";
            txt_mancc.Text = "";
            txt_manv.Text = "";
            txt_ttien.Text = "";
        }
        private void dgv_qlpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int dong = e.RowIndex;
            if (dong != -1)
            {
                txt_mapn.Text =dgv_qlpn.Rows[dong].Cells[0].Value.ToString();
                txt_ngaynhap.Text =dgv_qlpn.Rows[dong].Cells[1].Value.ToString();
                txt_mancc.Text =dgv_qlpn.Rows[dong].Cells[2].Value.ToString();
                txt_manv.Text =dgv_qlpn.Rows[dong].Cells[3].Value.ToString();
                txt_ttien.Text =dgv_qlpn.Rows[dong].Cells[4].Value.ToString();
                //int sc = dgv_qlpn.Rows.Count;
                //float thanhtien = 0;
                //for (int i = 0; i < sc - 1; i++)
                //    thanhtien += float.Parse(dgv_qlpn.Rows[i].Cells["ThanhTien"].Value.ToString());
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

        private void button8_Click(object sender, EventArgs e)
        {
            CTPNhap ctiet = new CTPNhap();
            ctiet.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM PhieuNhap WHERE MaPhieuNhap like'%" + txtTimKiem.Text.Trim() + "%';";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlCommand dataAdapter = new SqlCommand(sqlSearch, con);
            DataTable dtbTimKiem = new DataTable();
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_qlpn.DataSource = dt;
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error Generated. Details: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            HienThi();
        }
       private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.ShowDialog();
        }
    }
}
