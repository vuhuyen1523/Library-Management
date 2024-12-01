using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hethongquanlythuvien
{
    public partial class frmbcsach : Form
    {
        public frmbcsach()
        {
            InitializeComponent();
        }

        private void btn_thoat1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát form báo cáo / thống kê theo sách không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Hide();
                frmTrangChu newform = new frmTrangChu();
                newform.ShowDialog();
                this.Show();
            }
        }
    }
}
