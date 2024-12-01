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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select * from NguoiDung where tendangnhap ='{0}' and matkhau = '{1}'",
                txt_tendn.Text,
                txt_matkhau.Text
                );
            DataSet ds = kn.laydulieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmTrangChu frm = new frmTrangChu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
