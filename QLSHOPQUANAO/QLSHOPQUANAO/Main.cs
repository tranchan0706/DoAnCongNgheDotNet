using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSHOPQUANAO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            TrangChuUC.BringToFront();
            lblTieuDe.Text = "TRANG CHỦ";
            btn_TrangChu.BackColor = Color.Tomato;
            
        }
        private string tennv_nhan;
        private string chucvu_nhan;

        public Main(string tennv, string chucvu)
            : this()
        {
            tennv_nhan = tennv;
            chucvu_nhan = chucvu;
            textBox2.Text = tennv_nhan;
            textBox1.Text = chucvu_nhan;

            if (chucvu.Equals("QUẢN LÝ") || chucvu.Equals("NHÂN VIÊN"))
            {
                btn_NhanVien.Enabled = false;
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            TrangChuUC.BringToFront();
            lblTieuDe.Text = "TRANG CHỦ";
            btn_TrangChu.BackColor = Color.Tomato;
            btn_SanPham.BackColor = Color.Aqua;
            btn_NhanVien.BackColor = Color.Aqua;
            btn_CTHoaDon.BackColor = Color.Aqua;
            btn_KhachHang.BackColor = Color.Aqua;
            btn_HoaDon.BackColor = Color.Aqua;
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            SanPhamUC.BringToFront();
            lblTieuDe.Text = "SẢN PHẨM";
            btn_SanPham.BackColor = Color.Tomato;
            btn_NhanVien.BackColor = Color.Aqua;
            btn_TrangChu.BackColor = Color.Aqua;
            btn_CTHoaDon.BackColor = Color.Aqua;
            btn_KhachHang.BackColor = Color.Aqua;
            btn_HoaDon.BackColor = Color.Aqua;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form f = new DangNhap();
                f.Show();
            }
            
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            KhachHangUC.BringToFront();
            lblTieuDe.Text = "KHÁCH HÀNG";
            btn_KhachHang.BackColor = Color.Tomato;
            btn_TrangChu.BackColor = Color.Aqua;
            btn_SanPham.BackColor = Color.Aqua;
            btn_CTHoaDon.BackColor = Color.Aqua;
            btn_NhanVien.BackColor = Color.Aqua;
            btn_HoaDon.BackColor = Color.Aqua;
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            NhanVienUC.BringToFront();
            lblTieuDe.Text = "NHÂN VIÊN";
            btn_NhanVien.BackColor = Color.Tomato;
            btn_TrangChu.BackColor = Color.Aqua;
            btn_SanPham.BackColor = Color.Aqua;
            btn_CTHoaDon.BackColor = Color.Aqua;
            btn_KhachHang.BackColor = Color.Aqua;
            btn_HoaDon.BackColor = Color.Aqua;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            CTHoaDonUC.BringToFront();
            lblTieuDe.Text = "CHI TIẾT HÓA ĐƠN";
            btn_CTHoaDon.BackColor = Color.Tomato;
            btn_SanPham.BackColor = Color.Aqua;
            btn_NhanVien.BackColor = Color.Aqua;
            btn_TrangChu.BackColor = Color.Aqua;
            btn_KhachHang.BackColor = Color.Aqua;
            btn_HoaDon.BackColor = Color.Aqua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDonUC.BringToFront();
            lblTieuDe.Text = "HÓA ĐƠN";
            btn_HoaDon.BackColor = Color.Tomato;
            btn_SanPham.BackColor = Color.Aqua;
            btn_NhanVien.BackColor = Color.Aqua;
            btn_TrangChu.BackColor = Color.Aqua;
            btn_KhachHang.BackColor = Color.Aqua;
            btn_CTHoaDon.BackColor = Color.Aqua;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.X = @"https://www.facebook.com/quanaonamnu88";
            new Online().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.X = @"https://youtu.be/7EArX4-FR4Y";
            new Online().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.X = @"https://www.instagram.com/tranchan1/";
            new Online().ShowDialog();
        }


    }
}
