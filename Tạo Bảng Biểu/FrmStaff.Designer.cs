
namespace Tạo_Bảng_Biểu
{
    partial class FrmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaff));
            this.rBAdmin = new System.Windows.Forms.RadioButton();
            this.rBEmployee = new System.Windows.Forms.RadioButton();
            this.cBAdd = new System.Windows.Forms.CheckBox();
            this.btnAdduser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBImport = new System.Windows.Forms.CheckBox();
            this.cBUpdate = new System.Windows.Forms.CheckBox();
            this.rBNu = new System.Windows.Forms.RadioButton();
            this.rBNam = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.dTPngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cBPhongban = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLienhe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dGVNhanvien = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveandFinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.cBBophan = new System.Windows.Forms.ComboBox();
            this.btnAddExcelFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // rBAdmin
            // 
            this.rBAdmin.AutoSize = true;
            this.rBAdmin.Location = new System.Drawing.Point(6, 60);
            this.rBAdmin.Name = "rBAdmin";
            this.rBAdmin.Size = new System.Drawing.Size(61, 19);
            this.rBAdmin.TabIndex = 1;
            this.rBAdmin.TabStop = true;
            this.rBAdmin.Text = "Admin";
            this.rBAdmin.UseVisualStyleBackColor = true;
            // 
            // rBEmployee
            // 
            this.rBEmployee.AutoSize = true;
            this.rBEmployee.Location = new System.Drawing.Point(6, 23);
            this.rBEmployee.Name = "rBEmployee";
            this.rBEmployee.Size = new System.Drawing.Size(80, 19);
            this.rBEmployee.TabIndex = 1;
            this.rBEmployee.TabStop = true;
            this.rBEmployee.Text = "Nhân Viên";
            this.rBEmployee.UseVisualStyleBackColor = true;
            this.rBEmployee.CheckedChanged += new System.EventHandler(this.rBEmployee_CheckedChanged);
            // 
            // cBAdd
            // 
            this.cBAdd.AutoSize = true;
            this.cBAdd.Location = new System.Drawing.Point(111, 23);
            this.cBAdd.Name = "cBAdd";
            this.cBAdd.Size = new System.Drawing.Size(56, 19);
            this.cBAdd.TabIndex = 0;
            this.cBAdd.Text = "Thêm";
            this.cBAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdduser
            // 
            this.btnAdduser.Location = new System.Drawing.Point(543, 402);
            this.btnAdduser.Name = "btnAdduser";
            this.btnAdduser.Size = new System.Drawing.Size(138, 35);
            this.btnAdduser.TabIndex = 49;
            this.btnAdduser.Text = "Tạo Username";
            this.btnAdduser.UseVisualStyleBackColor = true;
            this.btnAdduser.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBAdmin);
            this.groupBox1.Controls.Add(this.rBEmployee);
            this.groupBox1.Controls.Add(this.cBImport);
            this.groupBox1.Controls.Add(this.cBUpdate);
            this.groupBox1.Controls.Add(this.cBAdd);
            this.groupBox1.Location = new System.Drawing.Point(14, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 105);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân Quyền";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cBImport
            // 
            this.cBImport.AutoSize = true;
            this.cBImport.Location = new System.Drawing.Point(312, 24);
            this.cBImport.Name = "cBImport";
            this.cBImport.Size = new System.Drawing.Size(55, 19);
            this.cBImport.TabIndex = 0;
            this.cBImport.Text = "Nhập";
            this.cBImport.UseVisualStyleBackColor = true;
            // 
            // cBUpdate
            // 
            this.cBUpdate.AutoSize = true;
            this.cBUpdate.Location = new System.Drawing.Point(217, 23);
            this.cBUpdate.Name = "cBUpdate";
            this.cBUpdate.Size = new System.Drawing.Size(45, 19);
            this.cBUpdate.TabIndex = 0;
            this.cBUpdate.Text = "Sửa";
            this.cBUpdate.UseVisualStyleBackColor = true;
            // 
            // rBNu
            // 
            this.rBNu.AutoSize = true;
            this.rBNu.Location = new System.Drawing.Point(154, 196);
            this.rBNu.Name = "rBNu";
            this.rBNu.Size = new System.Drawing.Size(41, 19);
            this.rBNu.TabIndex = 47;
            this.rBNu.TabStop = true;
            this.rBNu.Text = "Nữ";
            this.rBNu.UseVisualStyleBackColor = true;
            this.rBNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rBNam
            // 
            this.rBNam.AutoSize = true;
            this.rBNam.Location = new System.Drawing.Point(84, 196);
            this.rBNam.Name = "rBNam";
            this.rBNam.Size = new System.Drawing.Size(51, 19);
            this.rBNam.TabIndex = 46;
            this.rBNam.TabStop = true;
            this.rBNam.Text = "Nam";
            this.rBNam.UseVisualStyleBackColor = true;
            this.rBNam.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Giới Tính:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dTPngaysinh
            // 
            this.dTPngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dTPngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPngaysinh.Location = new System.Drawing.Point(84, 144);
            this.dTPngaysinh.Name = "dTPngaysinh";
            this.dTPngaysinh.Size = new System.Drawing.Size(266, 23);
            this.dTPngaysinh.TabIndex = 44;
            this.dTPngaysinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cBPhongban
            // 
            this.cBPhongban.FormattingEnabled = true;
            this.cBPhongban.Location = new System.Drawing.Point(1032, 51);
            this.cBPhongban.Name = "cBPhongban";
            this.cBPhongban.Size = new System.Drawing.Size(613, 23);
            this.cBPhongban.TabIndex = 43;
            this.cBPhongban.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 351);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(632, 23);
            this.txtSearch.TabIndex = 41;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(1032, 250);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(613, 23);
            this.txtDiachi.TabIndex = 40;
            this.txtDiachi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1032, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(613, 23);
            this.txtEmail.TabIndex = 39;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtLienhe
            // 
            this.txtLienhe.Location = new System.Drawing.Point(1032, 195);
            this.txtLienhe.Name = "txtLienhe";
            this.txtLienhe.Size = new System.Drawing.Size(613, 23);
            this.txtLienhe.TabIndex = 38;
            this.txtLienhe.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tìm Kiếm:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(84, 94);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(395, 23);
            this.txtManv.TabIndex = 36;
            this.txtManv.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(84, 51);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(632, 23);
            this.txtTennv.TabIndex = 37;
            this.txtTennv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(960, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Địa Chỉ:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dGVNhanvien
            // 
            this.dGVNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNhanvien.Location = new System.Drawing.Point(12, 471);
            this.dGVNhanvien.Name = "dGVNhanvien";
            this.dGVNhanvien.RowTemplate.Height = 25;
            this.dGVNhanvien.Size = new System.Drawing.Size(1816, 534);
            this.dGVNhanvien.TabIndex = 20;
            this.dGVNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dGVNhanvien.SelectionChanged += new System.EventHandler(this.dGVNhanvien_SelectionChanged);
            // 
            // btnBack
            // 
            this.btnBack.AutoEllipsis = true;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 27);
            this.btnBack.TabIndex = 19;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(955, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Mã NV:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(749, 344);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 35);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Tìm ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(955, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bộ Phận:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(955, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phòng Ban:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ngày sinh:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên NV:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSaveandFinish
            // 
            this.btnSaveandFinish.Location = new System.Drawing.Point(1628, 402);
            this.btnSaveandFinish.Name = "btnSaveandFinish";
            this.btnSaveandFinish.Size = new System.Drawing.Size(136, 35);
            this.btnSaveandFinish.TabIndex = 24;
            this.btnSaveandFinish.Text = "Lưu và Hoàn tất";
            this.btnSaveandFinish.UseVisualStyleBackColor = true;
            this.btnSaveandFinish.Click += new System.EventHandler(this.btnSaveandFinish_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1433, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1238, 402);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(801, 402);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(92, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(955, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Liên Hệ:";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(996, 402);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(122, 35);
            this.btnResetPassword.TabIndex = 25;
            this.btnResetPassword.Text = "Reset Mật Khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.button7_Click);
            // 
            // cBBophan
            // 
            this.cBBophan.FormattingEnabled = true;
            this.cBBophan.Location = new System.Drawing.Point(1032, 94);
            this.cBBophan.Name = "cBBophan";
            this.cBBophan.Size = new System.Drawing.Size(613, 23);
            this.cBBophan.TabIndex = 43;
            this.cBBophan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAddExcelFile
            // 
            this.btnAddExcelFile.Location = new System.Drawing.Point(287, 402);
            this.btnAddExcelFile.Name = "btnAddExcelFile";
            this.btnAddExcelFile.Size = new System.Drawing.Size(136, 35);
            this.btnAddExcelFile.TabIndex = 26;
            this.btnAddExcelFile.Text = "Nhập DS Nhân Viên";
            this.btnAddExcelFile.UseVisualStyleBackColor = true;
            this.btnAddExcelFile.Click += new System.EventHandler(this.btnAddExcelFile_Click);
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1017);
            this.Controls.Add(this.btnAdduser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rBNu);
            this.Controls.Add(this.rBNam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dTPngaysinh);
            this.Controls.Add(this.cBBophan);
            this.Controls.Add(this.cBPhongban);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLienhe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dGVNhanvien);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveandFinish);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddExcelFile);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Name = "FrmStaff";
            this.Text = "Nhân Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStaff_FormClosed);
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBAdmin;
        private System.Windows.Forms.RadioButton rBEmployee;
        private System.Windows.Forms.CheckBox cBAdd;
        private System.Windows.Forms.Button btnAdduser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cBImport;
        private System.Windows.Forms.CheckBox cBUpdate;
        private System.Windows.Forms.RadioButton rBNu;
        private System.Windows.Forms.RadioButton rBNam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dTPngaysinh;
        private System.Windows.Forms.ComboBox cBPhongban;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLienhe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dGVNhanvien;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveandFinish;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.ComboBox cBBophan;
        private System.Windows.Forms.Button btnAddExcelFile;
    }
}