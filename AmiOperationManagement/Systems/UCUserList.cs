using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.UserDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.UserGroupDataSetTableAdapters;
using AmiOperationLib;

namespace AmiOperationManagement.Systems
{
    public partial class UCUserList : UserControlBase
    {
        private UserDataSet.UsersDataTable usersDataTable = new UserDataSet.UsersDataTable();
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();

        private UserGroupDataSet.UserGroupDataTable userGroupDataTable = new UserGroupDataSet.UserGroupDataTable();
        private UserGroupTableAdapter userGroupTableAdapter = new UserGroupTableAdapter();


        public UCUserList()
        {
            InitializeComponent();
        }

        private void LoadGroupUser()
        {
            try
            {
                this.userGroupTableAdapter.Fill(this.userGroupDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void LoadUser()
        {
            dtgUsers.Rows.Clear();

            try
            {
                this.usersTableAdapter.Fill(this.usersDataTable);

                foreach (UserDataSet.UsersRow item in this.usersDataTable.Rows)
                {
                    if (item.UserName.Equals(Constant.SUPPER_USER))
                    {
                        if (UserSession.UserName.Equals(Constant.SUPPER_USER))
                        {
                            dtgUsers.Rows.Add(item.UserId, this.userGroupDataTable.FindByGroupId(item.GroupId).GroupName, item.UserName, item.FullName, item.Email, item.Active ? Constant.USER_ACTIVE_STATUS : Constant.USER_DEACTIVE_STATUS, null, null, null);
                        }
                        continue;
                    }

                    dtgUsers.Rows.Add(item.UserId, this.userGroupDataTable.FindByGroupId(item.GroupId).GroupName, item.UserName, item.FullName, item.Email, item.Active ? Constant.USER_ACTIVE_STATUS : Constant.USER_DEACTIVE_STATUS, null, null, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCUserList_Load(object sender, EventArgs e)
        {
            this.LoadGroupUser();
            this.LoadUser();
        }

        private void dtgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            
            int userId = int.Parse(dtgUsers.Rows[e.RowIndex].Cells[UserIdCol.Index].Value.ToString());
            string userName = dtgUsers.Rows[e.RowIndex].Cells[UserNameCol.Index].Value.ToString();
         
            if (e.ColumnIndex == EditCol.Index)
            {
                UpdateUser updateUser = new UpdateUser(userId);
                updateUser.ShowDialog();
                this.LoadUser();
            }
            else if (e.ColumnIndex == DeleteCol.Index)
            {
                if (userName.Equals(Constant.SUPPER_USER))
                {
                    MessageBox.Show("Tài khoản quản trị hệ thống, bạn không thể xoá.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }
                
                if(userName.Equals(UserSession.UserName))
                {
                    return;
                }
                var rst = MessageBox.Show("Bạn có muốn xoá tài khoản: " + userName + " này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rst == DialogResult.No)
                    return;

                try
                {
                    this.usersTableAdapter.FillByUserId(this.usersDataTable, userId);
                    this.usersDataTable[0].Delete();
                    this.usersTableAdapter.Update(this.usersDataTable);
                    this.LoadUser();
                    MessageBox.Show("Xoá người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Không không xoá được người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (e.ColumnIndex == ResetPasswordCol.Index)
            {
                if (userName.Equals(Constant.SUPPER_USER))
                {
                    MessageBox.Show("Tài khoản quản trị hệ thống, bạn không thể đổi mật khẩu ở đây. Hãy dùng tính năng đổi mật khẩu.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    return;
                }
                var rst = MessageBox.Show("Bạn có muốn tạo lại mật khẩu mặc đị cho tài khoản: " + userName + " này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (rst == DialogResult.No)
                    return;
                try
                {
                    this.usersTableAdapter.FillByUserId(this.usersDataTable, userId);
                    this.usersDataTable.First().Password = Constant.USER_PASSWORD_DEFAULT;
                    this.usersTableAdapter.Update(this.usersDataTable);
                    MessageBox.Show("Tạo lại mật khẩu mặc định cho người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Không thiết lập được mật khẩu cho người dùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ReloadData += LoadUser;
            addUser.ShowDialog();
        }

        private void dtgUsers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
