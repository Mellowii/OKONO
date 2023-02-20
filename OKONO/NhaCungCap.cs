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
    public partial class NhaCungCap : Form
    {
        SqlConnection con;
        public NhaCungCap()
        {
            InitializeComponent();
        }
     
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-PK4QUC28;Initial Catalog=OKONO;User ID=sa;Password=123456");
            con.Open();
            HienThi();
        }
        public void HienThi()
        {
            string sqlSelect = "SELECT * FROM NhaCungCap";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlncc.DataSource = dt;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NhaCungCap_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlThem= "INSERT INTO NhaCungCap VALUES (@MaNCC, @TenNCC, @DiaChi, @SDT, @Email)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            cmd.Parameters.AddWithValue("MaNCC", txt_mancc.Text);
            cmd.Parameters.AddWithValue("TenNCC", txt_tenncc.Text);
            cmd.Parameters.AddWithValue("DiaChi", txt_dcncc.Text);
            cmd.Parameters.AddWithValue("SDT", txt_sdtncc.Text);
            cmd.Parameters.AddWithValue("Email", txt_email.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlXoa = "DELETE FROM NhaCungCap WHERE MaNCC=@MaNCC";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            cmd.Parameters.AddWithValue("MaNCC", txt_mancc.Text);
            cmd.Parameters.AddWithValue("TenNCC", txt_tenncc.Text);
            cmd.Parameters.AddWithValue("DiaChi", txt_dcncc.Text);
            cmd.Parameters.AddWithValue("SDT", txt_sdtncc.Text);
            cmd.Parameters.AddWithValue("Email", txt_email.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlSua = "UPDATE NhaCungCap SET TenNCC=@TenNCC, DiaChi=@DiaChi, SDT=@SDT, Email=@Email WHERE MaNCC=@MaNCC";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            cmd.Parameters.AddWithValue("MaNCC", txt_mancc.Text);
            cmd.Parameters.AddWithValue("TenNCC", txt_tenncc.Text);
            cmd.Parameters.AddWithValue("DiaChi", txt_dcncc.Text);
            cmd.Parameters.AddWithValue("SDT", txt_sdtncc.Text);
            cmd.Parameters.AddWithValue("Email", txt_email.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM NhaCungCap WHERE MaNCC like'%" + txtTimKiem.Text.Trim() + "%';";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlCommand dataAdapter = new SqlCommand(sqlSearch, con);
            DataTable dtbTimKiem = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_qlncc.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_mancc.Text = "";
            txt_tenncc.Text = "";
            txt_dcncc.Text = "";
            txt_sdtncc.Text = "";
            txt_email.Text = "";

        }

        private void dgv_qlncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e. RowIndex; 
            if (dong != -1)
            {
                txt_mancc.Text = dgv_qlncc.Rows[dong].Cells[0].Value.ToString();
                txt_tenncc.Text = dgv_qlncc.Rows[dong].Cells[1].Value.ToString();
                txt_dcncc.Text = dgv_qlncc.Rows[dong].Cells[2].Value.ToString();
                txt_sdtncc.Text = dgv_qlncc.Rows[dong].Cells[3].Value.ToString();
                txt_email.Text = dgv_qlncc.Rows[dong].Cells[4].Value.ToString();
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
