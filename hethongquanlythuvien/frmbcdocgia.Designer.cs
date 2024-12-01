namespace hethongquanlythuvien
{
    partial class frmbcdocgia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tkedg = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tk2 = new System.Windows.Forms.Button();
            this.btn_xe2 = new System.Windows.Forms.Button();
            this.btn_thoat2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_bctkdg = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bctkdg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_tkedg);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // cb_tkedg
            // 
            this.cb_tkedg.FormattingEnabled = true;
            this.cb_tkedg.Items.AddRange(new object[] {
            "Tất cả độc giả",
            "Độc giả trễ hạn"});
            this.cb_tkedg.Location = new System.Drawing.Point(37, 48);
            this.cb_tkedg.Name = "cb_tkedg";
            this.cb_tkedg.Size = new System.Drawing.Size(226, 31);
            this.cb_tkedg.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_tk2);
            this.groupBox2.Controls.Add(this.btn_xe2);
            this.groupBox2.Controls.Add(this.btn_thoat2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(323, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btn_tk2
            // 
            this.btn_tk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_tk2.Location = new System.Drawing.Point(6, 51);
            this.btn_tk2.Name = "btn_tk2";
            this.btn_tk2.Size = new System.Drawing.Size(120, 38);
            this.btn_tk2.TabIndex = 1;
            this.btn_tk2.Text = "Thống kê";
            this.btn_tk2.UseVisualStyleBackColor = false;
            // 
            // btn_xe2
            // 
            this.btn_xe2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_xe2.Location = new System.Drawing.Point(157, 51);
            this.btn_xe2.Name = "btn_xe2";
            this.btn_xe2.Size = new System.Drawing.Size(120, 38);
            this.btn_xe2.TabIndex = 2;
            this.btn_xe2.Text = "Xuất Excel ";
            this.btn_xe2.UseVisualStyleBackColor = false;
            // 
            // btn_thoat2
            // 
            this.btn_thoat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoat2.Location = new System.Drawing.Point(298, 51);
            this.btn_thoat2.Name = "btn_thoat2";
            this.btn_thoat2.Size = new System.Drawing.Size(120, 38);
            this.btn_thoat2.TabIndex = 3;
            this.btn_thoat2.Text = "Thoát";
            this.btn_thoat2.UseVisualStyleBackColor = false;
            this.btn_thoat2.Click += new System.EventHandler(this.btn_thoat2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_bctkdg);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(735, 307);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dữ liệu";
            // 
            // dgv_bctkdg
            // 
            this.dgv_bctkdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bctkdg.Location = new System.Drawing.Point(16, 42);
            this.dgv_bctkdg.Name = "dgv_bctkdg";
            this.dgv_bctkdg.RowHeadersWidth = 51;
            this.dgv_bctkdg.RowTemplate.Height = 24;
            this.dgv_bctkdg.Size = new System.Drawing.Size(704, 246);
            this.dgv_bctkdg.TabIndex = 0;
            // 
            // frmbcdocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmbcdocgia";
            this.Text = "Form báo cáo /thống kê Độc giả";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bctkdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_tkedg;
        private System.Windows.Forms.Button btn_tk2;
        private System.Windows.Forms.Button btn_xe2;
        private System.Windows.Forms.Button btn_thoat2;
        private System.Windows.Forms.DataGridView dgv_bctkdg;
    }
}