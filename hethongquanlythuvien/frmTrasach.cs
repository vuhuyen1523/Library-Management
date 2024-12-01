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
    public partial class frmTrasach : Form
    {
        public frmTrasach()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát Form Trả sách không ?", " Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(DialogResult == DialogResult.OK)
            {
                this.Hide();
                frmTrangChu newform = new frmTrangChu();
                newform.ShowDialog();
                this.Show();
            }
        }
    }
}
