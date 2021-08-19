using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tạo_Bảng_Biểu
{
    public partial class FrmExport : Form
    {
        public FrmExport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddNCC frmAddNCC = new FrmAddNCC();
            frmAddNCC.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Dữ Liệu Đang Nhập Có Thể Không Được Lưu! \n Bạn có thực sự muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(r== DialogResult.OK)
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

        }

        private void FrmExport_Load(object sender, EventArgs e)
        {

        }
    }
}
