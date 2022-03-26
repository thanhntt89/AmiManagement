using System;
using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using AmiOperationLib;
using OperationDTO.AmiOperationDataSet.MeterTypeDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ErrorListDataSetTableAdapters;
using System.Drawing;
using OperationDTO.AmiOperationDataSet.FixGroupDataSetTableAdapters;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using OperationDTO.AmiOperationDataSet.ErrorCodeDataSetTableAdapters;
using System.ComponentModel;
using AmiOperationManagement.Main;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UCMeasurementPoitMissingMessage : UserControlBase
    {
        private ErrorCodeDataSet.ErrorCodeDataTable errorCodeDataTable = new ErrorCodeDataSet.ErrorCodeDataTable();
        private ErrorCodeTableAdapter errorCodeTableAdapter = new ErrorCodeTableAdapter();

        private FixGroupDataSet.FixGroupDataTable fixGroupDataTable = new FixGroupDataSet.FixGroupDataTable();
        private FixGroupTableAdapter fixGroupTableAdapter = new FixGroupTableAdapter();

        private ErrorListDataSet.MeasurementPoitGroupDataTable measurmentPoitGroupDataTable = new ErrorListDataSet.MeasurementPoitGroupDataTable();
        private MeasurementPoitGroupTableAdapter measurmentPoitGroupTableAdapter = new MeasurementPoitGroupTableAdapter();

        private MeterTypeTableAdapter meterTypeTableAdapter = new MeterTypeTableAdapter();
        private MeterTypeDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeDataSet.MeterTypeDataTable();
        private ErrorListDataSet.GetErrorListDataTable getErrorListDataTable = new ErrorListDataSet.GetErrorListDataTable();
        private GetErrorListTableAdapter getErrorListTableAdapter = new GetErrorListTableAdapter();

        private BackgroundWorker bgwExport;
        private bool IsExportSusscess;
        private Waitting waitting = null;

        public UCMeasurementPoitMissingMessage()
        {
            InitializeComponent();
            dtErrorTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 59, 0);
        }

        private void LoadErrorDefine()
        {
            try
            {
                this.errorCodeTableAdapter.Fill(this.errorCodeDataTable);

                var newRow = this.errorCodeDataTable.NewErrorCodeRow();

                newRow.ErrorCode = string.Empty;
                newRow.ErrorName = Constant.SELECT_ALL_TEXT;
                this.errorCodeDataTable.Rows.InsertAt(newRow, 0);

                cboErrorList.DataSource = this.errorCodeDataTable;
                cboErrorList.DisplayMember = this.errorCodeDataTable.ErrorNameColumn.ToString();
                cboErrorList.ValueMember = this.errorCodeDataTable.ErrorCodeColumn.ToString();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPoitMissingMessage - LoadErrorDefine. Chi tiết:", ex);
                MessageBox.Show("Không tải được dữ liệu hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMeasurementPoitGroup()
        {
            try
            {
                this.measurmentPoitGroupTableAdapter.Fill(this.measurmentPoitGroupDataTable);

                var newRow = this.measurmentPoitGroupDataTable.NewMeasurementPoitGroupRow();

                newRow.GroupCode = string.Empty;
                newRow.GroupName = Constant.SELECT_ALL_TEXT;
                this.measurmentPoitGroupDataTable.Rows.InsertAt(newRow, 0);

                cboGroupName.DataSource = this.measurmentPoitGroupDataTable;
                cboGroupName.DisplayMember = this.measurmentPoitGroupDataTable.GroupNameColumn.ToString();
                cboGroupName.ValueMember = this.measurmentPoitGroupDataTable.GroupCodeColumn.ToString();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPoitMissingMessage - LoadMeasurementPoitGroup. Chi tiết:", ex);
                MessageBox.Show("Lỗi tải dữ liệu không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFixGroup()
        {
            try
            {
                this.fixGroupTableAdapter.Fill(this.fixGroupDataTable);

                var newRow = this.fixGroupDataTable.NewFixGroupRow();
                newRow.FixGroupId = -1;
                newRow.FixGroupName = Constant.SELECT_ALL_TEXT;
                this.fixGroupDataTable.Rows.InsertAt(newRow, 0);
                cboForwardTo.DataSource = this.fixGroupDataTable;
                cboForwardTo.DisplayMember = this.fixGroupDataTable.FixGroupNameColumn.ToString();
                cboForwardTo.ValueMember = this.fixGroupDataTable.FixGroupIdColumn.ToString();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPoitMissingMessage - LoadFixGroup. Chi tiết:", ex);
                MessageBox.Show("Lỗi tải dữ liệu không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchMeasurementPointMissingMessage()
        {
            chkAll.Checked = false;
            lblTotalCount.Text = "0";
            try
            {
                dtgErrorList.Rows.Clear();

                string dcuType = null;
                if (cboMeterType.SelectedIndex > 0)
                    dcuType = cboMeterType.SelectedValue.ToString();

                int status = -1;
                if (cboStatus.SelectedIndex == 1)
                    status = Constant.IsNotFixed;
                else if (cboStatus.SelectedIndex == 2)
                    status = Constant.IsFixed;

                int fixGroup = int.Parse(cboForwardTo.SelectedValue.ToString());

                if (dtErrorTime.Value != DateTime.MinValue)
                    this.getErrorListTableAdapter.FillByCondition(this.getErrorListDataTable, status, dtErrorTime.Value, dcuType, fixGroup, cboGroupName.SelectedIndex < 1 ? null : cboGroupName.SelectedValue.ToString(), cboErrorList.SelectedIndex < 1 ? null : cboErrorList.SelectedValue.ToString());
                else
                    this.getErrorListTableAdapter.FillByCondition(this.getErrorListDataTable, status, null, dcuType, fixGroup, cboGroupName.SelectedIndex < 1 ? null : cboGroupName.SelectedValue.ToString(), cboErrorList.SelectedIndex < 1 ? null : cboErrorList.SelectedValue.ToString());

                if (this.getErrorListDataTable.Rows.Count == 0)
                {
                    return;
                }

                // Hiện thị trên datagridview
                foreach (ErrorListDataSet.GetErrorListRow item in this.getErrorListDataTable.Rows)
                {
                    dtgErrorList.Rows.Add(false, item.CreatedDate.ToString("dd/MM/yyyy HH:mm:ss"), item.DcuCode, item.MeterTypeId, item.MeasurementPoint, item.Location, item.GroupName, item.ErrorCode, item.ErrorName, item.IsFixGroupIdNull() ? string.Empty : item.FixGroupName, item.IsFixDateNull() ? string.Empty : item.FixDate.ToString("dd/MM/yyyy"), item.IsFixContentSuggestionNull() ? string.Empty : item.FixContentSuggestion, item.IsFixed, null, null, item.ErrorId);
                }

                lblTotalCount.Text = this.getErrorListDataTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPoitMissingMessage - SearchMeasurementPointMissingMessage. Chi tiết:", ex);
                MessageBox.Show("Lỗi không xử lý được dữ liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCMeasurementPoitMissingMessage_Load(object sender, EventArgs e)
        {
            this.LoadErrorDefine();
            this.LoadMeterType();
            this.LoadFixGroup();
            this.LoadMeasurementPoitGroup();
            this.SearchMeasurementPointMissingMessage();
        }

        private void LoadMeterType()
        {
            try
            {
                int rst = this.meterTypeTableAdapter.Fill(this.meterTypeDataTable);
                if (rst == -1)
                {
                    MessageBox.Show("Lỗi: Không tải được dữ liệu loại đồng hồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newRow = this.meterTypeDataTable.NewMeterTypeRow();
                newRow.Note = Constant.SELECT_ALL_TEXT;
                newRow.MeterTypeName = string.Empty;

                this.meterTypeDataTable.Rows.InsertAt(newRow, 0);
                cboMeterType.DataSource = this.meterTypeDataTable;
                cboMeterType.DisplayMember = this.meterTypeDataTable.NoteColumn.ToString();
                cboMeterType.ValueMember = this.meterTypeDataTable.MeterTypeNameColumn.ToString();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPoitMissingMessage - LoadMeterType. Chi tiết:", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgErrorList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgErrorList.Rows.Count; i++)
            {
                dtgErrorList.Rows[i].Cells[ChooseCol.Index].Value = chkAll.Checked;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void Export()
        {
            int total = dtgErrorList.Rows.Count;

            int maxCheck = 0;
            for (int i = 0; i < total; i++)
            {
                if ((bool)dtgErrorList.Rows[i].Cells[ChooseCol.Index].Value)
                    maxCheck++;
            }

            if (maxCheck == 0)
            {
                MessageBox.Show("Bạn phải chọn dữ liệu để thao tác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FolderBrowserDialog save = new FolderBrowserDialog();
            if (save.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            this.IsExportSusscess = false;
            prgBar.Visible = true;
            if (bgwExport == null)
            {
                bgwExport = new BackgroundWorker();
                bgwExport.RunWorkerCompleted += bgwExport_RunWorkerCompleted;
                bgwExport.DoWork += bgwExport_DoWork;
            }

            bgwExport.RunWorkerAsync(save.SelectedPath);
            if (waitting == null)
                waitting = new Waitting();
            waitting.ShowDialog();
        }

        void bgwExport_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ExportToExcel((string)e.Argument);
            }
            catch
            {
                this.IsExportSusscess = false;
            }
        }

        void bgwExport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            waitting.CloseWaiting();
            prgBar.Visible = false;
            prgBar.Value = 0;
            if (this.IsExportSusscess)
                MessageBox.Show("Xuất phiếu xử lý thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Lỗi xuất phiếu xử lý không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ExportToExcel(string folderExport)
        {
            int total = dtgErrorList.Rows.Count;

            int maxCheck = 0;
            for (int i = 0; i < total; i++)
            {
                if ((bool)dtgErrorList.Rows[i].Cells[ChooseCol.Index].Value)
                    maxCheck++;
            }

            string excelPath = Application.StartupPath + "\\Template\\ErrorExportTemplate.xlsx";

            this.IsExportSusscess = false;

            if (!File.Exists(excelPath))
            {
                MessageBox.Show("Tệp tin mẫu không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Copy file to user application
            string userApplicaitonPath = Application.StartupPath + "\\Temp\\ErrorExportTemplate.xlsx";

            // Create folder
            DirectoryInfo direct = new DirectoryInfo(Path.GetDirectoryName(userApplicaitonPath));
            if (!direct.Exists)
                direct.Create();

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

            prgBar.Maximum = maxCheck;

            for (int i = 0; i < total; i++)
            {
                if (!(bool)dtgErrorList.Rows[i].Cells[ChooseCol.Index].Value)
                    continue;
                MethodInvoker methodInvokerDelegate = delegate()
               {
                   worksheet.Cells[rowInExcel, 1] = dtgErrorList.Rows[i].Cells[DcuCodeCol.Index].Value.ToString();//DCU
                   worksheet.Cells[rowInExcel, 2] = dtgErrorList.Rows[i].Cells[MeasurementPointCol.Index].Value.ToString();//PE
                   worksheet.Cells[rowInExcel, 3] = dtgErrorList.Rows[i].Cells[LocationCol.Index].Value.ToString();//LO
                   worksheet.Cells[rowInExcel, 4] = dtgErrorList.Rows[i].Cells[GroupNameCol.Index].Value.ToString();// GROUPNAM
                   worksheet.Cells[rowInExcel, 5] = dtgErrorList.Rows[i].Cells[ErrorNameCol.Index].Value.ToString();
                   worksheet.Cells[rowInExcel, 6] = dtgErrorList.Rows[i].Cells[FixContentCol.Index].Value.ToString();
                   rowInExcel++;
                   prgBar.Value = rowInExcel;
               };

                if (this.InvokeRequired)
                    this.Invoke(methodInvokerDelegate);
                else
                    methodInvokerDelegate();
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

            this.IsExportSusscess = true;
        }

        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private void btnClean_Click(object sender, EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            cboErrorList.SelectedIndex = 0;
            cboForwardTo.SelectedIndex = 0;
            cboGroupName.SelectedIndex = 0;
            cboMeterType.SelectedIndex = 0;
            cboMeterType.SelectedIndex = 0;
            dtErrorTime.Text = null;

            btnSearch_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMeasurementPointMissingMessage();
        }
    }
}
