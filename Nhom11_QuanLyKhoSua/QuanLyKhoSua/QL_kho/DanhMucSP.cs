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
    public partial class DanhMucSP : Form
    {
        DBConnect Sconn = new DBConnect();
        DataTable DT_DanhMucSP = new DataTable();       
        public DanhMucSP()
        {
            InitializeComponent();
            string sql = "select * from DanhMucSP";
            DT_DanhMucSP = Sconn.getDatatable(sql, "DanhMucSP").Tables["DanhMucSP"];
            DataColumn[] key = new DataColumn[1];
            key[0] = DT_DanhMucSP.Columns[0];
            DT_DanhMucSP.PrimaryKey = key;
        }
        public void Load_GV_DanhMucSP()
        {
            dataGVDV.DataSource = DT_DanhMucSP;
        }
        private void DanhMucSP_Load(object sender, EventArgs e)
        {
            Load_GV_DanhMucSP();
        }
        public bool KiemTra(int temp)
        {
            foreach (DataRow dr in DT_DanhMucSP.Rows)
            {
                string tmp1 = dr["MaDM"].ToString();
                if (int.Parse(tmp1.Substring(2)) == temp)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DataRow row = DT_DanhMucSP.NewRow();
            for (int i = 1; i <= 1000; i++)
            {
                if (KiemTra(i) == false)
                {
                    row["MaDM"] = "DM" + i.ToString();
                    break;
                }
            }
            row["TenDM"] = txtDM.Text;
            DT_DanhMucSP.Rows.Add(row);
            string sql = "select * from DanhMucSP";
            int kq = Sconn.updateDatabase(DT_DanhMucSP, sql);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công");
                txt_MaDM.Clear();
                txtDM.Clear();
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "select * from DanhMucSP";
            DataRow dr = DT_DanhMucSP.Rows.Find(txt_MaDM.Text);
            if (dr != null)
            {
                dr.Delete();
            }
            int kq = Sconn.updateDatabase(DT_DanhMucSP, sql);
            if (kq > 0)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa không thành công");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "select * from DanhMucSP";
            DataRow dr = DT_DanhMucSP.Rows.Find(txt_MaDM.Text);
            if (dr != null)
            {
                dr["TenDM"] = txtDM.Text;
            }
            int kq = Sconn.updateDatabase(DT_DanhMucSP, sql);
            if (kq > 0)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa không thành công");
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            txt_MaDM.Clear();
            txtDM.Clear();
        }

        private void dataGVDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaDM.Enabled = true;
            int index = dataGVDV.CurrentRow.Index;
            txt_MaDM.Text = dataGVDV.Rows[index].Cells[0].Value.ToString();
            txtDM.Text = dataGVDV.Rows[index].Cells[1].Value.ToString();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu f = new TrangChu();
            f.Show();
        }
    }
}
