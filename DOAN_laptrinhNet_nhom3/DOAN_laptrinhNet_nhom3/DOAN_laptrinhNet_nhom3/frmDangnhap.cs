using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// MỞ THÊM THƯ VIỆN
using System.Data.SqlClient;

namespace DOAN_laptrinhNet_nhom3
{
    public partial class frmDangnhap : Form
    {
        private string conStr = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=doan1;Integrated Security=True";
        //khai báo đối tượng kết nối
        private SqlConnection mySqlConnection;
        //khai báo đối tượng SqlCommand
        private SqlCommand mySqlCommand;
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void lbmatkhau_Click(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            // kết nối đến csdl
            mySqlConnection = new SqlConnection(conStr);
            mySqlConnection.Open();
            //truy vấn để kiểm tra tên đăng nhập và mật khẩu
            string sSql = "SELECT * FROM tblNhanVien WHERE (TenDangNhap = N'" + txttendangnhap.Text + "') AND (MatKhau = N'" + txtmatkhau.Text + "')";
            mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            // SqlDataReader drtblNhanVien
            SqlDataReader drtblNhanVien = mySqlCommand.ExecuteReader();
            if (drtblNhanVien.HasRows == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                drtblNhanVien.Close();
                return;
            }
            frmMenu frmmain = new frmMenu();
            frmmain.Show();
            this.Hide();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
