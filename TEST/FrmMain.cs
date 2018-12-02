using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            btnQuanLyBenhNhan.selected = true;
            
        }    
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyBenhNhan.Top;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyLichHen.Top;
        }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyThuoc.Top;
            UserControl_QuanLyThuoc userControl_QuanLyThuoc = new UserControl_QuanLyThuoc();
            panel_HienThi.Controls.Add(userControl_QuanLyThuoc);
            userControl_QuanLyThuoc.Dock = DockStyle.Fill;
        }

        private void btnQuanLyNVBS_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnQuanLyNVBS.Top;
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnDichVu.Top;
        }

        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnDonThuoc.Top;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnThongKe.Top;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnThanhToan.Top;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            panel_Select.Top = btnHeThong.Top;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            // chú thích pannel_hienthi width = 1154
            if(panel_ChucNang.Width == 42)
            {
                panel_ChucNang.Visible = false;
                panel_ChucNang.Width = 245;
                transition_Menu.ShowSync(panel_ChucNang);

            }
            else
            {
                
                //transition_Menu.HideSync(panel_ChucNang);
                panel_ChucNang.Visible = false;
                panel_ChucNang.Width = 42;
                transition_Menu.ShowSync(panel_ChucNang);

            }
        }
    }
}
