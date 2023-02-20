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
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace đồ_án
{
    public partial class CTPXuat : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PK4QUC28;Initial Catalog=OKONO;User ID=sa;Password=123456");
        public CTPXuat()
        {
            InitializeComponent();
        }

        private void CTPXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oKONODataSet.CTPXuat' table. You can move, or remove it, as needed.
            this.cTPXuatTableAdapter.Fill(this.oKONODataSet.CTPXuat);
            // TODO: This line of code loads data into the 'oKONODataSet.Hang' table. You can move, or remove it, as needed.
            this.hangTableAdapter.Fill(this.oKONODataSet.Hang);
            HienThi();
        }
        public void HienThi()
        {
            con.Open();
            String sqlSelect = @"SELECT MaCTPX,SoLuongXuat,DonGiaXuat,Thue,ThanhTien,MaPhieuXuat,TenHang   
                            FROM CTPXuat 
                            INNER JOIN Hang ON CTPXuat.MaHang = Hang.MaHang 
                            WHERE MaPhieuXuat = '" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_CTPXuat.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlThem = @"INSERT INTO CTPXuat (MaCTPX,SoLuongXuat,DonGiaXuat,Thue,ThanhTien,MaHang,MaPhieuXuat) 
                              VALUES (@MaCTPX,@SoLuongXuat, @DonGiaXuat,@Thue,@ThanhTien,@MaHang,@MaPhieuXuat)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            // float i = float.Parse(numericUpDown1.Text.ToString());
            float x = (txt_dg.Text != null && !string.IsNullOrWhiteSpace(txt_dg.Text)) ?
            float.Parse(txt_dg.Text) : 0;
            int y = (txt_sl.Text != null && !string.IsNullOrWhiteSpace(txt_sl.Text)) ?
            int.Parse(txt_sl.Text) : 0;
            float z = (txt_tt.Text != null && !string.IsNullOrWhiteSpace(txt_tt.Text)) ?
            float.Parse(txt_tt.Text) : 0;
            cmd.Parameters.AddWithValue("MaCTPX", txt_mactpx.Text);
            cmd.Parameters.AddWithValue("SoLuongXuat", y);
            cmd.Parameters.AddWithValue("DonGiaXuat", x);
           // cmd.Parameters.AddWithValue("Thue", i);
            cmd.Parameters.AddWithValue("ThanhTien", z);
            //  cmd.Parameters.AddWithValue("MaHang", txt_mah.SelectedItem.ToString());
            DataRowView drv = (DataRowView)txt_mah.SelectedItem;
            cmd.Parameters.AddWithValue("MaHang", int.Parse(drv["MaHang"].ToString()));
            cmd.Parameters.AddWithValue("MaPhieuXuat", comboBox1.Text);
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
            string sqlSua = "UPDATE CTPXuat SET SoLuongXuat=@SoLuongXuat,DonGiaXuat=@DonGiaXuat, Thue=@Thue WHERE MaCTPX=@MaCTPX";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
         //   float i = float.Parse(numericUpDown1.Text.ToString());
            float x = float.Parse(txt_dg.Text.ToString());
            int y = int.Parse(txt_sl.Text.ToString());
            cmd.Parameters.AddWithValue("MaCTPX", txt_mactpx.Text);
            cmd.Parameters.AddWithValue("SoLuongXuat", y);
            cmd.Parameters.AddWithValue("DonGiaXuat", x);

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
            string sqlXoa = "DELETE FROM CTPXuat WHERE MaCTPX=@MaCTPX";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
           // float i = float.Parse(numericUpDown1.Text.ToString());
            float x = float.Parse(txt_dg.Text.ToString());
            int y = int.Parse(txt_sl.Text.ToString());
            cmd.Parameters.AddWithValue("MaCTPX", txt_mactpx.Text);
            cmd.Parameters.AddWithValue("SoLuongXuat", y);
            cmd.Parameters.AddWithValue("DonGiaXuat", x);
            //cmd.Parameters.AddWithValue("Thue", i);
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
        private void clear()
        {
            txt_mactpx.Text = "";
            txt_sl.Text = "";
            txt_dg.Text = "";
           // numericUpDown1.Text = "";
            txt_mah.Text = "";
            txt_tt.Text = "";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM CTPXuat WHERE MaCTPX like'%" + txtTimKiem.Text.Trim() + "%';";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlCommand dataAdapter = new SqlCommand(sqlSearch, con);
            DataTable dtbTimKiem = new DataTable();
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_CTPXuat.DataSource = dt;
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

        private void dgv_CTPXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong != -1)
            {
                comboBox1.Text = dgv_CTPXuat.Rows[dong].Cells[5].Value.ToString();
                txt_sl.Value = int.Parse(dgv_CTPXuat.Rows[dong].Cells[1].Value.ToString());
                txt_mactpx.Text = dgv_CTPXuat.Rows[dong].Cells[0].Value.ToString();
                txt_dg.Text = dgv_CTPXuat.Rows[dong].Cells[2].Value.ToString();
                txt_mah.Text = dgv_CTPXuat.Rows[dong].Cells[6].Value.ToString();
                numericUpDown1.Text = dgv_CTPXuat.Rows[dong].Cells[3].Value.ToString();
                txt_tt.Text = dgv_CTPXuat.Rows[dong].Cells[4].Value.ToString();
                tabControl1.SelectedIndex = 0;
            }
        }
        private void tinhtt()
        {
            //int sl = int.Parse(txt_sl.Text.ToString());
            int sl = (txt_sl.Text != null && !string.IsNullOrWhiteSpace(txt_sl.Text)) ?
            int.Parse(txt_sl.Text) : 0;
            float dg = (txt_dg != null && !string.IsNullOrWhiteSpace(txt_dg.Text)) ?
            float.Parse(txt_dg.Text) : 0;
            float t1 = dg * sl;
          //  float t2 = t1 * (10 / 100);
            txt_tt.Text = t1.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi();
            clear();
            tabControl1.SelectedIndex = 1;
        }

        private void txt_tt_TextChanged(object sender, EventArgs e)
        {
            tinhtt();
        }

        private void txt_sl_ValueChanged(object sender, EventArgs e)
        {
            tinhtt();
        }
    }
}
