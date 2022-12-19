using QuanLyCuaHangGiaDung.Controller;
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

namespace QuanLyCuaHangGiaDung.View
{
    public partial class HeThong : Form
    {
        DangNhapController dn = new DangNhapController();
        private string tk;
        public HeThong()
        {
            InitializeComponent();
            btnHome.BackColor = System.Drawing.Color.Crimson;
        }

        public HeThong(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            btnHome.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.ForeColor = System.Drawing.Color.Black;

            childForm.Dock = DockStyle.Fill;
            panel_hienthi.Controls.Add(childForm);
            panel_hienthi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void setBackColor()
        {
            btnHome.BackColor = System.Drawing.Color.DarkCyan;
            btnQlnv.BackColor = System.Drawing.Color.DarkCyan;
            btnQlsp.BackColor = System.Drawing.Color.DarkCyan;
            btnQlhd.BackColor = System.Drawing.Color.DarkCyan;
            btnQlncc.BackColor = System.Drawing.Color.DarkCyan;
            btnQlkh.BackColor = System.Drawing.Color.DarkCyan;
            btnQltk.BackColor = System.Drawing.Color.DarkCyan;
            btnBctk.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setBackColor();
            btnHome.BackColor = System.Drawing.Color.Crimson;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btnQlnv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.QuanLyNhanVien());
            setBackColor();
            btnQlnv.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnQlncc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.QuanLyNhaCungCap());
            setBackColor();
            btnQlncc.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnQlsp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.QuanLySanPham());
            setBackColor();
            btnQlsp.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnQlhd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.QuanLyHoaDon());
            setBackColor();
            btnQlhd.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnQltk_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.QuanLyTaiKhoan());
            setBackColor();
            btnQltk.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnBctk_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.BaoCaoThongKe());
            setBackColor();
            btnBctk.BackColor = System.Drawing.Color.Crimson;
        }

        private void btnQlkh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.QuanLyKhachHang());
            setBackColor();
            btnQlkh.BackColor = System.Drawing.Color.Crimson;
        }


        string quyen;
        private void HeThong_Load(object sender, EventArgs e)
        {
            lbTK.Text = tk;
            if (dn.checkQuyen(tk) == true)
            {
                lbTK.ForeColor = Color.Red;
            }
            else
            {
                btnQlnv.Enabled = false;
                btnQltk.Enabled = false;
                btnBctk.Enabled = false;
            }
        }


        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if(imageNumber == 5)
            {
                imageNumber = 1;
            }
            slidepic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
