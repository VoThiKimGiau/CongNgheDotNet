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
    public partial class TimKiem : Form
    {
        private const string ConnectionString = "Data Source=DELL-PC;Initial Catalog=QLKhoCHSua;Integrated Security=True";
        public TimKiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Hãy nhập tên nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool found = TimKiemTheoTen(ten);

            if (!found)
            {
                MessageBox.Show("Nhà cung cấp không tồn tại trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool TimKiemTheoTen(string ten)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM NhaCungCap WHERE TenNCC LIKE @ten";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ten", "%" + ten + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        return dataTable.Rows.Count > 0; 
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
