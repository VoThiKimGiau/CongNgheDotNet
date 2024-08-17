using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_kho
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Sconn = new SqlConnection("Data Source=DELL-PC; Initial Catalog=QLKhoCHSua;Integrated Security = True");
            SqlDataAdapter reader = new SqlDataAdapter("Select MaNV, Pass from NhanVien where MaNV ='" + txtuser.Text + "' and Pass = '" + txtPassword.Text + "'", Sconn);
            DataTable dt = new DataTable();
            reader.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                TrangChu f = new TrangChu();
                f.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
                txtuser.Clear();
                txtPassword.Clear();
                txtuser.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_Checked_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword_Checked.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

    }
}
