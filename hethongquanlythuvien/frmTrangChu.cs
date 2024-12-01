using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hethongquanlythuvien
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form frm =new frmDangNhap();
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát khỏi hệ thống không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmDocgia();
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmNhanvien();
            frm.Show();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmQLSach();
            frm.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmMuonsach();
            frm.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmTrasach();
            frm.Show();
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmtksach();
            frm.Show();
        }

        private void tìmKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmtkdocgia();
            frm.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmbcsach();
            frm.Show();
        }

        private void độcGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmbcdocgia();
            frm.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmtrogiup();
            frm.Show();
        }
    }
}
