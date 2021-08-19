
namespace Tạo_Bảng_Biểu
{
    partial class FrmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBNhanvien = new System.Windows.Forms.ComboBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtXacnhanmatkhau = new System.Windows.Forms.TextBox();
            this.pBusernamecorrect = new System.Windows.Forms.PictureBox();
            this.pBuserwrong = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pBpasswordWrong = new System.Windows.Forms.PictureBox();
            this.pBpasswordCorrect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBusernamecorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBuserwrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpasswordWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpasswordCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password:";
            // 
            // cBNhanvien
            // 
            this.cBNhanvien.FormattingEnabled = true;
            this.cBNhanvien.Location = new System.Drawing.Point(157, 22);
            this.cBNhanvien.Name = "cBNhanvien";
            this.cBNhanvien.Size = new System.Drawing.Size(625, 23);
            this.cBNhanvien.TabIndex = 1;
            this.cBNhanvien.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(157, 75);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(432, 23);
            this.txtTaikhoan.TabIndex = 2;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(157, 128);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(432, 23);
            this.txtMatkhau.TabIndex = 2;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtXacnhanmatkhau
            // 
            this.txtXacnhanmatkhau.Location = new System.Drawing.Point(157, 181);
            this.txtXacnhanmatkhau.Name = "txtXacnhanmatkhau";
            this.txtXacnhanmatkhau.Size = new System.Drawing.Size(432, 23);
            this.txtXacnhanmatkhau.TabIndex = 2;
            this.txtXacnhanmatkhau.UseSystemPasswordChar = true;
            this.txtXacnhanmatkhau.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pBusernamecorrect
            // 
            this.pBusernamecorrect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBusernamecorrect.BackgroundImage")));
            this.pBusernamecorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBusernamecorrect.Location = new System.Drawing.Point(596, 66);
            this.pBusernamecorrect.Name = "pBusernamecorrect";
            this.pBusernamecorrect.Size = new System.Drawing.Size(43, 41);
            this.pBusernamecorrect.TabIndex = 3;
            this.pBusernamecorrect.TabStop = false;
            // 
            // pBuserwrong
            // 
            this.pBuserwrong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBuserwrong.BackgroundImage")));
            this.pBuserwrong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBuserwrong.Location = new System.Drawing.Point(645, 66);
            this.pBuserwrong.Name = "pBuserwrong";
            this.pBuserwrong.Size = new System.Drawing.Size(43, 41);
            this.pBuserwrong.TabIndex = 3;
            this.pBuserwrong.TabStop = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(707, 66);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 41);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ForeColor = System.Drawing.Color.Lime;
            this.btnCreate.Location = new System.Drawing.Point(92, 261);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(148, 41);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Tạo Tài Khoản";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(503, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 41);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pBpasswordWrong
            // 
            this.pBpasswordWrong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBpasswordWrong.BackgroundImage")));
            this.pBpasswordWrong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBpasswordWrong.Location = new System.Drawing.Point(645, 172);
            this.pBpasswordWrong.Name = "pBpasswordWrong";
            this.pBpasswordWrong.Size = new System.Drawing.Size(43, 41);
            this.pBpasswordWrong.TabIndex = 5;
            this.pBpasswordWrong.TabStop = false;
            // 
            // pBpasswordCorrect
            // 
            this.pBpasswordCorrect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBpasswordCorrect.BackgroundImage")));
            this.pBpasswordCorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBpasswordCorrect.Location = new System.Drawing.Point(596, 172);
            this.pBpasswordCorrect.Name = "pBpasswordCorrect";
            this.pBpasswordCorrect.Size = new System.Drawing.Size(43, 41);
            this.pBpasswordCorrect.TabIndex = 6;
            this.pBpasswordCorrect.TabStop = false;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 333);
            this.Controls.Add(this.pBpasswordWrong);
            this.Controls.Add(this.pBpasswordCorrect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.pBuserwrong);
            this.Controls.Add(this.pBusernamecorrect);
            this.Controls.Add(this.txtXacnhanmatkhau);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.cBNhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmAddUser";
            this.Text = "Thêm Tài Khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddUser_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBusernamecorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBuserwrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpasswordWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpasswordCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBNhanvien;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtXacnhanmatkhau;
        private System.Windows.Forms.PictureBox pBusernamecorrect;
        private System.Windows.Forms.PictureBox pBuserwrong;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pBpasswordWrong;
        private System.Windows.Forms.PictureBox pBpasswordCorrect;
    }
}