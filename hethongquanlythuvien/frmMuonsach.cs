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
    public partial class frmMuonsach : Form
    {
        public frmMuonsach()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát khỏi Form mượn sách không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                //Application.Exit();
                this.Hide();
                frmTrangChu newform = new frmTrangChu();
                newform.ShowDialog();
                this.Show();
            }
        }
    }
}
