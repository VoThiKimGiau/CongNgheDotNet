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
    public partial class frmPhieu : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private Bitmap bmp;

        public frmPhieu()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source = DELL-PC; Initial Catalog = QLKhoCHSua; Integrated Security = True");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            dgvPhieu.AllowUserToAddRows = true;
            dgvPhieu.ReadOnly = false;
            for (int i = 0; i < dgvPhieu.Rows.Count - 1; i++)
                dgvPhieu.Rows[i].ReadOnly = true;
            dgvPhieu.FirstDisplayedScrollingRowIndex = dgvPhieu.Rows.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string insertString = "delete from Phieu where MaPhieu = '" + txtMP.Text + "'";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                cmd.ExecuteNonQuery();

                int indexX = dgvPhieu.CurrentCell.RowIndex;
                dgvPhieu.Rows.RemoveAt(indexX);

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
            dgvPhieu.ReadOnly = false;
            for (int i = 0; i < dgvPhieu.Rows.Count - 1; i++)
                dgvPhieu.Rows[i].ReadOnly = false;
            dgvPhieu.Columns[0].ReadOnly = true;
            dgvPhieu.AllowUserToAddRows = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Phieu", conn);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "Phieu");
            databingding(ds.Tables["Phieu"]);
            MessageBox.Show("Thành công", "Thông báo");
            btnSave.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
            f.Show();
            this.Hide();
        }

        void loadP()
        {
            string strsel = "Select * from Phieu";
            SqlDataAdapter da = new SqlDataAdapter(strsel, conn);
            da.Fill(ds, "Phieu");
            dgvPhieu.DataSource = ds.Tables["Phieu"];
        }

        void databingding(DataTable pDT)
        {
            txtMP.DataBindings.Clear();
            txtMLP.DataBindings.Clear();
            txtTT.DataBindings.Clear();
            mktDay.DataBindings.Clear();

            txtMP.DataBindings.Add("Text", pDT, "MaPhieu");
            txtMLP.DataBindings.Add("Text", pDT, "MaLoaiPhieu");
            txtTT.DataBindings.Add("Text", pDT, "TongTien");
            mktDay.DataBindings.Add("Text", pDT, "Ngay");
        }

        private void frmPhieu_Load(object sender, EventArgs e)
        {
            loadP();
            dgvPhieu.ReadOnly = true;
            dgvPhieu.AllowUserToAddRows = false;

            foreach (Control item in tabLayout.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(MaskedTextBox))
                    item.Enabled = false;
            }

            btnUpdate.Enabled = btnDelete.Enabled = btnSave.Enabled = false;
            databingding(ds.Tables["Phieu"]);
        }

        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                mktDay.Text = DateTime.Parse(dgvPhieu.CurrentRow.Cells[2].Value.ToString()).ToString("dd/MM/yyyy");
            }
            catch
            {
                mktDay.Text = string.Empty;
            }

            btnUpdate.Enabled = btnDelete.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int height = dgvPhieu.Height;
            dgvPhieu.Height = dgvPhieu.RowCount * dgvPhieu.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvPhieu.Width, dgvPhieu.Height);
            dgvPhieu.DrawToBitmap(bmp, new Rectangle(0, 0, dgvPhieu.Width, dgvPhieu.Height));
            dgvPhieu.Height = height;

            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
