using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
//using Range = Microsoft.Office.Interop.Excel.Range;

namespace Tạo_Bảng_Biểu
{
    
    public partial class FrmAddStaff_Option : Form
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        string Stt = "";
        string fileName = "";
        public FrmAddStaff_Option()
        {
            InitializeComponent();
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(dataGridView1_RowStateChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stt = "Normal";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File to Edit";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Excel File|*.xlsx;*.xls";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                if (fileName.Trim() != "")
                {
                    Excel2Grid(fileName);
                }
            }
        }

        private void Excel2Grid(string path)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(path);
            xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int iRow, iCol;

            for(iCol = 1; iCol < xlWorkSheet.Columns.Count; iCol++)
            {
                if(xlWorkSheet.Cells[1,iCol].value == null)
                {
                    break;
                }
                else
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = xlWorkSheet.Cells[1, iCol].value;
                    int colIndex = dataGridView1.Columns.Add(col);
                }
            }
            //Add button at the last of cell
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Text = "Save Data";
            btn.Name = "btnSave";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);

            //Add row to the grid using excel data
            for(iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)
            {
                if(xlWorkSheet.Cells[iRow,1].value == null)
                {
                    break;
                }
                else
                {
                    //Create a string array using the values in each row of the sheet
                    string[] row = new string[] { xlWorkSheet.Cells[iRow, 1].value.ToString(),
                        xlWorkSheet.Cells[iRow,2].value.ToString(),
                        xlWorkSheet.Cells[iRow,3].value.ToString(),
                        xlWorkSheet.Cells[iRow,4].value.ToString(),
                        xlWorkSheet.Cells[iRow,5].value.ToString(),
                        xlWorkSheet.Cells[iRow,6].value.ToString(),
                        xlWorkSheet.Cells[iRow,7].value.ToString(),
                        xlWorkSheet.Cells[iRow,8].value.ToString()};


                    //Add a new row to the grid using the array data
                    dataGridView1.Rows.Add(row);
                }
            }

            xlWorkBook.Close();
            xlApp.Quit();

            //Clean Cache
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }            
        }

        //Save modified or new data to the Excel Sheet


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddStaff_Option frm = new FrmAddStaff_Option();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(e.Row.Cells[0].Value != null)
            {
                e.Row.Cells[0].Style.ForeColor = Color.Gray;
                e.Row.Cells[0].ReadOnly = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
