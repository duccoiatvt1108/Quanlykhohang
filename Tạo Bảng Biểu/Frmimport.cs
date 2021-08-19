using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Tạo_Bảng_Biểu
{
    public partial class Frmimport : Form
    {
        public Frmimport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FrmAddNCC frmAddNCC = new FrmAddNCC();
            frmAddNCC.ShowDialog();
            frmAddNCC.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Thông tin bạn đang nhập có thể không được lưu lại, bạn có thực sự muốn thoát", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                this.Close();
                FrmMenu frmMenu = new FrmMenu();
                frmMenu.Show();
                frmMenu.WindowState = FormWindowState.Maximized;
            }
            else
            {
                
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            printPreviewDialog1.ShowInTaskbar = true;
            printPreviewDialog1.MinimizeBox = true;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }
    }
}
