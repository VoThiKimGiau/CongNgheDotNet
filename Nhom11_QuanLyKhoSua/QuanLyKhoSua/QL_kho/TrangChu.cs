using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_kho
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhaCungCap f = new NhaCungCap();
            f.Show();
        }

        private void btDanhMucSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhMucSP f = new DanhMucSP();
            f.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham f = new SanPham();
            f.Show();
        }

        private void btnPhieu_Click(object sender, EventArgs e)
        {
            frmPhieu f = new frmPhieu();
            f.Show();
            this.Hide();
        }

        private void TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnCTP_Click(object sender, EventArgs e)
        {
            frmChiTiet f = new frmChiTiet();
            f.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TimKiem f = new TimKiem();
            f.Show();
            this.Hide();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            ThongTinSP f = new ThongTinSP();
            f.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Hide();
        }
    }
}
