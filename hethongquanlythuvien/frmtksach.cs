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
    public partial class frmtksach : Form
    {
        public frmtksach()
        {
            InitializeComponent();
        }

        private void btn_thoattk_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát form tìm kiếm theo sách không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
