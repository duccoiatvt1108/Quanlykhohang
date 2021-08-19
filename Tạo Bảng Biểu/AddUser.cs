using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tạo_Bảng_Biểu
{
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("'" + cBNhanvien.SelectedValue.ToString() + "'");
            SqlConnection con = new SqlConnection(ConnectData.ConnectString);
            SqlDataReader reader;
            string querry = "INSERT INTO USERS(username,userpassword,FKmanv) values ('" + txtTaikhoan.Text + "','" + Hash.HashPass(txtXacnhanmatkhau.Text.ToString()) + "','" + cBNhanvien.SelectedValue.ToString() + "') ";
            SqlCommand cmd = new SqlCommand(querry, con);
            if (txtMatkhau.Text == txtXacnhanmatkhau.Text)
            {
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (reader.Read())
                    {

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed! \n" + ex.Message, "Information!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(txtXacnhanmatkhau.Text == txtMatkhau.Text)
            {
                pBpasswordCorrect.Visible = true;
                pBpasswordWrong.Visible = false;
            }
            else
            {
                pBpasswordCorrect.Visible = false;
                pBpasswordWrong.Visible = true;
            }
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            pBpasswordCorrect.Visible = false;
            pBpasswordWrong.Visible = false;
            pBusernamecorrect.Visible = false;
            pBuserwrong.Visible = false;
            SqlConnection con = new SqlConnection(ConnectData.ConnectString);
            con.Open();
            string querry = "SELECT manv, tennv FROM EMPLOYEE";
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataAdapter da = new SqlDataAdapter(querry, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cBNhanvien.DataSource = ds.Tables[0];
            cBNhanvien.ValueMember = "manv";
            cBNhanvien.DisplayMember = "tennv";
            cBNhanvien.Enabled = true;
            this.cBNhanvien.SelectedIndex = -1;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void FrmAddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult r1 = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r1 == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(r == DialogResult.OK)
            {
                this.Hide();
            }
            else
            {

            }
        }
    }
}
