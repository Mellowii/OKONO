using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace đồ_án
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
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

        private void btnNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap NCC = new NhaCungCap();
            NCC.ShowDialog();
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            Hang qlh = new Hang();
            qlh.ShowDialog();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            KhachHangcs kh = new KhachHangcs();
            kh.ShowDialog();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PhieuXuat px = new PhieuXuat();
            px.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaoCaoNhapHang tk = new BaoCaoNhapHang();
            tk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            BaoCaoDoanhThu tk = new BaoCaoDoanhThu();
            tk.ShowDialog();
        }
    }
}
