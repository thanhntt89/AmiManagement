using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.UserDataSetTableAdapters;
using AmiOperationLib;
using AmiOperationManagement.Main;
using OperationDTO.AmiOperationDataSet.LogDeploymentDataSetTableAdapters;
using System.Drawing;

namespace AmiOperationManagement.Deployment
{
    public partial class UCDeployHistories : UserControlBase
    {
        private UserDataSet.UsersDataTable usersDataTable = new UserDataSet.UsersDataTable();
        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();

        private LogDeploymentDataSet.LogDeploymentDataTable logDeploymentDataTable = new LogDeploymentDataSet.LogDeploymentDataTable();
        private LogDeploymentTableAdapter logDeploymentTableAdapter = new LogDeploymentTableAdapter();

        // Tạo trang
        private Waitting waitting;
        private BackgroundWorker bgwWaiting;
        private int pageNume = 0;
        private int numRow = 0;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.btnSearching_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public UCDeployHistories()
        {
            InitializeComponent();
            ucBreakPage.NextPageEvent += ucBreakPage_NextPageEvent; 
            dtCreatedFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtCreatedTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
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
            this.DisplayData();
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
                dtgDeployHistories.Rows.Clear();
                int index = this.pageNume * this.numRow + 1;
                int rowIndex = 0;

                for (int i = 0; i < this.logDeploymentDataTable.Rows.Count; i++)
                {
                    if (i + 1 > this.numRow || index > this.logDeploymentDataTable.Rows.Count)
                        break;
                    var item = this.logDeploymentDataTable[index - 1];
                    try
                    {
                        dtgDeployHistories.Rows.Add(
                           item.Action,
                           item.IsMeasurementPointIdNull() ? string.Empty : item.MeasurementPointId,
                           item.IsNameNull() ? string.Empty : item.Name,
                           item.IsNewDcuCodeNull() ? string.Empty : item.NewDcuCode,
                           item.IsNewMeterCodeNull() ? string.Empty : item.NewMeterCode,
                           item.IsOldDcuCodeNull() ? string.Empty : item.OldDcuCode,
                           item.IsOldMeterCodeNull() ? string.Empty : item.OldMeterCode,
                           item.IsUserDeployNull() ? string.Empty : item.UserDeploy,
                           item.IsPhoneNull() ? string.Empty : item.Phone,
                           item.IsStatusMeasurementPointNull() ? string.Empty : item.StatusMeasurementPoint,
                           item.IsNoteNull() ? string.Empty : item.Note,
                           item.IsCreateDateNull() ? string.Empty : item.CreateDate.ToString("dd/MM/yyyy HH:mm:ss"),
                           item.IsUserNull() ? string.Empty : item.User,
                           item.Id
                            );

                        rowIndex++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiển thị thông tin tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    index++;
                }
            }));
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

                cboUser.DisplayMember = this.usersDataTable.FullNameColumn.ColumnName;
                cboUser.ValueMember = this.usersDataTable.UserNameColumn.ColumnName;
                cboUser.DataSource = this.usersDataTable;
                cboUser.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải thông tin không thành công.\nChi tiết:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtDcuCode.Text = string.Empty;
            txtDeployUser.Text = string.Empty;
            txtMeterCode.Text = string.Empty;
            txtMpCode.Text = string.Empty;
            cboUser.SelectedIndex = 0;
            dtCreatedFrom.Value = DateTime.MinValue;
            dtCreatedTo.Value = DateTime.MinValue;
            logDeploymentDataTable.Clear();
            dtgDeployHistories.Rows.Clear();
            MemoryManagement.MinimizeMemory();
        }

        private void btnSearching_Click(object sender, EventArgs e)
        {
            this.Searching();
        }

        private void Searching()
        {
            dtgDeployHistories.Rows.Clear();

            string fromDate = null;
            string todate = null;
            string mpCode = null;
            string dcuCode = null;
            string meterCode = null;
            string user = null;
            string deployUser = null;


            if (cboUser.SelectedIndex > 0)
                user = cboUser.SelectedValue.ToString();

            if (!string.IsNullOrWhiteSpace(txtMpCode.Text))
                mpCode = txtMpCode.Text;

            if (!string.IsNullOrWhiteSpace(txtDcuCode.Text))
                dcuCode = txtDcuCode.Text;

            if (!string.IsNullOrWhiteSpace(txtMeterCode.Text))
                meterCode = txtMeterCode.Text;
            
            if (!string.IsNullOrWhiteSpace(txtDeployUser.Text))
                deployUser = txtDeployUser.Text;

            if (dtCreatedFrom.Value != DateTime.MinValue)
                fromDate = dtCreatedFrom.Text;
            if (dtCreatedTo.Value != DateTime.MinValue)
                todate = dtCreatedTo.Text;

            try
            {
                this.logDeploymentTableAdapter.FillByConditions(this.logDeploymentDataTable,
                    mpCode,
                    dcuCode,
                    meterCode,
                    user,
                    deployUser,                   
                    fromDate,
                    todate
                    );
                Invoke(new Action(() =>
                {
                    ucBreakPage.CreatePage(this.logDeploymentDataTable.Rows.Count);
                }));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPointManagement.Searching - Tải dữ liệu cho Searching không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tìm kiếm thông tin. Chi tiết lỗi kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void UCDeployHistories_Load(object sender, EventArgs e)
        {
            this.LoadUser();
            this.Searching();
        }

        private void dtgDeployHistories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
