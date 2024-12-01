namespace hethongquanlythuvien
{
    partial class frmbcsach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.cb_tkes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tke1 = new System.Windows.Forms.Button();
            this.btn_xe1 = new System.Windows.Forms.Button();
            this.btn_thoat1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupbox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.cb_tkes);
            this.groupbox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox1.Location = new System.Drawing.Point(12, 15);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(338, 121);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Tùy chọn thống kê";
            // 
            // cb_tkes
            // 
            this.cb_tkes.FormattingEnabled = true;
            this.cb_tkes.Items.AddRange(new object[] {
            "Tất cả sách",
            "Sách đang mượn",
            "Sách trễ hạn"});
            this.cb_tkes.Location = new System.Drawing.Point(59, 51);
            this.cb_tkes.Name = "cb_tkes";
            this.cb_tkes.Size = new System.Drawing.Size(240, 31);
            this.cb_tkes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_tke1);
            this.groupBox2.Controls.Add(this.btn_xe1);
            this.groupBox2.Controls.Add(this.btn_thoat1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(370, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_tke1
            // 
            this.btn_tke1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_tke1.Location = new System.Drawing.Point(18, 61);
            this.btn_tke1.Name = "btn_tke1";
            this.btn_tke1.Size = new System.Drawing.Size(120, 38);
            this.btn_tke1.TabIndex = 2;
            this.btn_tke1.Text = "Thống kê";
            this.btn_tke1.UseVisualStyleBackColor = false;
            // 
            // btn_xe1
            // 
            this.btn_xe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_xe1.Location = new System.Drawing.Point(157, 59);
            this.btn_xe1.Name = "btn_xe1";
            this.btn_xe1.Size = new System.Drawing.Size(120, 38);
            this.btn_xe1.TabIndex = 3;
            this.btn_xe1.Text = "Xuất Excel";
            this.btn_xe1.UseVisualStyleBackColor = false;
            // 
            // btn_thoat1
            // 
            this.btn_thoat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoat1.Location = new System.Drawing.Point(292, 59);
            this.btn_thoat1.Name = "btn_thoat1";
            this.btn_thoat1.Size = new System.Drawing.Size(120, 38);
            this.btn_thoat1.TabIndex = 4;
            this.btn_thoat1.Text = "Thoát";
            this.btn_thoat1.UseVisualStyleBackColor = false;
            this.btn_thoat1.Click += new System.EventHandler(this.btn_thoat1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 289);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmbcsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupbox1);
            this.Name = "frmbcsach";
            this.Text = "Form báo cáo/thống kê sách";
            this.groupbox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.ComboBox cb_tkes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_tke1;
        private System.Windows.Forms.Button btn_xe1;
        private System.Windows.Forms.Button btn_thoat1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}