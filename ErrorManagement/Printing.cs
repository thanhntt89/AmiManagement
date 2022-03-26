using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Excel = Microsoft.Office.Interop.Excel;

namespace ErrorManagement
{
    public partial class Printing : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Printing()
        {
            InitializeComponent();
        }

        private void Printing_Load(object sender, EventArgs e)
        {
            try
            {
                this.fixGroupTableAdapter.Fill(this.amiReportDataSet.FixGroup);

                cboForwardTo.DisplayMember = this.amiReportDataSet.FixGroup.FixGroupNameColumn.ColumnName;
                cboForwardTo.ValueMember = this.amiReportDataSet.FixGroup.FixGroupIdColumn.ColumnName;

                cboForwardTo.DataSource = this.amiReportDataSet.FixGroup;

                cboForwardTo.SelectedIndex = 1;

                this.cboForwardTo.SelectedIndexChanged += new System.EventHandler(this.cboOrg_SelectedIndexChanged);
                this.cboOrg.SelectedIndexChanged += new System.EventHandler(this.cboOrg_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectIndex = int.Parse(cboForwardTo.SelectedValue.ToString());
                if (cboOrg.SelectedValue != null)
                    this.getErrorExportTableAdapter.Fill(this.amiReportDataSet.GetErrorExport, selectIndex, cboOrg.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog save = new FolderBrowserDialog();
            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                ExportToExcel(save.SelectedPath);
                MessageBox.Show("Export Successful", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboForwardTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboForwardTo.SelectedIndex == -1)
                    return;
                int selectIndex = int.Parse(cboForwardTo.SelectedValue.ToString());
                this.getOrgTableAdapter.FillBy(this.amiReportDataSet.GetOrg, selectIndex);
                cboOrg_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportToExcel(string folderExport)
        {
            string excelPath = Application.StartupPath + "\\Template\\ErrorExportTemplate.xlsx";

            if (!File.Exists(excelPath))
            {
                MessageBox.Show("Template file doesn't exist!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }

            // Copy file to user application
            string userApplicaitonPath = Application.StartupPath + "\\Temp\\ErrorExportTemplate.xlsx";
            if (!File.Exists(userApplicaitonPath))
                File.Copy(excelPath, userApplicaitonPath);

            Excel.ApplicationClass app = new Excel.ApplicationClass();
            app.Visible = false;
            app.DisplayAlerts = false;

            Excel.Workbook workbook = app.Workbooks.Open(userApplicaitonPath,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            int rowInExcel = 2;// Hàng bắt đầu thêm dữ liệu là hàng thứ 2

            Excel.Worksheet worksheet = null;
            string nextTime = string.Empty;
            int count = 0;
            worksheet = (Excel.Worksheet)workbook.Sheets[1];

            int total = dtgData.Rows.Count;

            for (int i = 0; i < total; i++)
            {
                worksheet.Cells[rowInExcel, 1] = dtgData.Rows[i].Cells[dcuCodeDataGridViewTextBoxColumn.Index].Value.ToString();//DCU
                worksheet.Cells[rowInExcel, 2] = dtgData.Rows[i].Cells[measurementPointDataGridViewTextBoxColumn.Index].Value.ToString();//PE
                worksheet.Cells[rowInExcel, 3] = dtgData.Rows[i].Cells[LocationColumn.Index].Value.ToString();//LO
                worksheet.Cells[rowInExcel, 4] = cboOrg.Text;// GROUPNAM
                worksheet.Cells[rowInExcel, 5] = dtgData.Rows[i].Cells[errorDateDataGridViewTextBoxColumn.Index].Value.ToString();
                worksheet.Cells[rowInExcel, 6] = dtgData.Rows[i].Cells[fixContentSuggestionDataGridViewTextBoxColumn.Index].Value.ToString();               
                rowInExcel++;
            }

            workbook.Save();
            // Sau khi thêm xong vào file Excel tiến hành đóng file lại và kill tiến trình này
            workbook.Close(Microsoft.Office.Interop.Excel.XlSaveAction.xlSaveChanges, Type.Missing, Type.Missing);

            app.Quit();


            int hWnd = app.Application.Hwnd;
            uint processID;
            GetWindowThreadProcessId((IntPtr)hWnd, out processID);
            Process[] procs = Process.GetProcessesByName("EXCEL");
            foreach (Process p in procs)
            {
                if (p.Id == processID)
                    p.Kill();
            }

            Marshal.FinalReleaseComObject(app);

            // Copy to local
            if (folderExport != string.Empty)
            {
                string copyFile = Path.Combine(folderExport, Path.GetFileName(userApplicaitonPath));
                if (File.Exists(copyFile))
                    copyFile = Path.Combine(folderExport, Path.GetFileName(userApplicaitonPath).Insert(0, DateTime.Now.ToString("HH-mm-ss-")));
                File.Move(userApplicaitonPath, copyFile);
                File.Delete(userApplicaitonPath);
            }
        }


        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
    }
}