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
    public partial class khachhang_manager : Form
    {
        public khachhang_manager()
        {
            InitializeComponent();
            btnXoa.Enabled = false;
        }

        private void khachhang_manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'desktopAplicationDataSet4.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.desktopAplicationDataSet4.KhachHang);

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                int sdt = int.Parse(txtSdt.Text.ToString());
                int id = int.Parse(lblid.Text.ToString());
                if (lblid.Text == "0")
                {
                    //btnThem.Text = "Thêm";
                    db.ThemKH(txtTen.Text, sdt, txtdiachi.Text);
                    MessageBox.Show("Thêm Thành Công");
                }
                else
                {
                    //btnThem.Text = "Sửa";
                    db.SuaKH(id, txtTen.Text, sdt, txtdiachi.Text);
                    MessageBox.Show("Sửa thành công");
                }

                this.khachHangTableAdapter.Fill(this.desktopAplicationDataSet4.KhachHang);
                huy();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                lblid.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtSdt.Text = row.Cells[2].Value.ToString();
                txtdiachi.Text = row.Cells[3].Value.ToString();
                btnThem.Text = ("Sửa");
                btnXoa.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void huy()
        {
            lblid.Text = "0";
            txtTen.Text = null;
            txtSdt.Text = null;
            txtdiachi.Text = null;
            btnThem.Text = "Thêm";
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            huy();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblid.Text.ToString());
            try
            {
                using (DBEntities db = new DBEntities())
                {
                    db.XoaKH(id);
                }
                    
                }
        catch (Exception ex)
            {
        }
            this.khachHangTableAdapter.Fill(this.desktopAplicationDataSet4.KhachHang);
            huy();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
