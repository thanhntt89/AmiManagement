using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ErrorCodeDataSetTableAdapters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UCErrorDefine : UserControlBase
    {
        private ErrorCodeDataSet.ErrorCodeDataTable errorCodeDataTable = new ErrorCodeDataSet.ErrorCodeDataTable();
        private ErrorCodeTableAdapter errorCodeTableAdapter = new ErrorCodeTableAdapter();

        public UCErrorDefine()
        {
            InitializeComponent();
        }

        private void LoadErrorCode()
        {
            try
            {
                this.errorCodeTableAdapter.Fill(this.errorCodeDataTable);
                this.dtgErrorDefine.DataSource = this.errorCodeDataTable;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorDefine - Load bảng định nghĩa lỗi. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgErrorDefine_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.errorCodeTableAdapter.Update(this.errorCodeDataTable);
                MessageBox.Show("Lưu thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (ErrorCodeDataSet.ErrorCodeRow item in this.errorCodeDataTable.Rows)
                {
                    // Log system histories
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorDefine);
                    UserSession.Action = SystemResource.User_Action_Update;
                    UserSession.Notes = "Cập nhật bảng định nghĩa lỗi - Mã lỗi: " + item.ErrorCode + " - Tên lỗi: " + item.ErrorName;
                    this.InsertHistories();
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorDefine - Lưu thông tin bảng định nghĩa lỗi. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCErrorDefine_Load(object sender, EventArgs e)
        {
            LoadErrorCode();
        }

        private void btnFixErrorStep_Click(object sender, EventArgs e)
        {
            FixErrorStep fixErrorStep = new FixErrorStep();
            fixErrorStep.ShowDialog();
        }
    }
}
