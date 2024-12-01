namespace hethongquanlythuvien
{
    partial class frmtkdocgia
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
            this.txt_nstk = new System.Windows.Forms.TextBox();
            this.txt_tendgtk = new System.Windows.Forms.TextBox();
            this.txt_madgtk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_tktttdg = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_thoattkdg = new System.Windows.Forms.Button();
            this.btn_tkdg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tktttdg)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nstk);
            this.groupBox1.Controls.Add(this.txt_tendgtk);
            this.groupBox1.Controls.Add(this.txt_madgtk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo thông tin độc giả";
            // 
            // txt_nstk
            // 
            this.txt_nstk.Location = new System.Drawing.Point(144, 187);
            this.txt_nstk.Name = "txt_nstk";
            this.txt_nstk.Size = new System.Drawing.Size(203, 30);
            this.txt_nstk.TabIndex = 5;
            // 
            // txt_tendgtk
            // 
            this.txt_tendgtk.Location = new System.Drawing.Point(144, 120);
            this.txt_tendgtk.Name = "txt_tendgtk";
            this.txt_tendgtk.Size = new System.Drawing.Size(203, 30);
            this.txt_tendgtk.TabIndex = 4;
            // 
            // txt_madgtk
            // 
            this.txt_madgtk.Location = new System.Drawing.Point(144, 53);
            this.txt_madgtk.Name = "txt_madgtk";
            this.txt_madgtk.Size = new System.Drawing.Size(203, 30);
            this.txt_madgtk.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_tktttdg);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(473, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 420);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // dgv_tktttdg
            // 
            this.dgv_tktttdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tktttdg.Location = new System.Drawing.Point(18, 38);
            this.dgv_tktttdg.Name = "dgv_tktttdg";
            this.dgv_tktttdg.RowHeadersWidth = 51;
            this.dgv_tktttdg.RowTemplate.Height = 24;
            this.dgv_tktttdg.Size = new System.Drawing.Size(506, 358);
            this.dgv_tktttdg.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_thoattkdg);
            this.groupBox3.Controls.Add(this.btn_tkdg);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_thoattkdg
            // 
            this.btn_thoattkdg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoattkdg.Location = new System.Drawing.Point(259, 67);
            this.btn_thoattkdg.Name = "btn_thoattkdg";
            this.btn_thoattkdg.Size = new System.Drawing.Size(138, 38);
            this.btn_thoattkdg.TabIndex = 1;
            this.btn_thoattkdg.Text = "Thoát";
            this.btn_thoattkdg.UseVisualStyleBackColor = false;
            this.btn_thoattkdg.Click += new System.EventHandler(this.btn_thoattkdg_Click);
            // 
            // btn_tkdg
            // 
            this.btn_tkdg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_tkdg.Location = new System.Drawing.Point(65, 67);
            this.btn_tkdg.Name = "btn_tkdg";
            this.btn_tkdg.Size = new System.Drawing.Size(138, 38);
            this.btn_tkdg.TabIndex = 0;
            this.btn_tkdg.Text = "Tìm kiếm";
            this.btn_tkdg.UseVisualStyleBackColor = false;
            // 
            // frmtkdocgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmtkdocgia";
            this.Text = "Form tìm kiếm độc giả";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tktttdg)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nstk;
        private System.Windows.Forms.TextBox txt_tendgtk;
        private System.Windows.Forms.TextBox txt_madgtk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_tktttdg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_thoattkdg;
        private System.Windows.Forms.Button btn_tkdg;
    }
}