using System.Drawing;
using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ErrorListDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ErrorCodeDataSetTableAdapters;
using System;
using AmiOperationLib;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UCModemFixbugHistories : UserControlBase
    {
        private ErrorCodeDataSet.ErrorCodeDataTable errorCodeDataTable = new ErrorCodeDataSet.ErrorCodeDataTable();
        private ErrorCodeTableAdapter errorCodeTableAdapter = new ErrorCodeTableAdapter();

        private ErrorListDataSet.GetErrorListDataTable getErrorListDataTable = new ErrorListDataSet.GetErrorListDataTable();
        private GetErrorListTableAdapter getErrorListTableAdapter = new GetErrorListTableAdapter();

        public UCModemFixbugHistories()
        {
            InitializeComponent();
        }

        public void LoadHistorisInfo(long errorId, string erroCode, string modemCode)
        {
            dtgFixbugHistories.Rows.Clear();
            try
            {
                this.errorCodeTableAdapter.Fill(this.errorCodeDataTable);
                lblErrorName.Text = this.errorCodeDataTable.FindByErrorCode(erroCode).ErrorCode + " - " + this.errorCodeDataTable.FindByErrorCode(erroCode).ErrorName;
                lblModemCode.Text = modemCode;
                this.getErrorListTableAdapter.FillByDcuCodeAndErrorCodeAndStatus(this.getErrorListDataTable, modemCode, erroCode, 1);

                foreach (ErrorListDataSet.GetErrorListRow item in this.getErrorListDataTable.Rows)
                {
                    dtgFixbugHistories.Rows.Add(item.MeasurementPoint, item.Location, item.MeterTypeId, item.CreatedDate, item.FixGroupName, item.FixContentSuggestion, item.FixDate, item.IsFixed);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCModemFixbugHistories - LoadHistorisInfo. Chi tiết:", ex);
                MessageBox.Show("Không tải được dữ liệu hệ thống. Bạn hãy kiểm tra lại kết nối mạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgFixbugHistories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
    }
}
