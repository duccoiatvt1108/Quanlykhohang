using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tạo_Bảng_Biểu
{
    public partial class FrmAddNCC : Form
    {
        
        public FrmAddNCC()
        {
            InitializeComponent();
        }

        private void FrmAddNCC_Load(object sender, EventArgs e)
        {
            FrmAddNCC frmAddNCC = new FrmAddNCC();
            frmAddNCC.MaximizeBox = false;
        }

        private void button7_Click(object sender, EventArgs e)
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
    }
}
