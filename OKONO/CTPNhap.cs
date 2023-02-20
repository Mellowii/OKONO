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
//using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;


namespace đồ_án
{
    public partial class CTPNhap : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-PK4QUC28;Initial Catalog=OKONO;User ID=sa;Password=123456");
        public CTPNhap()
        {
            InitializeComponent();
    //        con = new SqlConnection(@"Data Source=DESKTOP-O66AJE5;Initial Catalog=OKONO;User ID=sa;Password=123456");
      //      con.Open();

        }

   

        private void CTPNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oKONODataSet.Hang' table. You can move, or remove it, as needed.
            this.hangTableAdapter.Fill(this.oKONODataSet.Hang);
            // TODO: This line of code loads data into the 'oKONODataSet.CTPNhap' table. You can move, or remove it, as needed.
            this.cTPNhapTableAdapter.Fill(this.oKONODataSet.CTPNhap);
      //      con = new SqlConnection(@"Data Source=DESKTOP-O66AJE5;Initial Catalog=OKONO;User ID=sa;Password=123456");
       //     con.Open();
            HienThi();
       //     con.Close();

        }
        public void HienThi()
        {
            // string sqlSelect = "SELECT * FROM CTPNhap";
            con.Open();
            String sqlSelect = @"SELECT MaCTPN,SoLuongNhap,DonGiaNhap,Thue,ThanhTien,MaPhieuNhap,TenHang   
                            FROM CTPNhap  
                            INNER JOIN Hang ON CTPNhap.MaHang = Hang.MaHang 
                            WHERE MaPhieuNhap = '" + comboBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_CTPNhap.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlThem = @"INSERT INTO CTPNhap (MaCTPN,SoLuongNhap,DonGiaNhap,Thue,ThanhTien,MaHang,MaPhieuNhap) 
                                            VALUES (@MaCTPN,@SoLuongNhap,@DonGiaNhap,@Thue,@ThanhTien,@MaHang,@MaPhieuNhap)";
            SqlCommand cmd = new SqlCommand(sqlThem, con);
            float i = (numericUpDown1.Text != null && !string.IsNullOrWhiteSpace(numericUpDown1.Text)) ?
           float.Parse(numericUpDown1.Text) : 0;
            float x = (txt_dgn.Text != null && !string.IsNullOrWhiteSpace(txt_dgn.Text)) ?
           float.Parse(txt_dgn.Text) : 0;
            int y = (txt_sl.Text != null && !string.IsNullOrWhiteSpace(txt_sl.Text)) ?
           int.Parse(txt_sl.Text) : 0; 
           float z = (txt_tt.Text != null && !string.IsNullOrWhiteSpace(txt_tt.Text)) ?
           float.Parse(txt_tt.Text) : 0;
           cmd.Parameters.AddWithValue("MaCTPN", txt_mactpn.Text);
            cmd.Parameters.AddWithValue("SoLuongNhap", y);
            cmd.Parameters.AddWithValue("DonGiaNhap", x);
            cmd.Parameters.AddWithValue("Thue", i);
            cmd.Parameters.AddWithValue("ThanhTien", z);
            DataRowView drv = (DataRowView)txt_mah.SelectedItem;
            cmd.Parameters.AddWithValue("MaHang", int.Parse(drv["MaHang"].ToString()));
            cmd.Parameters.AddWithValue("MaPhieuNhap", comboBox1.Text);
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
            string sqlSua = "UPDATE CTPNhap SET SoLuongNhap=@SoLuongNhap,DonGiaNhap=@DonGiaNhap, Thue=@Thue,ThanhTien=@ThanhTien WHERE MaCTPN=@MaCTPN";
            SqlCommand cmd = new SqlCommand(sqlSua, con);
            float i = float.Parse(numericUpDown1.Text.ToString());
            float x = float.Parse(txt_dgn.Text.ToString());
            int y = int.Parse(txt_sl.Text.ToString());
            float z = (txt_tt.Text != null && !string.IsNullOrWhiteSpace(txt_tt.Text)) ?
            float.Parse(txt_tt.Text) : 0; ;
            cmd.Parameters.AddWithValue("MaCTPN", txt_mactpn.Text);
            cmd.Parameters.AddWithValue("SoLuongNhap", y);
            cmd.Parameters.AddWithValue("DonGiaNhap", x);
            cmd.Parameters.AddWithValue("Thue", i);
            cmd.Parameters.AddWithValue("ThanhTien", z);
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
            string sqlXoa = "DELETE FROM CTPNhap WHERE MaCTPN=@MaCTPN";
            SqlCommand cmd = new SqlCommand(sqlXoa, con);
            float i = float.Parse(numericUpDown1.Text.ToString());
            float x = float.Parse(txt_dgn.Text.ToString());
            int y = int.Parse(txt_sl.Text.ToString());
            cmd.Parameters.AddWithValue("MaCTPN", txt_mactpn.Text);
            cmd.Parameters.AddWithValue("SoLuongNhap", y);
            cmd.Parameters.AddWithValue("DonGiaNhap", x);
            cmd.Parameters.AddWithValue("Thue", i);
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

        private void clear ()
        {
            txt_mactpn.Text = "";
            txt_sl.Text = "";
            txt_dgn.Text = "";
            numericUpDown1.Text = "";
            txt_mah.Text = "";
            txt_tt.Text = "";
        }
   

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT * FROM CTPNhap WHERE MaCTPN like'%" + txtTimKiem.Text.Trim() + "%';";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlCommand dataAdapter = new SqlCommand(sqlSearch, con);
            DataTable dtbTimKiem = new DataTable();
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv_CTPNhap.DataSource = dt;
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

        private void dgv_CTPNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong != -1)
            {
                comboBox1.Text = dgv_CTPNhap.Rows[dong].Cells[5].Value.ToString();
                txt_sl.Value = int.Parse(dgv_CTPNhap.Rows[dong].Cells[1].Value.ToString());
                txt_mactpn.Text = dgv_CTPNhap.Rows[dong].Cells[0].Value.ToString().Trim();
                txt_dgn.Text = dgv_CTPNhap.Rows[dong].Cells[2].Value.ToString();
                txt_mah.Text = dgv_CTPNhap.Rows[dong].Cells[6].Value.ToString();
                numericUpDown1.Text = dgv_CTPNhap.Rows[dong].Cells[3].Value.ToString();
                txt_tt.Text = dgv_CTPNhap.Rows[dong].Cells[4].Value.ToString();
                tabControl1.SelectedIndex = 0;
                //   txt_mactpn.Text = dgv_CTPNhap.Rows[dong].Cells[0].Value.ToString();
                //    txt_sl.Text = dgv_CTPNhap.Rows[dong].Cells[9].Value.ToString();
                //txt_dg.Text = dgv_CTPNhap.Rows[dong].Cells[2].Value.ToString();
                //      numericUpDown1.Text = dgv_CTPNhap.Rows[dong].Cells[9].Value.ToString();
                //txt_tt.Text = dgv_CTPNhap.Rows[dong].Cells[4].Value.ToString();
                //  txt_mah.SelectedItem.ToString() = dgv_CTPNhap.Rows[dong].Cells[5].Value.ToString();
                //  comboBox1.Text = dgv_CTPNhap.Rows[dong].Cells[6].Value.ToString();
            }
          
        }
        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            HienThi();
            clear();
            tabControl1.SelectedIndex = 1;
        }
        //private void copyAlltoClipboard()
        //{
        //    dgv_CTPNhap.SelectAll();
        //    DataObject dataObj = dgv_CTPNhap.GetClipboardContent();
        //    if (dataObj != null)
        //        Clipboard.SetDataObject(dataObj);
        //}
        //private void button9_Click(object sender, EventArgs e)
        //{
        //    copyAlltoClipboard();
        //    Microsoft.Office.Interop.Excel.Application xlexcel;
        //    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        //    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        //    object misValue = System.Reflection.Missing.Value;
        //    xlexcel = new Microsoft.Office.Interop.Excel.Application();
        //    xlexcel.Visible = true;
        //    xlWorkBook = xlexcel.Workbooks.Add(misValue);
        //    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
        //    Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
        //    CR.Select();
        //    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        //}

        private void tinhtt ()
        {
            int sl = (txt_sl.Text != null && !string.IsNullOrWhiteSpace(txt_sl.Text)) ?
            int.Parse(txt_sl.Text) : 0;
            float dgn = (txt_dgn.Text != null && !string.IsNullOrWhiteSpace(txt_dgn.Text)) ?
            float.Parse(txt_dgn.Text) : 0;
            float thue = (numericUpDown1.Text != null && !string.IsNullOrWhiteSpace(numericUpDown1.Text)) ?
            float.Parse(numericUpDown1.Text) : 0;
            float t1 = sl * dgn + (sl * dgn)*thue;
            txt_tt.Text = t1.ToString();
        }
        private void numericUpDown1_TextChanged(object sender, EventArgs e)
        {
            tinhtt();
        }

        private void txt_dg_TextChanged(object sender, EventArgs e)
        {
            tinhtt();
        }
        private void txt_tt_TextChanged(object sender, EventArgs e)
        {
            tinhtt();
        }

        private void txt_sl_ValueChanged(object sender, EventArgs e)
        {
            tinhtt();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            TrangChu tc = new TrangChu();
            tc.ShowDialog();
        }
    }
}
