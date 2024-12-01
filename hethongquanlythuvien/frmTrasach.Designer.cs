namespace hethongquanlythuvien
{
    partial class frmTrasach
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tras = new System.Windows.Forms.Button();
            this.dtt_nhtt = new System.Windows.Forms.DateTimePicker();
            this.dtt_nmt = new System.Windows.Forms.DateTimePicker();
            this.txt_slmt = new System.Windows.Forms.TextBox();
            this.txt_madgt = new System.Windows.Forms.TextBox();
            this.txt_mapmt = new System.Windows.Forms.TextBox();
            this.txt_mast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ttts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_tras);
            this.groupBox1.Controls.Add(this.dtt_nhtt);
            this.groupBox1.Controls.Add(this.dtt_nmt);
            this.groupBox1.Controls.Add(this.txt_slmt);
            this.groupBox1.Controls.Add(this.txt_madgt);
            this.groupBox1.Controls.Add(this.txt_mapmt);
            this.groupBox1.Controls.Add(this.txt_mast);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1097, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin trả sách";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_thoat.Location = new System.Drawing.Point(914, 154);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(138, 38);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_tras
            // 
            this.btn_tras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_tras.Location = new System.Drawing.Point(914, 67);
            this.btn_tras.Name = "btn_tras";
            this.btn_tras.Size = new System.Drawing.Size(138, 38);
            this.btn_tras.TabIndex = 12;
            this.btn_tras.Text = "Trả sách";
            this.btn_tras.UseVisualStyleBackColor = false;
            // 
            // dtt_nhtt
            // 
            this.dtt_nhtt.Location = new System.Drawing.Point(635, 196);
            this.dtt_nhtt.Name = "dtt_nhtt";
            this.dtt_nhtt.Size = new System.Drawing.Size(200, 30);
            this.dtt_nhtt.TabIndex = 11;
            // 
            // dtt_nmt
            // 
            this.dtt_nmt.Location = new System.Drawing.Point(635, 134);
            this.dtt_nmt.Name = "dtt_nmt";
            this.dtt_nmt.Size = new System.Drawing.Size(200, 30);
            this.dtt_nmt.TabIndex = 10;
            // 
            // txt_slmt
            // 
            this.txt_slmt.Location = new System.Drawing.Point(633, 67);
            this.txt_slmt.Name = "txt_slmt";
            this.txt_slmt.Size = new System.Drawing.Size(100, 30);
            this.txt_slmt.TabIndex = 9;
            // 
            // txt_madgt
            // 
            this.txt_madgt.Location = new System.Drawing.Point(187, 193);
            this.txt_madgt.Name = "txt_madgt";
            this.txt_madgt.Size = new System.Drawing.Size(226, 30);
            this.txt_madgt.TabIndex = 8;
            // 
            // txt_mapmt
            // 
            this.txt_mapmt.Location = new System.Drawing.Point(187, 65);
            this.txt_mapmt.Name = "txt_mapmt";
            this.txt_mapmt.Size = new System.Drawing.Size(226, 30);
            this.txt_mapmt.TabIndex = 7;
            // 
            // txt_mast
            // 
            this.txt_mast.Location = new System.Drawing.Point(187, 131);
            this.txt_mast.Name = "txt_mast";
            this.txt_mast.Size = new System.Drawing.Size(226, 30);
            this.txt_mast.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày hẹn trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày mượn :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã độc giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu mượn:";
            // 
            // dgv_ttts
            // 
            this.dgv_ttts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttts.Location = new System.Drawing.Point(12, 268);
            this.dgv_ttts.Name = "dgv_ttts";
            this.dgv_ttts.RowHeadersWidth = 51;
            this.dgv_ttts.RowTemplate.Height = 24;
            this.dgv_ttts.Size = new System.Drawing.Size(1097, 268);
            this.dgv_ttts.TabIndex = 1;
            // 
            // frmTrasach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1121, 548);
            this.Controls.Add(this.dgv_ttts);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTrasach";
            this.Text = "frmTrasach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtt_nhtt;
        private System.Windows.Forms.DateTimePicker dtt_nmt;
        private System.Windows.Forms.TextBox txt_slmt;
        private System.Windows.Forms.TextBox txt_madgt;
        private System.Windows.Forms.TextBox txt_mapmt;
        private System.Windows.Forms.TextBox txt_mast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tras;
        private System.Windows.Forms.DataGridView dgv_ttts;
    }
}