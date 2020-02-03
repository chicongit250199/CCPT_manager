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
    public partial class kho : Form
    {
        public kho()
        {
            InitializeComponent();
        }

        private void kho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'desktopAplicationDataSet1.DanhMuc' table. You can move, or remove it, as needed.
            this.danhMucTableAdapter1.Fill(this.desktopAplicationDataSet1.DanhMuc);


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        //Butom Thêm 
        private void btnThem_Click(object sender, EventArgs e)
        {
            // khai báo biến
            String Matb = txtMatb.Text;
            String Soserial = txtSoSerial.Text;
            String Tentb = txtTentb.Text;
            String Dongia = txtDongia.Text;
            String Soluong = txtSoLuong.Text;
            String Loai = cbxLoai.Text;
            String Baohanh = cbxBaohanh.Text;
            if (Matb != "")
            {
                // kết nối CSDL
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9A89EUT;Initial Catalog=DesktopAplication;Persist Security Info=True;User ID=sa;Password=123456");

                try
                {
                    conn.Open();
                    String Sql = "insert into DanhMuc values ('" + Matb + "','" + Soserial + "',N'" + Loai + "',N'" + Tentb + "','" + Dongia + "','" + Soluong + "','" + Baohanh + "'); ";
                    Console.Write(Sql);
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = conn;
                    Cmd.CommandText = Sql;
                    int n = Cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        lblinfor.Text = "Thêm thành công";

                    }
                    else
                    {
                        lblinfor.Text = "Thêm KHÔNG thành công";
                    }
                    conn.Close();
                    Cmd.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối đến CSDL");
                    Console.Write(ex.Message);
                }
            }
            else lblinfor.Text = "chưa nhập mã thiết bị";
            this.danhMucTableAdapter1.Fill(this.desktopAplicationDataSet1.DanhMuc);
            reset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                txtMatb.Text = row.Cells[0].Value.ToString();
                txtSoSerial.Text = row.Cells[1].Value.ToString();
                cbxLoai.Text = row.Cells[2].Value.ToString();
                txtTentb.Text = row.Cells[3].Value.ToString();
                txtDongia.Text = row.Cells[4].Value.ToString();
                txtSoLuong.Text = row.Cells[5].Value.ToString();
                cbxBaohanh.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {


            }

        }
        //Btn SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            // khai báo biến
            String Matb = txtMatb.Text;
            String Soserial = txtSoSerial.Text;
            String Tentb = txtTentb.Text;
            String Dongia = txtDongia.Text;
            String Soluong = txtSoLuong.Text;
            String Loai = cbxLoai.Text;
            String Baohanh = cbxBaohanh.Text;
            // kết nối CSDL
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9A89EUT;Initial Catalog=DesktopAplication;Persist Security Info=True;User ID=sa;Password=123456");

            try
            {
                conn.Open();
                String Sql = "update DanhMuc set MaThietBi='" + Matb + "',SoSerial='" + Soserial + "',Loai='" + Loai + "',TenThietBi='" + Tentb + "',Dongia='" + Dongia + "',SoLuong='" + Soluong + "',ThoiGianBaoHanh='" + Baohanh + "' Where MaThietBi='" + Matb + "'; ";
                Console.Write(Sql);
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = conn;
                Cmd.CommandText = Sql;
                int n = Cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    lblinfor.Text = "Cập nhật thành công";
                }
                else
                {
                    lblinfor.Text = "Cập nhật KHÔNG thành công";
                }
                this.danhMucTableAdapter1.Fill(this.desktopAplicationDataSet1.DanhMuc);
                conn.Close();
                Cmd.Dispose();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến CSDL");
                Console.Write(ex.Message);
            }
        }
        //btn XOÁ
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            // khai báo biến
            String Matb = txtMatb.Text;
            String Soserial = txtSoSerial.Text;
            String Tentb = txtTentb.Text;
            String Dongia = txtDongia.Text;
            String Soluong = txtSoLuong.Text;
            String Loai = cbxLoai.Text;
            String Baohanh = cbxBaohanh.Text;
            // kết nối CSDL
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9A89EUT;Initial Catalog=DesktopAplication;Persist Security Info=True;User ID=sa;Password=123456");

            try
            {
                conn.Open();
                String Sql = "delete From DanhMuc where MaThietBi='" + Matb + "' and TenThietBi='" + Tentb + "';";
                Console.Write(Sql);
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = conn;
                Cmd.CommandText = Sql;
                int n = Cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    lblinfor.Text = "Xoá thành công";
                }
                else
                {
                    lblinfor.Text = "Xoá KHÔNG thành công";
                }
                this.danhMucTableAdapter1.Fill(this.desktopAplicationDataSet1.DanhMuc);
                conn.Close();
                Cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến CSDL");
                Console.Write(ex.Message);
            }
            reset();
        }


        private void txtMatb_TextChanged(object sender, EventArgs e)
        {
            lblinfor.Text = null;
        }

        private void txtTentb_TextChanged(object sender, EventArgs e)
        {
            lblinfor.Text = null;

        }

        private void dataGridView1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void reset()
        {
            txtTentb.Text = null;
            txtMatb.Text = null;
            txtDongia.Text = null;
            txtSoLuong.Text = "0";
            cbxLoai.Text = "Màn Hình";
            cbxBaohanh.Text = "03";

        }

        private void cbxphanloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loai = cbxphanloai.Text;
            // kết nối CSDL
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9A89EUT;Initial Catalog=DesktopAplication;Persist Security Info=True;User ID=sa;Password=123456");

            try
            {
                conn.Open();
                String Sql = "select * From DanhMuc where Loai = N'" + loai + "' ;";
                //SqlCommand Cmd = new SqlCommand();
                //Cmd.Connection = conn;
                //Cmd.CommandText = Sql;
                SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Console.Write(Sql);
                dataGridView1.DataSource = dt;
                conn.Close();
                
            }
            catch (Exception ex)
            {
                Console.Write("lỗi ");
                Console.Write(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Search = txtTimkiem.Text;
            // kết nối CSDL
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9A89EUT;Initial Catalog=DesktopAplication;Persist Security Info=True;User ID=sa;Password=123456");

            try
            {
                conn.Open();
                String Sql = "select * From DanhMuc where Loai like N'" + Search + "' ;";
                //SqlCommand Cmd = new SqlCommand();
                //Cmd.Connection = conn;
                //Cmd.CommandText = Sql;
                SqlDataAdapter da = new SqlDataAdapter(Sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Console.Write(Sql);
                dataGridView1.DataSource = dt;
                conn.Close();
                
            }
            catch (Exception ex)
            {
                Console.Write("lỗi ");
                Console.Write(ex.Message);
            }
        }
    }
}
