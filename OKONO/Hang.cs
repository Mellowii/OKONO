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
using System.IO;

namespace đồ_án
{
    public partial class Hang : Form
    {
        SqlConnection con;
        public Hang()
        {
            InitializeComponent();
        }

        private void txt_sl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Hang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-PK4QUC28;Initial Catalog=OKONO;User ID=sa;Password=123456");
            con.Open();
            HienThi();
        }
        public void HienThi()
        {
            string sqlSelect = "SELECT * FROM Hang";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlh.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO Hang VALUES (@TenHang, @LoaiHang,@SoLuong, @DonGia,@HinhAnh)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);   
            cmd.Parameters.AddWithValue("TenHang", txt_tenh.Text);
            cmd.Parameters.AddWithValue("LoaiHang", comboBox1.Text);
            cmd.Parameters.AddWithValue("SoLuong", txt_sl.Text);
            cmd.Parameters.AddWithValue("DonGia", txt_dg.Text);
            cmd.Parameters.AddWithValue("HinhAnh", pictureBox1.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE Hang SET TenHang=@TenHang, LoaiHang=@LoaiHang,SoLuong=@SoLuong,DonGia=@DonGia,@HinhAnh=HinhAnh WHERE MaHang=@MaHang";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaHang", txt_mah.Text);
            cmd.Parameters.AddWithValue("TenHang", txt_tenh.Text);
            cmd.Parameters.AddWithValue("LoaiHang", comboBox1.Text);
            cmd.Parameters.AddWithValue("SoLuong", txt_sl.Text);
            cmd.Parameters.AddWithValue("DonGia", txt_dg.Text);
            cmd.Parameters.AddWithValue("HinhAnh", pictureBox1.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM Hang WHERE MaHang=@MaHang";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaHang", txt_mah.Text);
            cmd.Parameters.AddWithValue("TenHang", txt_tenh.Text);
            cmd.Parameters.AddWithValue("LoaiHang", comboBox1.Text);
            cmd.Parameters.AddWithValue("SoLuong", txt_sl.Text);
            cmd.Parameters.AddWithValue("DonGia", txt_dg.Text);
            cmd.Parameters.AddWithValue("HinhAnh", pictureBox1.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_mah.Text = "";
            txt_tenh.Text = "";
            comboBox1.Text = "";
            txt_sl.Text = "";
            txt_dg.Text = "";
            pictureBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM Hang WHERE MaHang like'%" + txtTimKiem.Text.Trim() + "%';";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlCommand dataAdapter = new SqlCommand(sqlSearch, con);
            DataTable dtbTimKiem = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlh.DataSource = dt;
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

        private void dgv_qlh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong != -1)
            {
                txt_mah.Text = dgv_qlh.Rows[dong].Cells[0].Value.ToString();
                txt_tenh.Text = dgv_qlh.Rows[dong].Cells[1].Value.ToString();
                comboBox1.Text = dgv_qlh.Rows[dong].Cells[2].Value.ToString();
                txt_sl.Text = dgv_qlh.Rows[dong].Cells[3].Value.ToString();
                txt_dg.Text = dgv_qlh.Rows[dong].Cells[4].Value.ToString();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string location = "D:\\Learn\\Donet\\đồ án\\ảnh về hàng";
            string path = Path.Combine(location, txt_tenh.Text + ".jpg");
            MessageBox.Show("Thêm ảnh thành công");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;*jpeg;*.png) | *.jpg;*jpeg;*.png ";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            TrangChu tc = new TrangChu();
            tc.ShowDialog();
        }
    }
}
