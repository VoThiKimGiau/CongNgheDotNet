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
    public partial class ThongTinSP : Form
    {
        private const string ConnectionString = "Data Source=DELL-PC;Initial Catalog=QLKhoCHSua;Integrated Security=True";
        public ThongTinSP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maDanhMuc = textBox1.Text.Trim();
            string maNCC = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(maDanhMuc) && string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show("Hãy nhập mã danh mục hoặc mã nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool found = ShowProductInfo(maDanhMuc, maNCC);

            if (!found)
            {
                MessageBox.Show("Nhà cung cấp không tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ShowProductInfo(string maDanhMuc, string maNCC)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM SanPham WHERE (MaDM = @MaDanhMuc OR @MaDanhMuc = '') AND (MaNCC = @MaNCC OR @MaNCC = '')";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                        command.Parameters.AddWithValue("@MaNCC", maNCC);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm với mã danh mục và mã nhà cung cấp đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        else
                        {
                            dataGridView1.DataSource = dataTable;
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
            f.Show();
            this.Hide();
        }
    }
}
