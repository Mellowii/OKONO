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
    public partial class NhanVien : Form
    {
        SqlConnection con;
        public NhanVien()
        {
            InitializeComponent();


        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-PK4QUC28;Initial Catalog=OKONO;User ID=sa;Password=123456");
            con.Open();
            HienThi();
        }
        public void HienThi()
        {
            string sqlSelect = "SELECT * FROM NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlnv.DataSource = dt;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlThem = "INSERT INTO NhanVien VALUES (@MaNV, @TenNV, @NgaySinh,@GioiTinh, @SDT, @DiaChi,@Images)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            cmd.Parameters.AddWithValue("TenNV", txt_tennv.Text);
            cmd.Parameters.Add("NgaySinh", SqlDbType.Date).Value=txt_ns.Value.Date;
            cmd.Parameters.AddWithValue("GioiTinh", comboBox1.Text);
            cmd.Parameters.AddWithValue("SDT", txt_sdtnv.Text);
            cmd.Parameters.AddWithValue("DiaChi", txt_dcnv.Text);
            cmd.Parameters.AddWithValue("Images", pictureBox1.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM NhanVien WHERE MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            cmd.Parameters.AddWithValue("TenNV", txt_tennv.Text);
            cmd.Parameters.AddWithValue("NgaySinh", txt_ns.Text);
            cmd.Parameters.AddWithValue("GioiTinh", comboBox1.Text);
            cmd.Parameters.AddWithValue("SDT", txt_sdtnv.Text);
            cmd.Parameters.AddWithValue("DiaChi", txt_dcnv.Text);
            cmd.Parameters.AddWithValue("Images", pictureBox1.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE NhanVien SET TenNV=@TenNV, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh,SDT=@SDT,DiaChi=@DiaChi,@Images=Images WHERE MaNV=@MaNV";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
            cmd.Parameters.AddWithValue("TenNV", txt_tennv.Text);
            cmd.Parameters.Add("NgaySinh", SqlDbType.Date).Value = txt_ns.Value.Date;
            cmd.Parameters.AddWithValue("GioiTinh", comboBox1.Text);
            cmd.Parameters.AddWithValue("SDT", txt_sdtnv.Text);
            cmd.Parameters.AddWithValue("DiaChi", txt_dcnv.Text);
            cmd.Parameters.AddWithValue("Images", pictureBox1.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_ns.Text = "";
            comboBox1.Text = "";
            txt_sdtnv.Text = "";
            txt_dcnv.Text = "";
            pictureBox1.Text = "";
           
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM NhanVien WHERE MaNV like'%" + txtTimKiem.Text.Trim() + "%';";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlCommand dataAdapter = new SqlCommand(sqlSearch, con);
            DataTable dtbTimKiem = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlnv.DataSource = dt;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_qlncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_qlnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong != -1)
            {
                txt_manv.Text = dgv_qlnv.Rows[dong].Cells[0].Value.ToString();
                txt_tennv.Text = dgv_qlnv.Rows[dong].Cells[1].Value.ToString();
                txt_ns.Text = dgv_qlnv.Rows[dong].Cells[2].Value.ToString();
                comboBox1.Text = dgv_qlnv.Rows[dong].Cells[3].Value.ToString();
                txt_sdtnv.Text = dgv_qlnv.Rows[dong].Cells[4].Value.ToString();
                txt_dcnv.Text = dgv_qlnv.Rows[dong].Cells[5].Value.ToString();
               
              
            }
        }

        private void dgv_qlnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_gt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


   
        private void button_Click(object sender, EventArgs e)
        {

            string location = "D:\\Learn\\Donet\\đồ án\\Ảnh nhân viên";
            string path = Path.Combine(location, txt_tennv.Text + ".jpg");
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
