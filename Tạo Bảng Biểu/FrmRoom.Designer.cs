
namespace Tạo_Bảng_Biểu
{
    partial class FrmRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaCty = new System.Windows.Forms.TextBox();
            this.txtmaPhongban = new System.Windows.Forms.TextBox();
            this.cBLienhe = new System.Windows.Forms.ComboBox();
            this.cBtencty = new System.Windows.Forms.ComboBox();
            this.dGVPhongban = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVSdt = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuuvahoantat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txttenPhongban = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhongban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSdt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Công Ty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Công Ty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1269, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Liên Hệ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(902, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Phòng/Ban:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(902, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Phòng Ban: ";
            // 
            // txtmaCty
            // 
            this.txtmaCty.Location = new System.Drawing.Point(105, 94);
            this.txtmaCty.Name = "txtmaCty";
            this.txtmaCty.Size = new System.Drawing.Size(642, 23);
            this.txtmaCty.TabIndex = 1;
            // 
            // txtmaPhongban
            // 
            this.txtmaPhongban.Location = new System.Drawing.Point(1015, 94);
            this.txtmaPhongban.Name = "txtmaPhongban";
            this.txtmaPhongban.Size = new System.Drawing.Size(805, 23);
            this.txtmaPhongban.TabIndex = 1;
            // 
            // cBLienhe
            // 
            this.cBLienhe.FormattingEnabled = true;
            this.cBLienhe.Location = new System.Drawing.Point(1325, 248);
            this.cBLienhe.Name = "cBLienhe";
            this.cBLienhe.Size = new System.Drawing.Size(495, 23);
            this.cBLienhe.TabIndex = 2;
            // 
            // cBtencty
            // 
            this.cBtencty.FormattingEnabled = true;
            this.cBtencty.Location = new System.Drawing.Point(105, 48);
            this.cBtencty.Name = "cBtencty";
            this.cBtencty.Size = new System.Drawing.Size(642, 23);
            this.cBtencty.TabIndex = 3;
            // 
            // dGVPhongban
            // 
            this.dGVPhongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPhongban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVPhongban.Location = new System.Drawing.Point(45, 286);
            this.dGVPhongban.Name = "dGVPhongban";
            this.dGVPhongban.RowTemplate.Height = 25;
            this.dGVPhongban.Size = new System.Drawing.Size(948, 719);
            this.dGVPhongban.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã CTY";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Công Ty";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã Phòng Ban";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên Phòng Ban";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // dGVSdt
            // 
            this.dGVSdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSdt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dGVSdt.Location = new System.Drawing.Point(1023, 286);
            this.dGVSdt.Name = "dGVSdt";
            this.dGVSdt.RowTemplate.Height = 25;
            this.dGVSdt.Size = new System.Drawing.Size(797, 719);
            this.dGVSdt.TabIndex = 5;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tên Công Ty";
            this.Column6.Name = "Column6";
            this.Column6.Width = 250;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tên Phòng Ban";
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tên Người Trực";
            this.Column8.Name = "Column8";
            this.Column8.Width = 250;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Đầu Số";
            this.Column9.Name = "Column9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1023, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "*** Tìm Số Điện Thoại Nội Bộ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(58, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 38);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(293, 182);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 38);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(528, 182);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(763, 182);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 38);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuuvahoantat
            // 
            this.btnLuuvahoantat.Location = new System.Drawing.Point(998, 182);
            this.btnLuuvahoantat.Name = "btnLuuvahoantat";
            this.btnLuuvahoantat.Size = new System.Drawing.Size(175, 38);
            this.btnLuuvahoantat.TabIndex = 7;
            this.btnLuuvahoantat.Text = "Lưu và Hoàn Tất";
            this.btnLuuvahoantat.UseVisualStyleBackColor = true;
            this.btnLuuvahoantat.Click += new System.EventHandler(this.btnLuuvahoantat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1307, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 38);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.AutoEllipsis = true;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(12, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 27);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txttenPhongban
            // 
            this.txttenPhongban.Location = new System.Drawing.Point(1015, 48);
            this.txttenPhongban.Name = "txttenPhongban";
            this.txttenPhongban.Size = new System.Drawing.Size(805, 23);
            this.txttenPhongban.TabIndex = 1;
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1017);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuvahoantat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dGVSdt);
            this.Controls.Add(this.dGVPhongban);
            this.Controls.Add(this.cBtencty);
            this.Controls.Add(this.cBLienhe);
            this.Controls.Add(this.txttenPhongban);
            this.Controls.Add(this.txtmaPhongban);
            this.Controls.Add(this.txtmaCty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng Ban";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRoom_FormClosed);
            this.Load += new System.EventHandler(this.FrmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhongban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSdt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaCty;
        private System.Windows.Forms.TextBox txtmaPhongban;
        private System.Windows.Forms.ComboBox cBLienhe;
        private System.Windows.Forms.ComboBox cBtencty;
        private System.Windows.Forms.DataGridView dGVPhongban;
        private System.Windows.Forms.DataGridView dGVSdt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuuvahoantat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txttenPhongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}