using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tạo_Bảng_Biểu
{
    public partial class FrmRoom : Form
    {
        public FrmRoom()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRoom_Load(object sender, EventArgs e)
        {
            txtmaCty.ReadOnly = true;
            txtmaPhongban.ReadOnly = true;
            txttenPhongban.ReadOnly = true;
            dGVPhongban.ReadOnly = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txttenPhongban.ReadOnly = false;
            txtmaPhongban.ReadOnly = false;
            dGVPhongban.ReadOnly = true;
        }

        private void btnLuuvahoantat_Click(object sender, EventArgs e)
        {
            dGVPhongban.ReadOnly = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dGVPhongban.ReadOnly = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            frmMenu.WindowState = FormWindowState.Maximized;
        }

        private void FrmRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            frmMenu.WindowState = FormWindowState.Maximized;
        }
    }
}
