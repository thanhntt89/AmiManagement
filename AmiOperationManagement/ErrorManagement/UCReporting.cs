using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ReportErrorDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.MeasurementPointGroupDataSetTableAdapters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UCReporting : UserControlBase
    {
        private ReportErrorDataSet.GetReportErrorDataTable getReportErrorDataTable = new ReportErrorDataSet.GetReportErrorDataTable();
        private GetReportErrorTableAdapter getReportErrorTableAdapter = new GetReportErrorTableAdapter();

        private MeasurementPointGroupDataSet.MeasurementPointGroupDataTable measurementPointGroupDataTable = new MeasurementPointGroupDataSet.MeasurementPointGroupDataTable();
        private MeasurementPointGroupTableAdapter measurementPointGroupTableAdapter = new MeasurementPointGroupTableAdapter();

        public UCReporting()
        {
            InitializeComponent();
            this.dtToDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 0, 0);
        }

        private void LoadMesurementPoit()
        {
            try
            {
                this.measurementPointGroupTableAdapter.FillByIsDeleted(this.measurementPointGroupDataTable, !Constant.IsDeleted);

                cboOrg.DataSource = this.measurementPointGroupDataTable;
                cboOrg.DisplayMember = this.measurementPointGroupDataTable.NameColumn.ToString();
                cboOrg.ValueMember = this.measurementPointGroupDataTable.MeasurementPointGroupIdColumn.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không tải được dữ liệu từ máy chủ. Chi tiết:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchError()
        {
            dtgReport.Rows.Clear();
            try
            {
                this.getReportErrorTableAdapter.FillByGroupCodeAndCreatedDate(this.getReportErrorDataTable, cboOrg.SelectedValue.ToString(), dtToDate.Value);

                foreach (ReportErrorDataSet.GetReportErrorRow item in this.getReportErrorDataTable.Rows)
                {
                    dtgReport.Rows.Add(item.DcuCode, item.MeterTypeId, item.MeasurementPoint, item.IsLocationNull() ? string.Empty : item.Location, item.ErrorName, item.StartDate.ToString("dd-MM-yyyy"), item.Total);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCReporting - SearchError. Chi tiết:", ex);
                MessageBox.Show("Lỗi không tải được dữ liệu từ máy chủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCReporting_Load(object sender, EventArgs e)
        {
            LoadMesurementPoit();
        }

        private void cboOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchError();
        }

        private void dtgReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchError();
        }
    }
}
