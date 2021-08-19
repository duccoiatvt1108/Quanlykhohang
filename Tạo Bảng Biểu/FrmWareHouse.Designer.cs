
namespace Tạo_Bảng_Biểu
{
    partial class FrmWareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWareHouse));
            this.lbTenkho = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmakho = new System.Windows.Forms.TextBox();
            this.txtLienhe = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.dGVKhohang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuvahoantat = new System.Windows.Forms.Button();
            this.txttenkho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cBnguoiphutrach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhohang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenkho
            // 
            this.lbTenkho.AutoSize = true;
            this.lbTenkho.Location = new System.Drawing.Point(34, 65);
            this.lbTenkho.Name = "lbTenkho";
            this.lbTenkho.Size = new System.Drawing.Size(55, 15);
            this.lbTenkho.TabIndex = 0;
            this.lbTenkho.Text = "Tên Kho: ";
            this.lbTenkho.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa Chỉ: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1123, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Kho: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Người Phụ Trách: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button6
            // 
            this.button6.AutoEllipsis = true;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(12, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 27);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1123, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liên Hệ: ";
            // 
            // txtmakho
            // 
            this.txtmakho.Location = new System.Drawing.Point(1192, 62);
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.Size = new System.Drawing.Size(610, 23);
            this.txtmakho.TabIndex = 6;
            // 
            // txtLienhe
            // 
            this.txtLienhe.Location = new System.Drawing.Point(1192, 102);
            this.txtLienhe.Name = "txtLienhe";
            this.txtLienhe.Size = new System.Drawing.Size(610, 23);
            this.txtLienhe.TabIndex = 6;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(141, 150);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(679, 23);
            this.txtdiachi.TabIndex = 6;
            // 
            // dGVKhohang
            // 
            this.dGVKhohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVKhohang.Location = new System.Drawing.Point(34, 375);
            this.dGVKhohang.Name = "dGVKhohang";
            this.dGVKhohang.RowTemplate.Height = 25;
            this.dGVKhohang.Size = new System.Drawing.Size(1768, 630);
            this.dGVKhohang.TabIndex = 7;
            this.dGVKhohang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVKhohang_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(32, 332);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(436, 332);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(840, 332);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1244, 332);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuuvahoantat
            // 
            this.btnLuuvahoantat.Location = new System.Drawing.Point(1648, 332);
            this.btnLuuvahoantat.Name = "btnLuuvahoantat";
            this.btnLuuvahoantat.Size = new System.Drawing.Size(154, 23);
            this.btnLuuvahoantat.TabIndex = 8;
            this.btnLuuvahoantat.Text = "Lưu Và Hoàn Tất";
            this.btnLuuvahoantat.UseVisualStyleBackColor = true;
            this.btnLuuvahoantat.Click += new System.EventHandler(this.btnLuuvahoantat_Click);
            // 
            // txttenkho
            // 
            this.txttenkho.Location = new System.Drawing.Point(141, 62);
            this.txttenkho.Name = "txttenkho";
            this.txttenkho.Size = new System.Drawing.Size(679, 23);
            this.txttenkho.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm Kiếm:";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(141, 241);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(679, 23);
            this.txtTimkiem.TabIndex = 6;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(861, 229);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(125, 44);
            this.btnTimkiem.TabIndex = 8;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // cBnguoiphutrach
            // 
            this.cBnguoiphutrach.FormattingEnabled = true;
            this.cBnguoiphutrach.Location = new System.Drawing.Point(142, 101);
            this.cBnguoiphutrach.Name = "cBnguoiphutrach";
            this.cBnguoiphutrach.Size = new System.Drawing.Size(678, 23);
            this.cBnguoiphutrach.TabIndex = 9;
            // 
            // FrmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1017);
            this.Controls.Add(this.cBnguoiphutrach);
            this.Controls.Add(this.btnLuuvahoantat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dGVKhohang);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttenkho);
            this.Controls.Add(this.txtLienhe);
            this.Controls.Add(this.txtmakho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTenkho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmWareHouse_FormClosed);
            this.Load += new System.EventHandler(this.FrmWareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVKhohang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmakho;
        private System.Windows.Forms.TextBox txtLienhe;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.DataGridView dGVKhohang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuvahoantat;
        private System.Windows.Forms.TextBox txttenkho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cBnguoiphutrach;
    }
}