﻿using System;
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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTrangChu newform = new frmTrangChu();
            newform.ShowDialog();
            this.Show();
        }
    }
}
