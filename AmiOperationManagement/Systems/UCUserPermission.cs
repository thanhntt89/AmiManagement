using System;
using System.Drawing;
using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.UserGroupDataSetTableAdapters;
using AmiOperationLib;
using DevComponents.AdvTree;
using OperationDTO.AmiOperationDataSet.SystemFunctionDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.GroupFunctionDataSetTableAdapters;

namespace AmiOperationManagement.Systems
{
    public partial class UCUserPermission : UserControlBase
    {
        private UserGroupDataSet.UserGroupDataTable userGroupDataTable = new UserGroupDataSet.UserGroupDataTable();
        private UserGroupTableAdapter userGroupTableAdapter = new UserGroupTableAdapter();

        private SystemFunctionDataSet.UserFunctionDataTable userFunctionDataTable = new SystemFunctionDataSet.UserFunctionDataTable();
        private UserFunctionTableAdapter userFunctionTableAdapter = new UserFunctionTableAdapter();

        private GroupFunctionDataSet.GroupFunctionDataTable groupFunctionDataTable;
        private GroupFunctionTableAdapter groupFunctionTableAdapter = new GroupFunctionTableAdapter();

        private int currentGroupId = -1;

        public UCUserPermission()
        {
            InitializeComponent();
        }

        public void LoadFunctionGroup()
        {
            try
            {
                tvGroupFunction.Nodes.Clear();

                dtgFunction.Columns[IsActiveCol.Index].ReadOnly = false;
                int rst = this.userGroupTableAdapter.Fill(this.userGroupDataTable);
                if (rst == -1)
                {
                    MessageBox.Show("Lỗi: Không tải được dữ liệu thông tin máy chủ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int index = 0;

                tvGroupFunction.ImageList = imageList;

                NodeCustom nodeRoot = new NodeCustom(Constant.FUNCTION_GROUP_TEXT);
                nodeRoot.ImageIndex = index;
                nodeRoot.ImageExpandedIndex = index;
                tvGroupFunction.Nodes.Add(nodeRoot);
                nodeRoot.ExpandVisibility = eNodeExpandVisibility.Hidden;


                foreach (UserGroupDataSet.UserGroupRow item in this.userGroupDataTable)
                {
                    index++;
                    NodeCustom node = new NodeCustom(item.GroupName);
                    node.Name = item.GroupId.ToString();
                    node.ImageIndex = index;
                    node.ImageExpandedIndex = index;

                    tvGroupFunction.Nodes[0].Nodes.Add(node);

                }

                tvGroupFunction.ExpandAll();

                if (!UserSession.UserName.Equals(Constant.SUPPER_USER))
                {
                    tvGroupFunction.Nodes[0].Nodes[0].Remove();
                }
                tvGroupFunction.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu loại modem.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadFunctionList(NodeCustom node)
        {
            dtgFunction.Rows.Clear();
            if (node == null || node.Name.Equals(string.Empty))
            {
                return;
            }
            btnSave.Enabled = true;
            dtgFunction.Columns[IsActiveCol.Index].ReadOnly = false;

            try
            {
                currentGroupId = int.Parse(node.Name);
                this.userFunctionTableAdapter.FillByGroupId(this.userFunctionDataTable, currentGroupId);

                foreach (SystemFunctionDataSet.UserFunctionRow item in this.userFunctionDataTable.Rows)
                {
                    dtgFunction.Rows.Add(item.GroupId, item.FunctionId, item.FunctionName, item.IsActive);
                }

                if (UserSession.UserName.Equals(Constant.SUPPER_USER) && node.Name.Equals(Constant.ROOT_FUNCTION))
                {
                    btnSave.Enabled = false;
                    dtgFunction.Columns[IsActiveCol.Index].ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Save()
        {
            var rst = MessageBox.Show("Bạn có muốn lưu lại những thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rst != DialogResult.Yes)
                return;
            try
            {
                groupFunctionDataTable = new GroupFunctionDataSet.GroupFunctionDataTable();

                // Delete current value
                this.groupFunctionTableAdapter.FillByGroupId(this.groupFunctionDataTable, currentGroupId);

                for (int i = 0; i < dtgFunction.Rows.Count; i++)
                {
                    GroupFunctionDataSet.GroupFunctionRow row = this.groupFunctionDataTable.FindByGroupIdFunctionId(currentGroupId, int.Parse(dtgFunction.Rows[i].Cells[FunctionIdCol.Index].Value.ToString()));

                    if (row != null)
                        row.IsActive = (bool)dtgFunction.Rows[i].Cells[IsActiveCol.Index].Value;
                }

                this.groupFunctionTableAdapter.Update(this.groupFunctionDataTable);
                MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void dtgFunction_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void UCUserPermission_Load(object sender, EventArgs e)
        {

        }

        private void tvGroupFunction_AfterNodeSelect(object sender, AdvTreeNodeEventArgs e)
        {
            this.LoadFunctionList((NodeCustom)e.Node);
        }
    }
}
