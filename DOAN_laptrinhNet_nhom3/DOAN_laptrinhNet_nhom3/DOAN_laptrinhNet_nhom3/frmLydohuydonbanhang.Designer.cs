
namespace DOAN_laptrinhNet_nhom3
{
    partial class frmLydohuydonbanhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLydohuydonbanhang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rbLDHuy = new System.Windows.Forms.RadioButton();
            this.rbMaHD = new System.Windows.Forms.RadioButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnThuLai = new System.Windows.Forms.Button();
            this.btnXemLichSu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.rbLDHuy);
            this.groupBox1.Controls.Add(this.rbMaHD);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(104, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 149);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Violet;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(666, 88);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(140, 50);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // rbLDHuy
            // 
            this.rbLDHuy.AutoSize = true;
            this.rbLDHuy.Location = new System.Drawing.Point(582, 46);
            this.rbLDHuy.Name = "rbLDHuy";
            this.rbLDHuy.Size = new System.Drawing.Size(266, 29);
            this.rbLDHuy.TabIndex = 3;
            this.rbLDHuy.TabStop = true;
            this.rbLDHuy.Text = "Tìm kiếm theo lý do hủy đơn";
            this.rbLDHuy.UseVisualStyleBackColor = true;
            // 
            // rbMaHD
            // 
            this.rbMaHD.AutoSize = true;
            this.rbMaHD.Location = new System.Drawing.Point(112, 46);
            this.rbMaHD.Name = "rbMaHD";
            this.rbMaHD.Size = new System.Drawing.Size(252, 29);
            this.rbMaHD.TabIndex = 2;
            this.rbMaHD.TabStop = true;
            this.rbMaHD.Text = "Tìm kiếm theo mã hóa đơn";
            this.rbMaHD.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(112, 96);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(533, 31);
            this.txtTim.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(104, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 251);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(407, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "LÝ DO HỦY ĐƠN HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTroLai.FlatAppearance.BorderSize = 0;
            this.btnTroLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTroLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.Color.White;
            this.btnTroLai.Image = ((System.Drawing.Image)(resources.GetObject("btnTroLai.Image")));
            this.btnTroLai.Location = new System.Drawing.Point(979, 567);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(130, 51);
            this.btnTroLai.TabIndex = 15;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTroLai.UseVisualStyleBackColor = false;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnThuLai
            // 
            this.btnThuLai.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThuLai.FlatAppearance.BorderSize = 0;
            this.btnThuLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuLai.ForeColor = System.Drawing.Color.White;
            this.btnThuLai.Image = ((System.Drawing.Image)(resources.GetObject("btnThuLai.Image")));
            this.btnThuLai.Location = new System.Drawing.Point(598, 567);
            this.btnThuLai.Name = "btnThuLai";
            this.btnThuLai.Size = new System.Drawing.Size(130, 51);
            this.btnThuLai.TabIndex = 14;
            this.btnThuLai.Text = "Thử lại";
            this.btnThuLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThuLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThuLai.UseVisualStyleBackColor = false;
            this.btnThuLai.Click += new System.EventHandler(this.btnThuLai_Click);
            // 
            // btnXemLichSu
            // 
            this.btnXemLichSu.BackColor = System.Drawing.Color.SlateBlue;
            this.btnXemLichSu.FlatAppearance.BorderSize = 0;
            this.btnXemLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLichSu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemLichSu.ForeColor = System.Drawing.Color.White;
            this.btnXemLichSu.Image = ((System.Drawing.Image)(resources.GetObject("btnXemLichSu.Image")));
            this.btnXemLichSu.Location = new System.Drawing.Point(104, 567);
            this.btnXemLichSu.Name = "btnXemLichSu";
            this.btnXemLichSu.Size = new System.Drawing.Size(306, 51);
            this.btnXemLichSu.TabIndex = 13;
            this.btnXemLichSu.Text = "Xem lịch sử hóa đơn bán hàng";
            this.btnXemLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemLichSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemLichSu.UseVisualStyleBackColor = false;
            this.btnXemLichSu.Click += new System.EventHandler(this.btnXemLichSu_Click);
            // 
            // frmLydohuydonbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1212, 705);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnThuLai);
            this.Controls.Add(this.btnXemLichSu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "frmLydohuydonbanhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lý do hủy đơn hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rbLDHuy;
        private System.Windows.Forms.RadioButton rbMaHD;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnThuLai;
        private System.Windows.Forms.Button btnXemLichSu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}