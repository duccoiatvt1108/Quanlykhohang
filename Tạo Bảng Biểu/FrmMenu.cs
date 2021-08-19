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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectData.ConnectString);
            con.Open();
            string Querry = "Select tennv FROM EMPLOYEE where manv = '" + Form2.idnv + "'";
            SqlCommand cmd = new SqlCommand(Querry, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbName.Text = "Hi, " + reader[0].ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProducts frmProducts = new FrmProducts();
            frmProducts.Show();
            frmProducts.WindowState = FormWindowState.Maximized;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmWareHouse frmWareHouse = new FrmWareHouse();
            frmWareHouse.Show();
            frmWareHouse.WindowState = FormWindowState.Maximized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStaff frmStaff = new FrmStaff();
            frmStaff.Show();
            frmStaff.WindowState = FormWindowState.Maximized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRoom frmRoom = new FrmRoom();
            frmRoom.Show();
            frmRoom.WindowState = FormWindowState.Maximized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAccountInf frmAccountInf = new FrmAccountInf();
            frmAccountInf.Show();
            frmAccountInf.WindowState = FormWindowState.Maximized;
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmimport frmimport = new Frmimport();
            frmimport.Show();
            frmimport.WindowState = FormWindowState.Maximized;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmimport frmimport = new Frmimport();
            frmimport.Show();
            frmimport.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProducts frmProducts = new FrmProducts();
            frmProducts.Show();
            frmProducts.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmWareHouse frmWareHouse = new FrmWareHouse();
            frmWareHouse.Show();
            frmWareHouse.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStaff frmStaff = new FrmStaff();
            frmStaff.Show();
            frmStaff.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRoom frmRoom = new FrmRoom();
            frmRoom.Show();
            frmRoom.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAccountInf frmAccountInf = new FrmAccountInf();
            frmAccountInf.Show();
            frmAccountInf.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmExport frmExport = new FrmExport();
            frmExport.Show();
            frmExport.WindowState = FormWindowState.Maximized;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmExport frmExport = new FrmExport();
            frmExport.Show();
            frmExport.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChangeWarehouse frmChangeWarehouse = new FrmChangeWarehouse();
            frmChangeWarehouse.Show();
            frmChangeWarehouse.WindowState = FormWindowState.Maximized;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmChangeWarehouse frmChangeWarehouse = new FrmChangeWarehouse();
            frmChangeWarehouse.Show();
            frmChangeWarehouse.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReport frmReport = new FrmReport();
            frmReport.Show();
            frmReport.WindowState = FormWindowState.Maximized;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReport frmReport = new FrmReport();
            frmReport.Show();
            frmReport.WindowState = FormWindowState.Maximized;
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn sẽ quay lại cổng đăng nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //this.Hide();
            //Form2 frmForm2 = new Form2();
            //frmForm2.Show();
            //frmForm2.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
