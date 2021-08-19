using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Tạo_Bảng_Biểu
{
    public partial class FrmStaff : Form
    {
        public static string STT = "";
        public static string Permission = "";
        public FrmStaff()
        {
            InitializeComponent();
        }

        

        private void FrmStaff_Load(object sender, EventArgs e)
        {
            txtTennv.ReadOnly = true;
            txtManv.ReadOnly = true;
            rBNam.Enabled = false;
            rBNu.Enabled = false;
            dTPngaysinh.Enabled = false;
            groupBox1.Enabled = false;
            cBPhongban.Enabled = false;
            cBBophan.Enabled = false;
            txtEmail.ReadOnly = true;
            txtLienhe.ReadOnly = true;
            txtDiachi.ReadOnly = true;

            string Querry = "SELECT mapq FROM EMPLOYEE WHERE manv = '"+Form2.idnv+"'";
            SqlConnection con = new SqlConnection(ConnectData.ConnectString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Querry, con);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                STT = reader[0].ToString();
            }
            if (STT == "1 ")
            {
                Permission = "Admin";
            }
            else
            {
                Permission = "Employee";
            }
            //MessageBox.Show(Permission);
            con.Close();
            con.Open();
            SqlConnection con1 = new SqlConnection(ConnectData.ConnectString);
            string Querry1 = "Select EMPLOYEE.manv,EMPLOYEE.tennv,EMPLOYEE.ns,MALE.tengt,ROOM.tenphong,EMPLOYEE.email,EMPLOYEE.sdt,EMPLOYEE.dc,PERMISSION.tenpq " +
                "from EMPLOYEE left join PERMISSION on EMPLOYEE.mapq = PERMISSION.mapq " +
                "left join MALE on MALE.magt = EMPLOYEE.gt left join ROOM on ROOM.maphong = EMPLOYEE.maphong";
            SqlCommand cmd1 = new SqlCommand(Querry1);
            SqlDataAdapter da = new SqlDataAdapter(Querry1, con1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGVNhanvien.DataSource = ds.Tables[0];
            dGVNhanvien.Columns[0].DataPropertyName = "manv";
            dGVNhanvien.Columns[0].HeaderText = "Mã NV";
            dGVNhanvien.Columns[0].Name = "manv";
            dGVNhanvien.Columns[0].Width = 100;

            dGVNhanvien.Columns[1].DataPropertyName = "tennv";
            dGVNhanvien.Columns[1].HeaderText = "Tên NV";
            dGVNhanvien.Columns[1].Name = "tennv";
            dGVNhanvien.Columns[1].Width = 250;

            dGVNhanvien.Columns[2].DataPropertyName = "ns";
            dGVNhanvien.Columns[2].HeaderText = "Ngày Sinh";
            dGVNhanvien.Columns[2].Name = "ns";
            dGVNhanvien.Columns[2].Width = 150;

            dGVNhanvien.Columns[3].DataPropertyName = "tengt";
            dGVNhanvien.Columns[3].HeaderText = "Giới tính";
            dGVNhanvien.Columns[3].Name = "gt";
            dGVNhanvien.Columns[3].Width = 50;

            dGVNhanvien.Columns[4].DataPropertyName = "tenphong";
            dGVNhanvien.Columns[4].HeaderText = "Phòng Ban";
            dGVNhanvien.Columns[4].Name = "tenphong";
            dGVNhanvien.Columns[4].Width = 200;

            dGVNhanvien.Columns[5].DataPropertyName = "email";
            dGVNhanvien.Columns[5].HeaderText = "Email";
            dGVNhanvien.Columns[5].Name = "email";
            dGVNhanvien.Columns[5].Width = 300;

            dGVNhanvien.Columns[6].DataPropertyName = "sdt";
            dGVNhanvien.Columns[6].HeaderText = "Số điện thoại";
            dGVNhanvien.Columns[6].Name = "sdt";
            dGVNhanvien.Columns[6].Width = 100;

            dGVNhanvien.Columns[7].DataPropertyName = "dc";
            dGVNhanvien.Columns[7].HeaderText = "Địa Chỉ";
            dGVNhanvien.Columns[7].Name = "dc";
            dGVNhanvien.Columns[7].Width = 300;

            dGVNhanvien.Columns[8].DataPropertyName = "tenpq";
            dGVNhanvien.Columns[8].HeaderText = "Phân Quyền";
            dGVNhanvien.Columns[8].Name = "mapq";
            dGVNhanvien.Columns[8].Width = 100;

            con.Close();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            frmMenu.WindowState = FormWindowState.Maximized;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnAdduser.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnResetPassword.Enabled = false;

            txtTennv.ReadOnly = false;
            txtManv.ReadOnly = false;
            rBNam.Enabled = true;
            rBNu.Enabled = true;
            dTPngaysinh.Enabled = true;
            groupBox1.Enabled = true;
            cBPhongban.Enabled = true;
            cBBophan.Enabled = true;
            txtEmail.ReadOnly = false;
            txtLienhe.ReadOnly = false;
            txtDiachi.ReadOnly = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(Permission == "Admin")
            {
                FrmAddUser frmAddUser = new FrmAddUser();
                frmAddUser.ShowDialog();
                frmAddUser.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền Admin để tạo tài khoản","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void FrmStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            frmMenu.WindowState = FormWindowState.Maximized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTennv.Clear();
            txtManv.Clear();
            
        }

        private void btnSaveandFinish_Click(object sender, EventArgs e)
        {

        }

        private void rBEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rBEmployee.Checked == true)
            {
                cBAdd.Checked = true;
                cBImport.Checked = true;
                cBUpdate.Checked = true;
            }
            else
            {
                cBAdd.Checked = false;
                cBImport.Checked = false;
                cBUpdate.Checked = false;
            }
        }

        private void btnAddExcelFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddStaff_Option frm = new FrmAddStaff_Option();
            frm.Show();
            frm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dGVNhanvien_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
