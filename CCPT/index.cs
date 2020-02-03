using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCPT
{
    public partial class index : Form
    {
        Hoatdong model = new Hoatdong();
       
        public index()
        {
            
            InitializeComponent();
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            if (lg.loai == "Giám Đốc")
            {
                tlacc.Enabled = true;
            }
            else
            {
                tlacc.Enabled = false;
            }
            txtngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtdate.Text= DateTime.Now.ToString("dd/MM/yyyy");
            showdata(DateTime.Parse(txtngay.Text.ToString()));
            doanhthu();
            lblname.Text = lg.loai +": "+ lg.ten ;
           
            btnXoa.Enabled = false;
        }
        
       
        private void lbltime_Click(object sender, EventArgs e)
        {
            
        }

        private void xuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kho quanlykho = new kho();
            quanlykho.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtngay_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void txtsoSerial_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMaTB_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void reset()
        {
            lblID.Text = "0";
            txtsua.Text = null;
            txttenTB.Text = "Nếu có";
            txtMatb.Text = "Nếu có";
            txtngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtSoluong.Text = "01";
            txttenKH.Text = null;
            txtSDT.Text = null;
            txtDongia.Text = txtChiPhi.Text = "000";
            btnLuu.Text = "Lưu";
        }
        

        private void btnLuu_Click(object sender, EventArgs e)//btn Lưu
        {
            try {
                if (txtsua.Text == null )
                {
                    lblinfor.Text = "Bạn phải nhập Nội dung sửa chửa";
                }
                else if(txtSDT.Text == null)
                {
                    lblinfor.Text = "Bạn phải nhập SĐT khách";
                }
                else
                {
                    //xử lý dữ liệu để upload sql
                    if(txttenTB.Text == "Nếu có")
                    {
                        txttenTB.Text = null;
                        txtMatb.Text = null;
                    }
                    int sdt = int.Parse(txtSDT.Text.ToString());
                    DateTime ngaysua = DateTime.Parse(txtngay.Text.ToString());
                    int chiphi = int.Parse(txtChiPhi.Text.ToString());
                    int soluong = int.Parse(txtSoluong.Text.ToString());
                   
                    using (DBEntities db = new DBEntities())
                    {
                        if (lblID.Text == "0")
                        {
                           
                            db.Them(sdt, txttenKH.Text, txtsua.Text, ngaysua, chiphi, soluong, txttenTB.Text, txtMatb.Text, cbxNhanVien.Text);
                            lblinfor.Text = "Lưu Thành Công !";
                            MessageBox.Show("Lưu thành công");

                        }
                        else
                        {
                            int ID = int.Parse(lblID.Text.ToString());
                            db.sua(ID, sdt, txttenKH.Text, txtsua.Text, ngaysua, chiphi, soluong, txttenTB.Text, txtMatb.Text, cbxNhanVien.Text);
                            lblinfor.Text = "Sữa Thành Công !";
                            MessageBox.Show("Sữa thành công");

                        }
                        updatesl(txtMatb.Text, int.Parse(txtSoluong.Text.ToString()));
                        showdata(DateTime.Parse(txtngay.Text.ToString()));
                        doanhthu();
                        reset();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void updatesl(string Matb,int sl)
        {
            
                if ( txttenTB.Text != "Nếu Có" || txttenTB.Text != null)
                {
                    using (DBEntities db = new DBEntities())
                    {
                        //string Matb = txtMatb.Text;
                        //int sl = int.Parse(txtSoluong.Text.ToString());
                        db.updatesoluong(Matb, sl);
                        Console.Write("Update số lượng thiết bị thành công");
                    //MessageBox.Show("Update thành công");
                }
                }
                else
                {
                //MessageBox.Show("Không có thiết bị");
                    Console.WriteLine("Không có thiết bị cân Update số lượng");
                }
            

        }
        private void index_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'desktopAplicationDataSet3.Hoatdong' table. You can move, or remove it, as needed.
            this.hoatdongTableAdapter3.Fill(this.desktopAplicationDataSet3.Hoatdong);
           
            

        }
        // sự kiện click chọn trên grid
        private void dtview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtview.Rows[e.RowIndex];
                lblID.Text = row.Cells[0].Value.ToString();
                txttenKH.Text = row.Cells[1].Value.ToString();
                txtsua.Text = row.Cells[2].Value.ToString();
                txttenTB.Text = row.Cells[3].Value.ToString();
                txtMatb.Text = row.Cells[4].Value.ToString();
                txtSoluong.Text = row.Cells[5].Value.ToString();
               txtngay.Text = row.Cells[6].Value.ToString();
                txtSDT.Text = row.Cells[7].Value.ToString();
                txtChiPhi.Text = row.Cells[8].Value.ToString();
                cbxNhanVien.Text = row.Cells[9].Value.ToString();
                btnLuu.Text = "Sửa";
                btnXoa.Enabled = true;
            }
            catch (Exception)
            {


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int soluong = int.Parse(txtSoluong.Text);
                int dongia = int.Parse(txtDongia.Text);
                int tong = soluong * dongia;
                txtChiPhi.Text = tong.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉ nhận dữ liệu kiểu số!");
            }
        }

        private void txtsua_TextChanged(object sender, EventArgs e)
        {
            txtngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblinfor.Text = null;
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(lblID.Text.ToString());
            using (DBEntities db = new DBEntities())
            {
                db.Deletecell(ID);
            }
            lblinfor.Text = "Xoá Thành công";
            showdata( DateTime.Parse(txtngay.Text.ToString()));
            reset();
            doanhthu();
        }
        public void showdata(DateTime date)
        {
            using (DBEntities db = new DBEntities())
            {
                dtview.DataSource = db.Show(date);
            }
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            
            
            showdata(DateTime.Parse(txtdate.Text.ToString()));
            doanhthu();
        }

        private void btbviewall_Click(object sender, EventArgs e)
        {
            dtview.DataSource = desktopAplicationDataSet3.Hoatdong;
        }

        private void txttenTB_DoubleClick(object sender, EventArgs e)
        {
            txttenTB.Text = null;
            txtMatb.Text = null;
        }

        private void tlogout_Click(object sender, EventArgs e) //DĂNG XUẤT
        {
            DialogResult h = MessageBox.Show
               ("Bạn có chắc muốn đăng xuất không?", "Đăng Xuất?", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                this.Hide();
                index obj = new index();
                obj.Show();
            }
        }

        private void btnseach_Click(object sender, EventArgs e)
        {
            using(DBEntities db = new DBEntities())
            {
                dtview.DataSource = db.timkiem(txtseach.Text);

            }
        }

        private void txtseach_MouseClick(object sender, MouseEventArgs e)
        {
            txtseach.Text = null;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        public void doanhthu()
        {
            int sc = dtview.Rows.Count;
            double tong = 0;
            for (int i = 0; i < sc; i++)
            {
                tong = tong + double.Parse(dtview.Rows[i].Cells["chiPhiDataGridViewTextBoxColumn"].Value.ToString());
            }
            txtdoanhthu.Text = tong.ToString();

        }

       

       
        private void txtseach_KeyPress(object sender, KeyPressEventArgs e)
        {
            //btnseach.PerformClick();
        }

        private void tlacc_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Account_Manager acc = new Account_Manager();
            acc.ShowDialog();
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khachhang_manager obj = new khachhang_manager();
            obj.ShowDialog();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GThieu obj = new GThieu();
            obj.ShowDialog();
        }
    }
}
