using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// mở thêm các thư viện phục vụ cho quá trình kết nối sql
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DOAN_laptrinhNet_nhom3
{
    class Dataservices
    {
        //khai báo đối tượng kết nối 
        private static SqlConnection mySqlConnection;
        // khia báo đối tượng sử dụng để truy vấn và cập nhật giữa csdl và bảng 
        private SqlDataAdapter mysqlDataAdapter;
        // hàm kết nối với csdl
        public bool OpenDB()
        {
            // khai báo xâu kết nối 
            string conStr = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLYSach1;Integrated Security=True";
            //hàm try catch dùng để xử lý lỗi ngoại lệ, hàm try là bắt lỗi hàm catch xử lý ngoại lệ 
            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
            }
            catch (SqlException ex)//ngoại lệ tên ex
            {
                DisplayError(ex);
                mySqlConnection = null;
                return false;
            }
            return true;
        }
        //hàm truy vấn dữ liệu
        public DataTable RunQuery( string sSql)//hàm trả về giá trị là 1 bảng csdl với đầu váo là chuỗi lệnh sql
        {
            DataTable myDataTable = new DataTable();
            try // hàm xử lý lỗi ngoại lệ 
            {
                // được sd thực hiện truy vấn sql và điền vào DataTable
                mysqlDataAdapter = new SqlDataAdapter(sSql, mySqlConnection);
                // tạo các lệnh insert, update, delete cho SqlDataAdapter
                SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(mysqlDataAdapter);
                mysqlDataAdapter.Fill(myDataTable);
                //phương thức fill của SqlDataAdapter thực hiện truy vấn và điền kết quả và DataTable( myDataTable )

            }
            catch(SqlException ex)
            {
                DisplayError(ex);
                return null;
            }
            return myDataTable;
        }
        //hàm nhập một Datatable vào một bảng của csdl
        public void Update (DataTable myDataTable)
        {
            try
            {
                mysqlDataAdapter.Update(myDataTable);
            }
            catch( SqlException ex)
            {
                DisplayError(ex);
            }
        }
        //hàm thực hiện một câu lệnh SQL dựa trên SqlCommand
        public void ExecuteNonQuery(string sSql)
        {
            SqlCommand mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
                //thực thi các câu lệnh SQL trên một cơ sở dữ liệu
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
            }

        }
        public void DisplayError(SqlException ex)
        {
            string sSql = "SELECT * FROM Errors WHERE Number = " + ex.Number;
            DataTable dtError = RunQuery(sSql);
            if (dtError.Rows.Count > 0)
                MessageBox.Show(dtError.Rows[0][1].ToString().Trim(), "Lỗi " + ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
