using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySInhVien_WC
{
    public partial class Form1 : Form
    {
        private QuanLySInhVien_WC.nbs.WebService wc;
        public Form1()
        {
            InitializeComponent();
            wc = new QuanLySInhVien_WC.nbs.WebService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi.DataSource = wc.ShowTT();
            hienthi.RowHeadersVisible = false;

        }

        private void hienthi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = hienthi.CurrentRow.Cells[0].Value.ToString();
            txtMSV.Text = hienthi.CurrentRow.Cells[1].Value.ToString();
            txtHT.Text = hienthi.CurrentRow.Cells[2].Value.ToString();
            txtNS.Text = hienthi.CurrentRow.Cells[3].Value.ToString();
            txtQQ.Text = hienthi.CurrentRow.Cells[4].Value.ToString();
            txtLopHP.Text = hienthi.CurrentRow.Cells[5].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(MessageBox.Show("Bạn có muốn thêm không?","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    wc.themsuaxoa("INSERT INTO SinhVien VALUES('" + txtID.Text + "','" + txtMSV.Text + "',N'" + txtHT.Text + "','" + txtNS.Text + "',N'" + txtQQ.Text + "',N'" + txtLopHP.Text + "')");
                    hienthi.DataSource = wc.ShowTT();
                    MessageBox.Show("Thêm thông tin thành công. ", "Thông báo");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi \n" +ex, "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    wc.themsuaxoa("UPDATE SinhVien SET masv = '" + txtMSV.Text + "',hoten = N'" + txtHT.Text + "',namsinh = '" + txtNS.Text + "',quequan = N'" + txtQQ.Text + "',lophp = N'" + txtLopHP.Text + "' WHERE id = '" + txtID.Text + "'");
                    hienthi.DataSource = wc.ShowTT();
                    MessageBox.Show("Sửa thông tin thành công. ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi \n" + ex, "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    wc.themsuaxoa("DELETE FROM SinhVien WHERE id = '" + txtID.Text + "'");
                    hienthi.DataSource = wc.ShowTT();
                    MessageBox.Show("Đã xóa. ", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi \n" + ex, "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtMSV.Text == "")
            {
                hienthi.DataSource = wc.ShowTT();
                hienthi.RowHeadersVisible = false;
            }
            else
            {
                hienthi.DataSource = wc.TimKiem(txtMSV.Text);
                hienthi.RowHeadersVisible = false;
               
            }
        }
    }
}
