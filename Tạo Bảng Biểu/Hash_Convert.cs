using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tạo_Bảng_Biểu
{
    public partial class Hash_Convert : Form
    {
        public Hash_Convert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHashPass.Text = Hash.HashPass(txtPassWord.Text);
        }
    }
}
