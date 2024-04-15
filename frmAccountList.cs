using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace MAB_EDP_Csharp_DemoProgram
{
    public partial class frmAccountList : Form
    {
        public frmAccountList()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string templatePath = Application.StartupPath + @"\reportTemplate\userlist.xlsx";
            DateTime now = DateTime.Now;
            string mydate = now.ToString("yyyy-mm-dd-hh-mm-ss");
            string newFilePath = Application.StartupPath + @"\generatedreports\report-" + mydate + ".xlsx";
            ExportDataGridViewToExcelTemplate(DGusers, templatePath, newFilePath);
        }

        private void frmAccountList_Load(object sender, EventArgs e)
        {
            var dbManager = new DBManager();
            DGusers.DataSource =  dbManager.GetAllUsers();
        }
        private void ExportDataGridViewToExcelTemplate(DataGridView dgv, string templatePath, string newfilepath)
        {
            // Start Excel and get Application object.
            var excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not installed!");
                return;
            }

            // Make the app invisible (optional)
            excelApp.Visible = false;

            // Open the template workbook
            Excel.Workbook workbook = excelApp.Workbooks.Open(templatePath);
            Excel.Worksheet worksheet = workbook.Worksheets[1] as Excel.Worksheet;

            // Assuming the template has headers and we start from row 2
            int rowIndex = 3;

            // Iterate through the rows of the DataGridView
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow) // Skip the new row in DataGridView
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        // Excel cells are 1-based
                        worksheet.Cells[rowIndex, col + 1] = row.Cells[col].Value.ToString();
                    }
                    rowIndex++;
                }
            }

            MessageBox.Show($"Data exported to {newfilepath}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            excelApp.Visible = true;
            

            workbook.SaveAs(newfilepath);
            workbook.PrintPreview();

            // Clean up
            //workbook.Close(false);
            //excelApp.Quit();

            //Marshal.ReleaseComObject(worksheet);
            //Marshal.ReleaseComObject(workbook);
            //Marshal.ReleaseComObject(excelApp);

            
        }

    }
}
