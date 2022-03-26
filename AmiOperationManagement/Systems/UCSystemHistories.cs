using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.SystemHistoriesDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.UserDataSetTableAdapters;
using AmiOperationLib;
using OperationDTO.AmiOperationDataSet.SystemFunctionDataSetTableAdapters;
using System.Drawing;
using AmiOperationManagement.Main;
using System.ComponentModel;

namespace AmiOperationManagement.Systems
{
    public partial class UCSystemHistories : UserControl
    {
        private SystemHistoriesDataSet.SystemHistoriesDataTable systemHistoriesDataTable = new SystemHistoriesDataSet.SystemHistoriesDataTable();
        private SystemHistoriesTableAdapter systemHistoriesTableAdapter = new SystemHistoriesTableAdapter();

        private UserDataSet.UsersDataTable usersDataTable = new UserDataSet.UsersDataTable();
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();

        private SystemFunctionDataSet.SystemFunctionDataTable systemFunctionDataTable = new SystemFunctionDataSet.SystemFunctionDataTable();
        private SystemFunctionTableAdapter systemFunctionTableAdapter = new SystemFunctionTableAdapter();

        // Tạo trang
        private Waitting waitting;
        private BackgroundWorker bgwWaiting;
        private int pageNume = 0;
        private int numRow = 0;

        public UCSystemHistories()
        {
            InitializeComponent();
            dtFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            cboAction.SelectedIndex = 0;
            ucBreakPage.NextPageEvent += ucBreakPage_NextPageEvent;
        }

        void ucBreakPage_NextPageEvent(int pageNume, int numRow)
        {
            this.pageNume = pageNume;
            this.numRow = numRow;
            if (bgwWaiting == null)
            {
                bgwWaiting = new BackgroundWorker();
                bgwWaiting.RunWorkerCompleted += bgwWaiting_RunWorkerCompleted;
                bgwWaiting.DoWork += bgwWaiting_DoWork;
            }
            bgwWaiting.RunWorkerAsync();

            if (waitting == null)
                waitting = new Waitting();
            if (!waitting.Visible)
                waitting.ShowDialog();
        }

        private void bgwWaiting_DoWork(object sender, DoWorkEventArgs e)
        {
            DisplayData();
        }

        private void bgwWaiting_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwWaiting.Dispose();
            bgwWaiting = null;
            waitting.CloseWaiting();
            waitting.Dispose();
            waitting = null;
        }


        private void DisplayData()
        {
            Invoke(new Action(() =>
            {
                dtgHistories.Rows.Clear();
                int index = this.pageNume * this.numRow + 1;
                int rowIndex = 0;

                for (int i = 0; i < this.systemHistoriesDataTable.Rows.Count; i++)
                {
                    if (i + 1 > this.numRow || index > this.systemHistoriesDataTable.Rows.Count)
                        break;
                    var item = this.systemHistoriesDataTable[index - 1];
                    try
                    {
                        dtgHistories.Rows.Add(item.UserName, item.FunctionName, item.Action, item.Notes, item.CreatedDate.ToString("dd-MM-yyyy HH:mm:ss"));

                        rowIndex++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiển thị thông tin tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    index++;
                }

                MemoryManagement.MinimizeMemory();
            }));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void LoadUser()
        {
            try
            {
                var user = usersTableAdapter.Fill(this.usersDataTable);
                var newRows = this.usersDataTable.NewUsersRow();
                newRows.UserId = -1;
                newRows.FullName = Constant.SELECT_ALL_TEXT;
                newRows.UserName = Constant.SELECT_ALL_TEXT;
                newRows.Password = Constant.SELECT_ALL_TEXT;
                newRows.Active = true;
                newRows.GroupId = this.usersDataTable.First().GroupId;

                this.usersDataTable.Rows.InsertAt(newRows, 0);

                var remveUser = this.usersDataTable.Where(r => r.UserName.Equals(Constant.SUPPER_USER));


                if (remveUser.Count() > 0)
                {
                    this.usersDataTable.RemoveUsersRow(remveUser.First());
                }

                cboUser.DisplayMember = this.usersDataTable.FullNameColumn.ToString();
                cboUser.ValueMember = this.usersDataTable.UserNameColumn.ToString();
                cboUser.DataSource = this.usersDataTable;
                cboUser.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải thông tin không thành công.\nChi tiết:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadFunction()
        {
            try
            {
                this.systemFunctionTableAdapter.Fill(this.systemFunctionDataTable);

                var newRows = this.systemFunctionDataTable.NewSystemFunctionRow();
                newRows.FunctionId = -1;
                newRows.FunctionName = Constant.SELECT_ALL_TEXT;

                this.systemFunctionDataTable.Rows.InsertAt(newRows, 0);

                cboFunction.ValueMember = this.systemFunctionDataTable.FunctionNameColumn.ToString();
                cboFunction.DisplayMember = this.systemFunctionDataTable.FunctionNameColumn.ToString();
                cboFunction.DataSource = this.systemFunctionDataTable;
                cboFunction.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thực hiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search()
        {
            dtgHistories.Rows.Clear();

            if (dtTo.Value < dtFrom.Value)
            {
                MessageBox.Show("Thời gian bắt đầu không được lớn hơn thời gian kết thúc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtFrom.Focus();
                return;
            }

            if ((dtTo.Value - dtFrom.Value).TotalDays > 10)
            {
                MessageBox.Show("Khoảng thời gian tìm kiếm không được vượt quá 10 ngày", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtFrom.Focus();
                return;
            }

            try
            {
                string dTo = null;
                string dForm = null;

                dTo = dForm = null;

                if (dtFrom.Value != DateTime.MinValue)
                    dForm = dtFrom.Text;
                if (dtTo.Value != DateTime.MinValue)
                    dTo = dtTo.Text;

                systemHistoriesTableAdapter.FillByCondition(this.systemHistoriesDataTable, cboUser.SelectedIndex == 0 ? null : cboUser.SelectedValue.ToString(), cboFunction.SelectedIndex == 0 ? null : cboFunction.Text, cboAction.SelectedIndex == 0 ? null : cboAction.SelectedItem.ToString(), dForm, dTo);

                ucBreakPage.CreatePage(this.systemHistoriesDataTable.Rows.Count);

                if (this.systemHistoriesDataTable.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy lịch sử người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thực hiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }

        private void DeleteAll()
        {
            var rst = MessageBox.Show("Việc xoá dữ liệu sẽ không thể khôi phục lại. Bạn có muốn xoá bỏ toàn bộ lịch sử trong cơ sở dữ liệu không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rst != DialogResult.Yes)
                return;

            try
            {
                this.systemHistoriesTableAdapter.DeleteAllData(this.systemHistoriesDataTable);
                MessageBox.Show("Xoá dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình thực hiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCSystemHistories_Load(object sender, EventArgs e)
        {
            if (UserSession.UserName.Equals(Constant.SUPPER_USER))
                btnDeleteAll.Visible = true;
            else
                btnDeleteAll.Visible = false;

            LoadUser();
            LoadFunction();
            Search();
        }

        private void dtgHistories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
