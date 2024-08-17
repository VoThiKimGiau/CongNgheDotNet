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
    public partial class SanPham : Form
    {
        DBConnect Sconn = new DBConnect();
        DataTable DT_SanPham = new DataTable();   
        public SanPham()
        {
            InitializeComponent();
            string sql = "select * from SanPham";
            DT_SanPham = Sconn.getDatatable(sql, "SanPham").Tables["SanPham"];
            DataColumn[] key = new DataColumn[1];
            key[0] = DT_SanPham.Columns[0];
            DT_SanPham.PrimaryKey = key;
        }
        public void Load_GV_SanPham()
        {
            dataGVDV.DataSource = DT_SanPham;
        }
        public bool KiemTra(int temp)
        {
            foreach (DataRow dr in DT_SanPham.Rows)
            {
                string tmp1 = dr["MaSP"].ToString();
                if (int.Parse(tmp1.Substring(2)) == temp)
                {
                    return true;
                }
            }
            return false;
        }
        public void Load_cbb_NCC()
        {
            DataTable dt_ncc = Sconn.getDatatable("select * from NhaCungCap", "NhaCungCap").Tables["NhaCungCap"];
            cbb_NCC.DataSource = dt_ncc;
            cbb_NCC.DisplayMember = "TenNCC";
            cbb_NCC.ValueMember = "MaNCC";
        }
        public void Load_cbb_DM()
        {
            DataTable dt_dm = Sconn.getDatatable("select * from DanhMucSP", "DanhMucSP").Tables["DanhMucSP"];
            cbb_DM.DataSource = dt_dm;
            cbb_DM.DisplayMember = "TenDM";
            cbb_DM.ValueMember = "MaDM";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRow row = DT_SanPham.NewRow();
            for (int i = 1; i <= 1000; i++)
            {
                if (KiemTra(i) == false)
                {
                    row["MaSP"] = "SP" + i.ToString();
                    break;
                }
            }

            int sl = int.Parse(txtSoLuong.Text);
            if (sl < 0)
                txtSoLuong.Text = "0";

            int dg = int.Parse(txtDonGia.Text);
            if (dg < 0)
                txtDonGia.Text = "0";

            row["TenSP"] = txtTenSP.Text;
            row["SoLuong"] = txtSoLuong.Text;
            row["DVT"] = txtDVT.Text;
            row["DonGia"] = txtDonGia.Text;
            row["MaNCC"] = cbb_NCC.SelectedValue.ToString();
            row["MaDM"] = cbb_DM.SelectedValue.ToString();

            DT_SanPham.Rows.Add(row);
            string sql = "select * from SanPham";
            int kq = Sconn.updateDatabase(DT_SanPham, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                txt_MaSP.Clear();
                txtTenSP.Clear();
                txtSoLuong.Clear();
                txtDVT.Clear();
                txtDonGia.Clear();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "select * from SanPham";
            DataRow dr = DT_SanPham.Rows.Find(txt_MaSP.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            int kq = Sconn.updateDatabase(DT_SanPham, sql);
            if (kq > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "select * from SanPham";
            DataRow dr = DT_SanPham.Rows.Find(txt_MaSP.Text);
            if (dr != null)
            {
                dr["TenSP"] = txtTenSP.Text;
                dr["SoLuong"] = txtSoLuong.Text;
                dr["DVT"] = txtDVT.Text;
                dr["DonGia"] = txtDonGia.Text;
            }
            int kq = Sconn.updateDatabase(DT_SanPham, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            txt_MaSP.Clear();
            txtTenSP.Clear();
            txtSoLuong.Clear();
            txtDVT.Clear();
            txtDonGia.Clear();
        }

        private void dataGVDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSP.Enabled = true;
            int index = dataGVDV.CurrentRow.Index;
            txt_MaSP.Text = dataGVDV.Rows[index].Cells[0].Value.ToString();
            cbb_NCC.Text = dataGVDV.Rows[index].Cells[1].Value.ToString();
            cbb_DM.Text = dataGVDV.Rows[index].Cells[2].Value.ToString();
            txtTenSP.Text = dataGVDV.Rows[index].Cells[3].Value.ToString();
            txtSoLuong.Text = dataGVDV.Rows[index].Cells[4].Value.ToString();
            txtDVT.Text = dataGVDV.Rows[index].Cells[5].Value.ToString();
            txtDonGia.Text = dataGVDV.Rows[index].Cells[6].Value.ToString();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            Load_GV_SanPham();
            Load_cbb_DM();
            Load_cbb_NCC();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu f = new TrangChu();
            f.Show();
        }        
    }
}
