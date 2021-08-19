using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tạo_Bảng_Biểu
{
    public partial class FrmWareHouse : Form
    {
        public FrmWareHouse()
        {
            InitializeComponent();
        }

        private void FrmWareHouse_Load(object sender, EventArgs e)
        {
            txtdiachi.ReadOnly = true;
            txtLienhe.ReadOnly = true;
            txtmakho.ReadOnly = true;
            txttenkho.ReadOnly = true;
            cBnguoiphutrach.Enabled = false;
            dGVKhohang.ReadOnly = true;
            SqlConnection con = new SqlConnection(ConnectData.ConnectString);
            con.Open();
            string querry = "Select WAREHOUSE.makho,WAREHOUSE.tenkho,EMPLOYEE.tennv,WAREHOUSE.diachikho FROM WAREHOUSE INNER JOIN EMPLOYEE ON WAREHOUSE.manv=EMPLOYEE.manv";
            SqlCommand cmd = new SqlCommand(querry);
            SqlDataAdapter da = new SqlDataAdapter(querry, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGVKhohang.DataSource = ds.Tables[0];
            dGVKhohang.Columns[0].DataPropertyName = "makho";
            dGVKhohang.Columns[0].HeaderText = "Mã Kho";
            dGVKhohang.Columns[0].Name = "makho";
            dGVKhohang.Columns[0].Width = 100;

            dGVKhohang.Columns[1].DataPropertyName = "tenkho";
            dGVKhohang.Columns[1].HeaderText = "Tên Kho";
            dGVKhohang.Columns[1].Name = "tenkho";
            dGVKhohang.Columns[1].Width = 250;

            dGVKhohang.Columns[2].DataPropertyName = "tennv";
            dGVKhohang.Columns[2].HeaderText = "Người Phụ Trách";
            dGVKhohang.Columns[2].Name = "tennv";
            dGVKhohang.Columns[2].Width = 250;

            dGVKhohang.Columns[3].DataPropertyName = "diachikho";
            dGVKhohang.Columns[3].HeaderText = "Địa Chỉ Kho";
            dGVKhohang.Columns[3].Name = "diachikho";
            dGVKhohang.Columns[3].Width = 300;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            frmMenu.WindowState = FormWindowState.Maximized;
        }

        private void FrmWareHouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            frmMenu.WindowState = FormWindowState.Maximized;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtdiachi.ReadOnly = false;
            txtLienhe.ReadOnly = false;
            txtmakho.ReadOnly = false;
            txttenkho.ReadOnly = false;
            cBnguoiphutrach.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtdiachi.ReadOnly = false;
            txtLienhe.ReadOnly = false;
            txtmakho.ReadOnly = false;
            txttenkho.ReadOnly = false;
            cBnguoiphutrach.Enabled = true;
        }

        private void dGVKhohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow dtgr = dGVKhohang.Rows[e.RowIndex];
                txttenkho.Text = dtgr.Cells[1].Value.ToString();
                txtmakho.Text = dtgr.Cells[0].Value.ToString();
                txtdiachi.Text = dtgr.Cells[3].Value.ToString();
                txtLienhe.Text = dtgr.Cells[2].Value.ToString();
                cBnguoiphutrach.Text = txtLienhe.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtLienhe.Clear();
            txtdiachi.Clear();
            txtmakho.Clear();
            txttenkho.Clear();
            cBnguoiphutrach.Text = "";
            txtdiachi.ReadOnly = true;
            txtLienhe.ReadOnly = true;
            txtmakho.ReadOnly = true;
            txttenkho.ReadOnly = true;
            cBnguoiphutrach.Enabled = false;
            dGVKhohang.ReadOnly = true;
        }

        private void btnLuuvahoantat_Click(object sender, EventArgs e)
        {

        }
    }
}
