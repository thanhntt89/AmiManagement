using AmiOperationLib;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.FixGroupDataSetTableAdapters;
using System;
using System.Windows.Forms;
using System.Linq;
using AmiOperationManagement.Resources;
using AmiOperationManagement.CustomeUserControl;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class FixedGroup : DevComponents.DotNetBar.Metro.MetroForm
    {
        public bool isSave = false;
        private UserControlBase controlBase = new UserControlBase();

        private FixGroupDataSet.FixGroupDataTable fixGroupDataTable = new FixGroupDataSet.FixGroupDataTable();
        private FixGroupTableAdapter fixGroupTableAdapter = new FixGroupTableAdapter();

        private FixGroupCollection fixGroupCollection = new FixGroupCollection();
        private FixGroupCollection fixGroupEditCollection = new FixGroupCollection();

        public FixedGroup()
        {
            InitializeComponent();
        }

        private void LoadFixGroup()
        {
            try
            {
                this.fixGroupTableAdapter.Fill(this.fixGroupDataTable);

                dtgFixGroup.DataSource = this.fixGroupDataTable;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "FixedGroup - LoadFixGroup Lỗi load dữ liệu từ máy chủ. Chi tiết:", ex);
                MessageBox.Show("Lỗi tải dữ liệu không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FixedGroup_Load(object sender, EventArgs e)
        {
            LoadFixGroup();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            var rst = MessageBox.Show("Bạn có muốn lưu các thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rst != DialogResult.Yes)
                return;
            try
            {

                // Lưu các dữ liệu bị xoá
                if (this.fixGroupCollection.Count > 0)
                {
                    this.fixGroupTableAdapter.Update(this.fixGroupDataTable);

                    // Log người dùng xoá dữ liệu
                    foreach (var item in this.fixGroupCollection.FixGroupList)
                    {
                        // Log người dùng
                        UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorDefine);
                        UserSession.Action = SystemResource.User_Action_Delete;
                        UserSession.Notes = "Xoá nhóm: " + item.FixGroupName;
                        controlBase.InsertHistories();
                    }
                }
                
                // Clean
                this.fixGroupCollection.Clear();

                int index = -1;

                // Kiểm tra thêm mới
                foreach (FixGroupDataSet.FixGroupRow item in this.fixGroupDataTable.Rows)
                {
                    index++;

                    // Thêm mới
                    if (item.FixGroupId < 0)
                    {
                        this.fixGroupCollection.Add(new FixGroupEntity
                        {
                            FixGroupId = item.FixGroupId,
                            FixGroupName = item.FixGroupName

                        });
                    }
                }
                // Cập nhật
                this.fixGroupTableAdapter.Update(this.fixGroupDataTable);

                // Log thêm mới
                foreach (var item in this.fixGroupCollection.FixGroupList)
                {
                    // Log người dùng
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorDefine);
                    UserSession.Action = SystemResource.User_Action_Add;
                    UserSession.Notes = "Tên nhóm: " + item.FixGroupName;
                    controlBase.InsertHistories();
                }

                // Clean
                this.fixGroupCollection.Clear();

                // Log edit
                foreach (var item in this.fixGroupEditCollection.FixGroupList)
                {
                    // Log người dùng
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_ErrorDefine);
                    UserSession.Action = SystemResource.User_Action_Update;
                    UserSession.Notes = "Tên nhóm: " + item.FixGroupName;
                    controlBase.InsertHistories();
                }

                this.fixGroupEditCollection.Clear();

                MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.isSave = true;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "FixedGroup - LoadFixGroup Lỗi load dữ liệu từ máy chủ. Chi tiết:", ex);
                MessageBox.Show("Lỗi tải dữ liệu không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgFixGroup_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int stepId = int.Parse(dtgFixGroup.CurrentRow.Cells[FixGroupIdCol.Index].Value.ToString());
            if (stepId <= 0)
                return;
            this.fixGroupCollection.Add(new FixGroupEntity
            {
                FixGroupId = stepId,
                FixGroupName = this.fixGroupDataTable.FindByFixGroupId(stepId).FixGroupName
            });
        }

        private void dtgFixGroup_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int stepId = -1;

            try
            {
                stepId = int.Parse(dtgFixGroup.CurrentRow.Cells[FixGroupIdCol.Index].Value.ToString());
                if (stepId <= 0)
                {
                    int index = 0;
                    foreach (FixStepDataSet.FixStepRow item in this.fixGroupDataTable.Rows)
                    {
                        item.StepIndex = index;
                        index++;
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "FixedGroup - dtgFixGroup_CellEndEdit Convert dữ liệu", ex);
                return;
            }

            var query = this.fixGroupEditCollection.FixGroupList.Where(r => r.FixGroupId == stepId);
            if (query.Count() > 0)
            {
                query.First().FixGroupName = this.fixGroupDataTable.FindByFixGroupId(stepId).FixGroupName;
                return;
            }

            this.fixGroupEditCollection.Add(new FixGroupEntity
            {
                FixGroupId = stepId,
                FixGroupName = this.fixGroupDataTable.FindByFixGroupId(stepId).FixGroupName
            });
        }
    }
}