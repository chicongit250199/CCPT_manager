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
using System.Data;


namespace QuanLyBanHang
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection conn= "Data Source=DESKTOP-77014GJ\SA;Initial Catalog=DesktopAplication;Persist Security Info=True;User ID=sa;Password=***********";
            try
            {
                conn.Open();
                String username = txtUserName.Text;
                String password = txtPassWord.Text;
                String Sql = "select * from Account where UserName = '"+ username + "' and PassWord = '"+ password + "' ";
                SqlCommand Cmd = new SqlCommand(Sql, conn);
                SqlDataReader data = Cmd.ExecuteReader();
                if(data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến CSDL");
            }
        }
        
    }
}
