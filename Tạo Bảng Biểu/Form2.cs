using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Tạo_Bảng_Biểu
{
    public partial class Form2 : Form
    {
        
        public static string idnv = "";
        
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string Querry = "SELECT username, userpassword, FKmanv FROM USERS WHERE username ='"+txtusername.Text+"'";
            string ConnectString = @"Data Source=DESKTOP-0MIFM7F\SQLEXPRESS;Initial Catalog=QLK;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Querry,con);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                idnv = reader[2].ToString();
                //MessageBox.Show(reader[0].ToString() + reader[1].ToString()+"\n" +Hash.HashPass(txtpassword.Text).ToString());
                if (reader[1].ToString() == Hash.HashPass(txtpassword.Text).ToString())
                {

                    DialogResult r = MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        this.Hide();
                        FrmMenu frmMenu = new FrmMenu();
                        frmMenu.Show();
                        frmMenu.WindowState = FormWindowState.Maximized;
                    }

                }
                else
                {
                    DialogResult result = MessageBox.Show("Tài khoản hoặc Mật khẩu không chính xác vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        txtusername.Focus();
                    } 
                }
            }
            con.Close();
            
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                idnv = "";
                
                this.Close();
            }
            else
            {

            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                if(txtusername.Text!= null)
                {
                    btnDangNhap_Click(sender,e);
                }
                else
                {
                    MessageBox.Show("Nhập đầy đủ tài khoản và mật khẩu!");
                    txtusername.Focus();
                }
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if(Convert.ToInt32(e.KeyCode) == 13)
            {
                if (txtpassword.Text != null)
                {
                    btnDangNhap_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Nhập đầy đủ tài khoản và mật khẩu!");
                    txtusername.Focus();
                }
            }
        }
    }
}
