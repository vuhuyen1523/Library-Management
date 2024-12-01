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
    public partial class frmtkdocgia : Form
    {
        public frmtkdocgia()
        {
            InitializeComponent();
        }

        private void btn_thoattkdg_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát form tìm kiếm theo độc giả không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
