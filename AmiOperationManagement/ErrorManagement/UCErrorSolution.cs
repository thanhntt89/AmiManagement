using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ErrorCodeDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ErrorListDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.FixErrorDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.FixGroupDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UCErrorSolution : UserControlBase
    {
        public event OperationEventHandle ReloadDataEvent;

        private FixGroupDataSet.FixGroupDataTable fixGroupDataTable = new FixGroupDataSet.FixGroupDataTable();
        private FixGroupTableAdapter fixGroupTableAdapter = new FixGroupTableAdapter();

        private ErrorListDataSet.ErrorListDataTable errorListDataTable = new ErrorListDataSet.ErrorListDataTable();
        private ErrorListTableAdapter errorListTableAdapter = new ErrorListTableAdapter();

        private FixErrorDataSet.GetFixErrorDataTable getFixErrorDataTable = new FixErrorDataSet.GetFixErrorDataTable();
        private GetFixErrorTableAdapter getFixErrorTableAdapter = new GetFixErrorTableAdapter();

        private FixErrorDataSet.FixErrorDataTable fixErrorDataTable = new FixErrorDataSet.FixErrorDataTable();
        private FixErrorTableAdapter fixErrorTableAdapter = new FixErrorTableAdapter();

        private ErrorCodeDataSet.ErrorCodeDataTable errorCodeDataTable = new ErrorCodeDataSet.ErrorCodeDataTable();
        private ErrorCodeTableAdapter errorCodeTableAdapter = new ErrorCodeTableAdapter();

        public List<ErrorEntity> errorList = new List<ErrorEntity>();

        private long currentErrorId = -1;
        private string modemCode = string.Empty;
        private string errorCode = string.Empty;
        private string errorName = string.Empty;
        private bool isValueChanged = false;
        private bool stopSelectAll = false;

        // Error selected
        private int selectIndex = -1;

        public UCErrorSolution()
        {
            InitializeComponent();
        }

        private void LoadErrorDefine()
        {
            try
            {
                this.errorCodeTableAdapter.Fill(this.errorCodeDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu hệ thống./nChi tiết lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFixGroup()
        {
            try
            {
                this.fixGroupTableAdapter.Fill(this.fixGroupDataTable);

                cboForwardTo.DataSource = this.fixGroupDataTable;
                cboForwardTo.DisplayMember = this.fixGroupDataTable.FixGroupNameColumn.ToString();
                cboForwardTo.ValueMember = this.fixGroupDataTable.FixGroupIdColumn.ToString();

                this.cboForwardTo.SelectedIndexChanged += new System.EventHandler(this.cboForwardTo_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu không thành công.\nChi tiết lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadErrorList(long currentErrorId)
        {
            this.currentErrorId = currentErrorId;
            try
            {
                this.errorListTableAdapter.FillByErrorId(this.errorListDataTable, this.currentErrorId);
                txtDcu.Text = this.errorListDataTable.First().DcuCode;
                txtErrorCode.Text = this.errorListDataTable.First().ErrorCode;
                lblErrorName.Text = this.errorCodeDataTable.FindByErrorCode(txtErrorCode.Text).ErrorName;
                lblPe.Text = this.errorListDataTable.First().MeasurementPoint;
                lblPEName.Text = this.errorListDataTable.First().Location;
                lblMeterType.Text = this.errorListDataTable.First().MeterTypeId;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorSolution - LoadErrorList. Chi tiết:", ex);
                MessageBox.Show("Không tải được dữ liệu từ máy chủ. Bạn hãy kiểm tra lại kết nối mạng hoặc thông tin kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!this.errorListDataTable.First().IsFixGroupIdNull())
                cboForwardTo.SelectedValue = this.errorListDataTable.First().FixGroupId;
            cboForwardTo_SelectedIndexChanged(null, null);
        }

        private void MoveUp()
        {
            try
            {
                if (selectIndex == 0 || selectIndex == dtgStepList.Rows.Count)
                    return;

                object curretnIndex = dtgStepList.Rows[selectIndex].Cells[FixStepIdCol.Index].Value;
                object curretnValue = dtgStepList.Rows[selectIndex].Cells[FixStepNameCol.Index].Value;
                object currentUsed = dtgStepList.Rows[selectIndex].Cells[IsUsedCol.Index].Value;

                object preIndex = dtgStepList.Rows[selectIndex - 1].Cells[FixStepIdCol.Index].Value;
                object preValue = dtgStepList.Rows[selectIndex - 1].Cells[FixStepNameCol.Index].Value;
                object preUsed = dtgStepList.Rows[selectIndex - 1].Cells[IsUsedCol.Index].Value;

                dtgStepList.Rows[selectIndex - 1].Cells[FixStepIdCol.Index].Value = curretnIndex;
                dtgStepList.Rows[selectIndex - 1].Cells[FixStepNameCol.Index].Value = curretnValue;
                dtgStepList.Rows[selectIndex - 1].Cells[IsUsedCol.Index].Value = currentUsed;

                dtgStepList.Rows[selectIndex].Cells[FixStepIdCol.Index].Value = preIndex;
                dtgStepList.Rows[selectIndex].Cells[FixStepNameCol.Index].Value = preValue;
                dtgStepList.Rows[selectIndex].Cells[IsUsedCol.Index].Value = preUsed;

                dtgStepList.ClearSelection();

                dtgStepList.Rows[selectIndex - 1].Selected = true;
                selectIndex = selectIndex - 1;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorSolution - MoveUp. Chi tiết:", ex);
            }
        }

        private void MoveDown()
        {
            try
            {
                if (selectIndex >= dtgStepList.Rows.Count - 1)
                    return;

                object curretnIndex = dtgStepList.Rows[selectIndex].Cells[FixStepIdCol.Index].Value;
                object curretnValue = dtgStepList.Rows[selectIndex].Cells[FixStepNameCol.Index].Value;
                object currentUsed = dtgStepList.Rows[selectIndex].Cells[IsUsedCol.Index].Value;

                object preIndex = dtgStepList.Rows[selectIndex + 1].Cells[FixStepIdCol.Index].Value;
                object preValue = dtgStepList.Rows[selectIndex + 1].Cells[FixStepNameCol.Index].Value;
                object preUsed = dtgStepList.Rows[selectIndex + 1].Cells[IsUsedCol.Index].Value;

                dtgStepList.Rows[selectIndex + 1].Cells[FixStepIdCol.Index].Value = curretnIndex;
                dtgStepList.Rows[selectIndex + 1].Cells[FixStepNameCol.Index].Value = curretnValue;
                dtgStepList.Rows[selectIndex + 1].Cells[IsUsedCol.Index].Value = currentUsed;

                dtgStepList.Rows[selectIndex].Cells[FixStepIdCol.Index].Value = preIndex;
                dtgStepList.Rows[selectIndex].Cells[FixStepNameCol.Index].Value = preValue;
                dtgStepList.Rows[selectIndex].Cells[IsUsedCol.Index].Value = preUsed;

                dtgStepList.ClearSelection();

                dtgStepList.Rows[selectIndex + 1].Selected = true;
                selectIndex = selectIndex + 1;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorSolution - MoveDown. Chi tiết:", ex);
            }
        }

        private void SaveFixErrorInfo()
        {
            try
            {
                // Delete all curent fixstep
                this.fixErrorTableAdapter.Delete(currentErrorId);

                this.fixErrorDataTable = new FixErrorDataSet.FixErrorDataTable();

                // Thêm mới
                for (int i = 0; i < dtgStepList.Rows.Count; i++)
                {
                    var newRows = this.fixErrorDataTable.NewFixErrorRow();

                    newRows.ErrorId = currentErrorId;
                    newRows.FixIndex = i;
                    newRows.FixStepId = int.Parse(dtgStepList.Rows[i].Cells[FixStepIdCol.Index].Value.ToString());
                    newRows.IsUsed = (bool)dtgStepList.Rows[i].Cells[IsUsedCol.Index].Value;
                    this.fixErrorDataTable.AddFixErrorRow(newRows);
                }

                // Không có chọn lựa không xử lý lưu
                if (this.fixErrorDataTable.Rows.Count == 0)
                {
                    return;
                }

                // Update note info
                this.errorListTableAdapter.FillByErrorId(this.errorListDataTable, currentErrorId);
                if (this.errorListDataTable.Rows.Count > 0)
                {
                    this.errorListDataTable.First().FixGroupId = int.Parse(cboForwardTo.SelectedValue.ToString());
                    this.errorListDataTable.First().FixDate = DateTime.Now;
                    this.errorListDataTable.First().FixContentSuggestion = txtNotes.Text;
                    this.errorListDataTable.First().IsFixed = chkFixed.Checked ? 1 : 0;
                    this.errorListTableAdapter.Update(this.errorListDataTable);
                }

                // Delete all curent fixstep
                this.fixErrorTableAdapter.Update(this.fixErrorDataTable);
                if (this.ReloadDataEvent != null)
                    this.ReloadDataEvent();

                // Log system histories
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MissingPE);
                UserSession.Action = SystemResource.User_Action_Update;
                UserSession.Notes = "Sữa lỗi điểm đo thiếu bản tin - Modem: " + txtDcu.Text + " - Mã lỗi: " + txtErrorCode.Text + " - Tên lỗi: " + lblErrorName.Text + " (PE:" + lblPe.Text + " - Điểm đo: " + lblPEName.Text + ")" + " \n-Đơn vị xử lý: " + cboForwardTo.Text + "\n-Cách sử lý:\n" + txtNotes.Text + "Trạng thái xử lý: " + (chkFixed.Checked ? " Đã xử lý" : " Chưa xử lý");
                this.InsertHistories();

                MessageBox.Show("Cập nhật xử lý thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorSolution - SaveFixErrorInfo. Chi tiết:", ex);

                MessageBox.Show("Lỗi trong quá trình cập nhật xử lý", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ErrorSolution_Load(object sender, EventArgs e)
        {
            LoadErrorDefine();
            LoadFixGroup();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFixErrorInfo();
        }


        private void dtgStepList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectIndex = e.RowIndex;
        }

        private void dtgStepList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void cboForwardTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFixStepErrorByErrorCodeAndGroupId();
        }

        private void CheckAll()
        {
            for (int i = 0; i < dtgStepList.Rows.Count; i++)
            {
                if ((bool)dtgStepList.Rows[i].Cells[IsUsedCol.Index].Value)
                {
                    stopSelectAll = false;
                    return;
                }
            }

            chkSelectedAll.Checked = stopSelectAll;
            if (!chkSelectedAll.Checked && !stopSelectAll)
                txtNotes.Text = string.Empty;
        }

        private void LoadFixStepErrorByErrorCodeAndGroupId()
        {
            dtgStepList.Rows.Clear();

            if (cboForwardTo.SelectedValue == null || currentErrorId == -1)
                return;

            int groupId = int.Parse(cboForwardTo.SelectedValue.ToString());
            string errorCode = txtErrorCode.Text;

            try
            {
                txtNotes.Text = string.Empty;
                chkFixed.Checked = false;

                this.fixErrorTableAdapter.FillByErrorId(this.fixErrorDataTable, currentErrorId);

                this.getFixErrorTableAdapter.FillByGroupIdAndErrorCode(this.getFixErrorDataTable, groupId, errorCode, currentErrorId);

                foreach (FixErrorDataSet.GetFixErrorRow item in this.getFixErrorDataTable.Rows)
                {
                    dtgStepList.Rows.Add(currentErrorId, item.FixStepId, item.FixStepName, item.IsUsed, null);
                }

                this.errorListTableAdapter.FillByErrorId(this.errorListDataTable, currentErrorId);


                if (cboForwardTo.SelectedValue != null)
                    if (!this.errorListDataTable.First().IsFixGroupIdNull() && int.Parse(cboForwardTo.SelectedValue.ToString()) == this.errorListDataTable.First().FixGroupId)
                    {
                        txtNotes.Text = this.errorListDataTable.First().IsFixContentSuggestionNull() ? string.Empty : this.errorListDataTable.First().FixContentSuggestion;
                        chkFixed.Checked = this.errorListDataTable.First().IsFixed == 1 ? true : false;
                    }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorSolution - LoadFixStepErrorByErrorCodeAndGroupId. Chi tiết:", ex);

                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.isValueChanged)
                return;

            for (int j = 0; j < this.dtgStepList.Rows.Count; j++)
            {
                if (chkSelectedAll.Checked && !stopSelectAll)
                    this.dtgStepList[IsUsedCol.DisplayIndex, j].Value = this.chkSelectedAll.Checked;
                else if (!chkSelectedAll.Checked && !stopSelectAll)
                    this.dtgStepList[IsUsedCol.DisplayIndex, j].Value = this.chkSelectedAll.Checked;

            }
            stopSelectAll = false;
            this.dtgStepList.EndEdit();
            this.isValueChanged = false;
        }

        private void dtgStepList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == IsUsedCol.Index)
            {
                if (!(bool)dtgStepList.Rows[e.RowIndex].Cells[IsUsedCol.Index].Value)
                {
                    isValueChanged = true;
                    chkSelectedAll.Checked = false;
                }
                else
                {
                    txtNotes.AppendText("-" + dtgStepList.Rows[e.RowIndex].Cells[FixStepNameCol.Index].Value.ToString() + "\n");
                }

                isValueChanged = false;
                CheckAll();
            }
        }

    }
}