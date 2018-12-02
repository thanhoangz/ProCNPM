using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class UserControl_QuanLyThuoc : UserControl
    {
        public UserControl_QuanLyThuoc()
        {
            InitializeComponent();
        }

        private void UserControl_QuanLyThuoc_Load(object sender, EventArgs e)
        {

        }

        private void UserControl_QuanLyThuoc_Resize(object sender, EventArgs e)
        {
            int x;
            x = this.Width - txtTimKiem.Width;
            txtTimKiem.Location = new Point(x, txtTimKiem.Location.Y);
        }

        private void txtTimKiem_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
