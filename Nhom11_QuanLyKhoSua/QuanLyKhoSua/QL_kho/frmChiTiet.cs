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

namespace QL_kho
{
    public partial class frmChiTiet : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private Bitmap bmp;
        public frmChiTiet()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source = DELL-PC; Initial Catalog = QLKhoCHSua; Integrated Security = True");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvChiTiet.AllowUserToAddRows = true;
            dgvChiTiet.ReadOnly = false;
            for (int i = 0; i < dgvChiTiet.Rows.Count - 1; i++)
                dgvChiTiet.Rows[i].ReadOnly = true;
            dgvChiTiet.FirstDisplayedScrollingRowIndex = dgvChiTiet.Rows.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string insertString = "delete from ChiTiet where MaPhieu = '" + txtMP.Text + "' and MaCT = '" + txtMCT.Text + "'";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();

                int indexX = dgvChiTiet.CurrentCell.RowIndex;
                dgvChiTiet.Rows.RemoveAt(indexX);

                MessageBox.Show("Thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại", "Thông báo");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvChiTiet.ReadOnly = false;
            for (int i = 0; i < dgvChiTiet.Rows.Count - 1; i++)
                dgvChiTiet.Rows[i].ReadOnly = false;
            dgvChiTiet.Columns[0].ReadOnly = true;
            dgvChiTiet.AllowUserToAddRows = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from ChiTiet", conn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "ChiTiet");
            databingding(ds.Tables["ChiTiet"]);
            MessageBox.Show("Thành công", "Thông báo");
            btnSave.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
            f.Show();
            this.Hide();
        }

        void loadCT()
        {
            string strsel = "Select * from ChiTiet";
            SqlDataAdapter da = new SqlDataAdapter(strsel, conn);
            da.Fill(ds, "ChiTiet");
            dgvChiTiet.DataSource = ds.Tables["ChiTiet"];
        }

        void databingding(DataTable pDT)
        {
            txtMCT.DataBindings.Clear();
            txtMP.DataBindings.Clear();
            txtMSP.DataBindings.Clear();
            txtSL.DataBindings.Clear();
            txtDG.DataBindings.Clear();

            txtMCT.DataBindings.Add("Text", pDT, "MaCT");
            txtMP.DataBindings.Add("Text", pDT, "MaPhieu");
            txtMSP.DataBindings.Add("Text", pDT, "MaSP");
            txtSL.DataBindings.Add("Text", pDT, "SoLuong");
            txtDG.DataBindings.Add("Text", pDT, "DonGia");
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            loadCT();
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.AllowUserToAddRows = false;

            foreach (Control item in tabLayout.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                    item.Enabled = false;
            }

            btnUpdate.Enabled = btnDelete.Enabled = btnSave.Enabled = false;
            databingding(ds.Tables["ChiTiet"]);
        }

        private void dgvChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = btnDelete.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvChiTiet.Height;
            dgvChiTiet.Height = dgvChiTiet.RowCount * dgvChiTiet.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvChiTiet.Width, dgvChiTiet.Height);
            dgvChiTiet.DrawToBitmap(bmp, new Rectangle(0, 0, dgvChiTiet.Width, dgvChiTiet.Height));
            dgvChiTiet.Height = height;

            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
