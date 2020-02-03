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

namespace CCPT
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public string ten = null;
        public string loai = null;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9A89EUT;Initial Catalog=DesktopAplication;Persist Security Info=True;User ID=sa;Password=123456");

            try
            {
                conn.Open();
                String username = txtUserName.Text;
                String password = txtPassWord.Text;
                String Sql = "select * from Account where UserName = '" + username + "' and PassWord = '" + password + "' ";
                SqlCommand Cmd = new SqlCommand(Sql, conn);
                SqlDataReader data = Cmd.ExecuteReader();              
               
                if (data.Read() == true)
                {
                   this.ten = data["Name"].ToString();
                    MessageBox.Show("Đăng nhập thành công với tư cách "+ten);
                    
                    this.loai = data["TypeUser"].ToString();
                    this.Hide();
                    
                    
                }
                else if(username == null)
                {
                    lblinforlog.Text = "Vui lòng nhập Tên đăng nhập!";
                }
                else if (password == null)
                {
                    lblinforlog.Text = "Vui lòng nhập Mật Khẩu!";
                }
                else
                {
                    lblinforlog.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
                    
                    //MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Lỗi kết nối đến CSDL");
            }
           

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblinforlog.Text = null;
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            lblinforlog.Text = null;
            this.txtPassWord.PasswordChar = '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

      

        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnLogin.PerformClick();

        }
    }
}
