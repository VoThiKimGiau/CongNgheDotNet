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
    public partial class NhaCungCap : Form
    {
        DBConnect Sconn = new DBConnect();
        DataTable DT_NhaCungCap = new DataTable();        
        public NhaCungCap()
        {
            InitializeComponent();
            string sql = "select * from NhaCungCap";
            DT_NhaCungCap = Sconn.getDatatable(sql, "NhaCungCap").Tables["NhaCungCap"];
            DataColumn[] key = new DataColumn[1];
            key[0] = DT_NhaCungCap.Columns[0];
            DT_NhaCungCap.PrimaryKey = key;
        }
        public void Load_GV_NhaCungCap()
        {
            dataGVDV.DataSource = DT_NhaCungCap;
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            Load_GV_NhaCungCap();
        }
        public bool KiemTra(int temp)
        {
            foreach (DataRow dr in DT_NhaCungCap.Rows)
            {
                string tmp1 = dr["MaNCC"].ToString();
                if (int.Parse(tmp1.Substring(2)) == temp)
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRow row = DT_NhaCungCap.NewRow();
            for (int i = 1; i <= 1000; i++)
            {
                if (KiemTra(i) == false)
                {
                    row["MaNCC"] = "NCC" + i.ToString();
                    break;
                }
            }
            row["tenNCC"] = txtNCC .Text;
            row["diachi"] = txtDiaChi.Text;
            row["sdt"] = txtSDT.Text;
            row["email"] = txtEmail.Text;
            DT_NhaCungCap.Rows.Add(row);
            string sql = "select * from NhaCungCap";
            int kq = Sconn.updateDatabase(DT_NhaCungCap, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                txt_MaNCC.Clear();
                txtNCC.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "select * from NhaCungCap";
            DataRow dr = DT_NhaCungCap.Rows.Find(txt_MaNCC.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            int kq = Sconn.updateDatabase(DT_NhaCungCap, sql);
            if (kq > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "select * from NhaCungCap";
            DataRow dr = DT_NhaCungCap.Rows.Find(txt_MaNCC.Text);
            if (dr != null)
            {
                dr["tenNCC"] = txtNCC.Text;
                dr["diachi"] = txtDiaChi.Text;
                dr["sdt"] = txtSDT.Text;
                dr["email"] = txtEmail.Text;
            }
            int kq = Sconn.updateDatabase(DT_NhaCungCap, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void dataGVDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNCC.Enabled = true;
            int index = dataGVDV.CurrentRow.Index;
            txt_MaNCC.Text = dataGVDV.Rows[index].Cells[0].Value.ToString();
            txtNCC.Text = dataGVDV.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGVDV.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dataGVDV.Rows[index].Cells[3].Value.ToString();
            txtEmail.Text = dataGVDV.Rows[index].Cells[4].Value.ToString();
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            txt_MaNCC.Clear();
            txtNCC.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu f = new TrangChu();
            f.Show();
        }
    }
}
