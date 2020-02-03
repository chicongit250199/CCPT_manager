using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCPT
{
    public partial class Account_Manager : Form
    {
        public Account_Manager()
        {
            InitializeComponent();
            btnxoa.Enabled = true;
        }
        //hàm return về mặc định 
        public void returntext()
        {
            txtUsename.Text = null;
            txtpassword.Text = null;
            txtname.Text = null;
            cbxtype.Text = "Nhân Viên";
            btnthem.Text = "Thêm";
            txtconfirm.Text = null;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Account_Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'desktopAplicationDataSet2.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.desktopAplicationDataSet2.Account);

        }
                        //btn Thêm và sữa
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBEntities db = new DBEntities())
                {
                    string pass = txtpassword.Text;
                    if (pass.Length >= 6)
                    {
                        if (txtpassword.Text == txtconfirm.Text)
                        {
                            if (btnthem.Text == "Thêm")
                            {
                                db.ThemAcc(txtUsename.Text, txtpassword.Text, cbxtype.Text, txtname.Text);
                                MessageBox.Show("Thêm thành công Account: " + txtUsename.Text + "\n PassWord: " + txtpassword.Text, "Thông Báo");
                            }
                            else
                            {
                                db.SuaAcc(txtUsename.Text, txtpassword.Text, cbxtype.Text, txtname.Text);
                                MessageBox.Show("Sửa thành công cho Account " + txtUsename.Text, "Thông Báo");
                            }
                            returntext();
                            this.accountTableAdapter.Fill(this.desktopAplicationDataSet2.Account);
                        }
                        else
                        {
                            MessageBox.Show("Xác nhận mật khẩu Không trùng với Mật khẩu!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu quá ngắn!", "Lỗi!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gridview.Rows[e.RowIndex];
            txtUsename.Text = row.Cells[0].Value.ToString();
            txtpassword.Text = row.Cells[1].Value.ToString();
            cbxtype.Text = row.Cells[2].Value.ToString();
            txtname.Text = row.Cells[3].Value.ToString();
            btnthem.Text = "Sữa";
            btnxoa.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn Xoá Account: "+txtUsename.Text+" không?", "Xoá Account: "+ txtUsename.Text+"?", MessageBoxButtons.OKCancel);
                if (h == DialogResult.OK)
                {
                    using (DBEntities db = new DBEntities())
                    {
                        db.XoaAcc(txtUsename.Text);
                    }
                    this.accountTableAdapter.Fill(this.desktopAplicationDataSet2.Account);
                    returntext();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            this.txtpassword.PasswordChar = '*';
        }

        private void txtconfirm_TextChanged(object sender, EventArgs e)
        {
            this.txtpassword.PasswordChar = '*';

        }
    }
}
