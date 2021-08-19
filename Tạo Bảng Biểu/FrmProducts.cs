using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tạo_Bảng_Biểu
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            frmMenu.WindowState = FormWindowState.Maximized;
        }

        private void FrmProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            frmMenu.WindowState = FormWindowState.Maximized;
        }
    }
}
