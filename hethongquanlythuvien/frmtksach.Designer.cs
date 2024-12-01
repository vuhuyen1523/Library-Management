namespace hethongquanlythuvien
{
    partial class frmtksach
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_matgtk = new System.Windows.Forms.TextBox();
            this.txt_matltk = new System.Windows.Forms.TextBox();
            this.txt_tenstk = new System.Windows.Forms.TextBox();
            this.txt_mastk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_tks = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_thoattk = new System.Windows.Forms.Button();
            this.btn_tk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tks)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_matgtk);
            this.groupBox1.Controls.Add(this.txt_matltk);
            this.groupBox1.Controls.Add(this.txt_tenstk);
            this.groupBox1.Controls.Add(this.txt_mastk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo thông tin sách";
            // 
            // txt_matgtk
            // 
            this.txt_matgtk.Location = new System.Drawing.Point(161, 210);
            this.txt_matgtk.Name = "txt_matgtk";
            this.txt_matgtk.Size = new System.Drawing.Size(216, 30);
            this.txt_matgtk.TabIndex = 7;
            // 
            // txt_matltk
            // 
            this.txt_matltk.Location = new System.Drawing.Point(161, 152);
            this.txt_matltk.Name = "txt_matltk";
            this.txt_matltk.Size = new System.Drawing.Size(216, 30);
            this.txt_matltk.TabIndex = 6;
            // 
            // txt_tenstk
            // 
            this.txt_tenstk.Location = new System.Drawing.Point(161, 101);
            this.txt_tenstk.Name = "txt_tenstk";
            this.txt_tenstk.Size = new System.Drawing.Size(216, 30);
            this.txt_tenstk.TabIndex = 5;
            // 
            // txt_mastk
            // 
            this.txt_mastk.Location = new System.Drawing.Point(161, 46);
            this.txt_mastk.Name = "txt_mastk";
            this.txt_mastk.Size = new System.Drawing.Size(216, 30);
            this.txt_mastk.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã tác giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_tks);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 430);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu";
            // 
            // dgv_tks
            // 
            this.dgv_tks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tks.Location = new System.Drawing.Point(18, 46);
            this.dgv_tks.Name = "dgv_tks";
            this.dgv_tks.RowHeadersWidth = 51;
            this.dgv_tks.RowTemplate.Height = 24;
            this.dgv_tks.Size = new System.Drawing.Size(498, 366);
            this.dgv_tks.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_thoattk);
            this.groupBox3.Controls.Add(this.btn_tk);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 160);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_thoattk
            // 
            this.btn_thoattk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoattk.Location = new System.Drawing.Point(265, 64);
            this.btn_thoattk.Name = "btn_thoattk";
            this.btn_thoattk.Size = new System.Drawing.Size(138, 38);
            this.btn_thoattk.TabIndex = 1;
            this.btn_thoattk.Text = "Thoát";
            this.btn_thoattk.UseVisualStyleBackColor = false;
            this.btn_thoattk.Click += new System.EventHandler(this.btn_thoattk_Click);
            // 
            // btn_tk
            // 
            this.btn_tk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_tk.Location = new System.Drawing.Point(53, 64);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(138, 38);
            this.btn_tk.TabIndex = 0;
            this.btn_tk.Text = "Tìm kiếm";
            this.btn_tk.UseVisualStyleBackColor = false;
            // 
            // frmtksach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmtksach";
            this.Text = "Form Tìm kiếm sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tks)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_matgtk;
        private System.Windows.Forms.TextBox txt_matltk;
        private System.Windows.Forms.TextBox txt_tenstk;
        private System.Windows.Forms.TextBox txt_mastk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_thoattk;
        private System.Windows.Forms.Button btn_tk;
        private System.Windows.Forms.DataGridView dgv_tks;
    }
}