using System;
using System.Windows.Forms;
using AmiOperationLib;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ErrorCodeDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.FixGroupDataSetTableAdapters;
using System.Drawing;
using OperationDTO.AmiOperationDataSet.FixStepDataSetTableAdapters;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using System.Linq;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class FixErrorStep : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private ErrorCodeDataSet.ErrorCodeDataTable errorCodeDataTable = new ErrorCodeDataSet.ErrorCodeDataTable();
        private ErrorCodeTableAdapter errorCodeTableAdapter = new ErrorCodeTableAdapter();

        private FixGroupDataSet.FixGroupDataTable fixGroupDataTable = new FixGroupDataSet.FixGroupDataTable();
        private FixGroupTableAdapter fixGroupTableAdapter = new FixGroupTableAdapter();

        private FixStepDataSet.FixStepDataTable fixStepDataTable = new FixStepDataSet.FixStepDataTable();
        private FixStepTableAdapter fixStepTableAdapter = new FixStepTableAdapter();

        private FixStepErrorCollection fixStepErrorCollection = new FixStepErrorCollection();
        private FixStepErrorCollection fixStepErrorEditCollection = new FixStepErrorCollection();


        // Error selected
        private int currentStepId = -1;
        private int preStepId = -1;
        private int currentIndex = -1;

        public FixErrorStep()
        {
            InitializeComponent();
        }

        private void LoadFixGroup()
        {
            try
            {
                this.fixGroupTableAdapter.Fill(this.fixGroupDataTable);

                cboForwardTo.DataSource = this.fixGroupDataTable;
                cboForwardTo.DisplayMember = this.fixGroupDataTable.FixGroupNameColumn.ToString();
                cboForwardTo.ValueMember = this.fixGroupDataTable.FixGroupIdColumn.ToString();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorFixStep - LoadFixGroup Lỗi load dữ liệu từ máy chủ. Chi tiết:", ex);
                MessageBox.Show("Lỗi tải dữ liệu không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadErrorList()
        {
            try
            {
                errorCodeTableAdapter.Fill(this.errorCodeDataTable);

                cboErrorCode.DataSource = this.errorCodeDataTable;
                cboErrorCode.ValueMember = this.errorCodeDataTable.ErrorCodeColumn.ToString();
                cboErrorCode.DisplayMember = this.errorCodeDataTable.ErrorNameColumn.ToString();
                cboErrorCode.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorFixStep - SearchTopics Lỗi tìm kiếm", ex);
                MessageBox.Show("Không tải được dữ liệu từ máy chủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCErrorFixStep_Load(object sender, EventArgs e)
        {
            LoadFixGroup();
            this.cboForwardTo.SelectedIndexChanged += new System.EventHandler(this.cboForwardTo_SelectedIndexChanged);
            this.cboErrorCode.SelectedIndexChanged += new System.EventHandler(this.cboForwardTo_SelectedIndexChanged);
            LoadErrorList();
        }

        private void Save()
        {
            var rst = MessageBox.Show("Bạn có muốn lưu các thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rst != DialogResult.Yes)
                return;

            try
            {
                this.dtgFixStep.EndEdit();

                int index = -1;

                // Lưu các dữ liệu bị xoá
                if (this.fixStepErrorCollection.Count > 0)
                {
                    this.fixStepTableAdapter.Update(this.fixStepDataTable);

                    foreach (var item in this.fixStepErrorCollection.FixStepErrorList)
                    {
                        // Log người dùng
                        UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorDefine);
                        UserSession.Action = SystemResource.User_Action_Delete;
                        UserSession.Notes = "Xoá xử lý cho - Tên lỗi: " + item.ErrorName + " - Nhóm: " + item.FixGroupName + " - Bước xử lý: " + item.FixStepName;
                        controlBase.InsertHistories();
                    }
                }

                // Clean
                this.fixStepErrorCollection.Clear();

                foreach (FixStepDataSet.FixStepRow item in this.fixStepDataTable.Rows)
                {
                    index++;

                    // Thêm mới
                    if (item.FixStepId < 0)
                    {
                        this.fixStepErrorCollection.Add(new FixStepErrorEntity
                        {
                            ErrorCode = cboErrorCode.SelectedValue.ToString(),
                            FixStepName = item.FixStepName,
                            FixGroupName = cboForwardTo.Text,
                            ErrorName = cboErrorCode.Text
                        });
                    }

                    item.FixGroupId = int.Parse(cboForwardTo.SelectedValue.ToString());
                    item.ErrorCode = cboErrorCode.SelectedValue.ToString();
                    item.StepIndex = item.IsStepIndexNull() ? index : item.StepIndex;
                }

                this.fixStepTableAdapter.Update(this.fixStepDataTable);

                // Log thêm mới
                foreach (var item in this.fixStepErrorCollection.FixStepErrorList)
                {
                    // Log người dùng
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorDefine);
                    UserSession.Action = SystemResource.User_Action_Add;
                    UserSession.Notes = "Tên lỗi: " + item.ErrorName + " - Nhóm: " + item.FixGroupName + " - Bước xử lý: " + item.FixStepName;
                    controlBase.InsertHistories();
                }

                // Clean
                this.fixStepErrorCollection.Clear();

                // Log edit
                foreach (var item in this.fixStepErrorEditCollection.FixStepErrorList)
                {
                    // Log người dùng
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorDefine);
                    UserSession.Action = SystemResource.User_Action_Update;
                    UserSession.Notes = "Tên lỗi: " + item.ErrorName + " - Nhóm: " + item.FixGroupName + " - Bước xử lý: " + item.FixStepName;
                    controlBase.InsertHistories();
                }

                this.fixStepErrorEditCollection.Clear();

                MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorFixStep - Save Lỗi lưu dữ liệu", ex);
                MessageBox.Show("Lỗi lưu thông tin không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void MoveUp()
        {
            try
            {
                if (currentIndex == 0 || currentIndex == dtgFixStep.Rows.Count)
                    return;

                preStepId = int.Parse(dtgFixStep.Rows[currentIndex - 1].Cells[StepIndexCol.Index].Value.ToString());

                int currentStepIndex = this.fixStepDataTable.FindByFixStepId(currentStepId).StepIndex;
                int preIndex = this.fixStepDataTable.FindByFixStepId(preStepId).StepIndex;

                this.fixStepDataTable.FindByFixStepId(currentStepId).StepIndex = preIndex;
                this.fixStepDataTable.FindByFixStepId(preStepId).StepIndex = currentStepIndex;

                this.fixStepDataTable.DefaultView.Sort = "StepIndex ASC";

                dtgFixStep.ClearSelection();

                dtgFixStep.Rows[currentIndex - 1].Selected = true;
                currentIndex = currentIndex - 1;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorFixStep - MoveUp Chuyển lên bị lỗi. Chi tiết:", ex);
            }
        }

        private void MoveDown()
        {
            try
            {
                if (currentIndex + 1 >= dtgFixStep.Rows.Count - 1)
                    return;

                preStepId = int.Parse(dtgFixStep.Rows[currentIndex + 1].Cells[StepIndexCol.Index].Value.ToString());

                int currentStepIndex = this.fixStepDataTable.FindByFixStepId(currentStepId).StepIndex;
                int preIndex = this.fixStepDataTable.FindByFixStepId(preStepId).StepIndex;

                this.fixStepDataTable.FindByFixStepId(currentStepId).StepIndex = preIndex;
                this.fixStepDataTable.FindByFixStepId(preStepId).StepIndex = currentStepIndex;

                this.fixStepDataTable.DefaultView.Sort = "StepIndex ASC";

                dtgFixStep.ClearSelection();

                dtgFixStep.Rows[currentIndex + 1].Selected = true;
                currentIndex = currentIndex + 1;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorFixStep - MoveDown Chuyển lên bị lỗi. Chi tiết:", ex);
            }
        }

        private void dtgFixStep_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dtgFixStep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            currentIndex = e.RowIndex;
            currentStepId = int.Parse(dtgFixStep.Rows[e.RowIndex].Cells[StepIndexCol.Index].Value.ToString());
        }

        private void cboForwardTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboForwardTo.SelectedValue == null)
                    return;

                int selectIndex = int.Parse(cboForwardTo.SelectedValue.ToString());
                string errorCode = cboErrorCode.SelectedValue.ToString();
                this.fixStepTableAdapter.FillByFixGroupIdAndErrorCode(this.fixStepDataTable, selectIndex, errorCode);
                this.fixStepDataTable.DefaultView.Sort = "StepIndex ASC";
                dtgFixStep.DataSource = this.fixStepDataTable;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorFixStep - cboForwardTo_SelectedIndexChanged Chi tiết lỗi:", ex);
                MessageBox.Show("Không tải được dữ liệu từ máy chủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgFixStep_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int stepId = -1;

            try
            {
                stepId = int.Parse(dtgFixStep.CurrentRow.Cells[FixStepIdCol.Index].Value.ToString());
                if (stepId <= 0)
                {
                    int index = 0;
                    foreach (FixStepDataSet.FixStepRow item in this.fixStepDataTable.Rows)
                    {
                        item.StepIndex = index;
                        index++;
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCErrorFixStep - dtgFixStep_CellEndEdit Convert dữ liệu", ex);
                return;
            }

            var query = this.fixStepErrorEditCollection.FixStepErrorList.Where(r => r.FixStepId == stepId);
            if (query.Count() > 0)
            {
                query.First().FixStepName = this.fixStepDataTable.FindByFixStepId(stepId).FixStepName;
                return;
            }

            this.fixStepErrorEditCollection.Add(new FixStepErrorEntity
            {
                FixStepId = stepId,
                ErrorCode = this.fixStepDataTable.FindByFixStepId(stepId).ErrorCode,
                FixStepName = this.fixStepDataTable.FindByFixStepId(stepId).FixStepName,
                FixGroupName = cboForwardTo.Text,
                ErrorName = cboErrorCode.Text
            });
        }

        private void dtgFixStep_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int stepId = int.Parse(dtgFixStep.CurrentRow.Cells[FixStepIdCol.Index].Value.ToString());
            if (stepId <= 0)
                return;
            this.fixStepErrorCollection.Add(new FixStepErrorEntity
            {
                ErrorCode = this.fixStepDataTable.FindByFixStepId(stepId).ErrorCode,
                FixStepName = this.fixStepDataTable.FindByFixStepId(stepId).FixStepName,
                FixGroupName = cboForwardTo.Text,
                ErrorName = cboErrorCode.Text
            });
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            FixedGroup fixedGroup = new FixedGroup();
            fixedGroup.ShowDialog();
            if (fixedGroup.isSave)
                LoadFixGroup();
        }

    }
}
