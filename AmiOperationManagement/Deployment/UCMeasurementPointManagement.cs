using System;
using System.Windows.Forms;
using AmiOperationLib;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.DataByMeasurementPointDataSetTableAdapters;
using System.Linq;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using AmiOperationManagement.CustomeUserControl;
using System.Drawing;
using AmiOperationManagement.Resources;
using AmiOperationManagement.Main;
using System.ComponentModel;
using OperationDTO.AmiSystemDataSet.ContractDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointGroupDataSetTableAdapters;

namespace AmiOperationManagement.Deployment
{
    public partial class UCMeasurementPointManagement : UserControlBase
    {
        private DataByMeasurementPointDataSet.MeasurementPointDataTableDataTable measurementPointDataTableDataTable = new DataByMeasurementPointDataSet.MeasurementPointDataTableDataTable();
        private DataMeasurementPointTableAdapter dataMeasurementPointTableAdapter = new DataMeasurementPointTableAdapter();

        private MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTable = new MeasurementPointDataSet.MeasurementPointDataTable();
        private MeasurementPointTableAdapter measurementPointTableAdapter = new MeasurementPointTableAdapter();

        private MeasurementPointDataSet.MeasurementPointInfoDataTable measurementPointInfoDataTable = new MeasurementPointDataSet.MeasurementPointInfoDataTable();
        private MeasurementPointInfoTableAdapter measurementPointInfoTableAdapter = new MeasurementPointInfoTableAdapter();

        private ContractDataSet.ContractDataTable contractDataTable = new ContractDataSet.ContractDataTable();
        private ContractTableAdapter contractTableAdapter = new ContractTableAdapter();

        private MeasurementPointGroupDataSet.MeasurementPointGroupDataTable measurementPointGroupDataTable = new MeasurementPointGroupDataSet.MeasurementPointGroupDataTable();
       
        // Tạo trang
        private Waitting waitting;
        private BackgroundWorker bgwWaiting;
        private int pageNume = 0;
        private int numRow = 0;

        private BackgroundWorker bgwSearch;

        private string mpCode = null;
        private string groupId = null;
        private string contactId = null;
        private string mpType = null;
        private string dcuCode = null;
        private string meterCode = null;
        private string isDeleted = null;
        private string fromDate = null;
        private string todate = null;

        private long measurementPointId = -1;
        private long measurementPointMeterId = -1;

        private void LoadContract()
        {
            try
            {
                this.contractTableAdapter.Fill(this.contractDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPointManagement.LoadContract - Tải dữ liệu cho LoadContract không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi không tải được thông tin hợp đồng từ cơ sở dữ liệu. Chi tiết kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var newRows = this.contractDataTable.NewContractRow();

            newRows.Id = -1;
            newRows.Note = Constant.SELECT_ALL_TEXT;

            this.contractDataTable.Rows.InsertAt(newRows, 0);

            cboContract.DataSource = this.contractDataTable;
            cboContract.DisplayMember = this.contractDataTable.NoteColumn.ColumnName;
            cboContract.ValueMember = this.contractDataTable.IdColumn.ColumnName;
        }

        /// <summary>
        /// Load thông tin điện lực
        /// </summary>
        private void LoadGroup()
        {
            try
            {
                this.measurementPointGroupDataTable = (MeasurementPointGroupDataSet.MeasurementPointGroupDataTable)UserSession.MeasurementPointGroupDataTable.Copy();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPointManagement.LoadGroup - Tải dữ liệu cho LoadGroup không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi không tải được thông tin điện lực từ cơ sở dữ liệu. Chi tiết kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var newRows = this.measurementPointGroupDataTable.NewMeasurementPointGroupRow();

            newRows.Id = -1;
            newRows.MeasurementPointGroupId = "-1";
            newRows.Name = Constant.SELECT_ALL_TEXT;
            newRows.IsDeleted = false;
            newRows.OrgId = -1;
            this.measurementPointGroupDataTable.Rows.InsertAt(newRows, 0);

            cboGroup.DataSource = this.measurementPointGroupDataTable;
            cboGroup.DisplayMember = this.measurementPointGroupDataTable.NameColumn.ColumnName;
            cboGroup.ValueMember = this.measurementPointGroupDataTable.IdColumn.ColumnName;
        }

        public UCMeasurementPointManagement()
        {
            InitializeComponent();
            ucBreakPage.NextPageEvent += ucBreakPage_NextPageEvent;
            //dtCreateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtCreateTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtCreateFrom.Value = DateTime.MinValue;
            dtCreateTo.Value = DateTime.MinValue;
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
                dtgMeasurementpoint.Rows.Clear();
                int index = this.pageNume * this.numRow + 1;
                int rowIndex = 0;

                for (int i = 0; i < this.measurementPointInfoDataTable.Rows.Count; i++)
                {
                    if (i + 1 > this.numRow || index > this.measurementPointInfoDataTable.Rows.Count)
                        break;
                    var item = this.measurementPointInfoDataTable[index - 1];
                    try
                    {
                        int mpTypeIndex = -1;
                        string mpTypeText = string.Empty;
                        // Thanh lý
                        if (item.MeasurementPointType == 0)
                            mpTypeIndex = 3;
                        // Đang hoạt động
                        else if (item.MeasurementPointType == 1)
                            mpTypeIndex = 2;
                        // Chưa đăng ký
                        else if (item.MeasurementPointType == 3)
                            mpTypeIndex = 1;

                        mpTypeText = cboMpType.Items[mpTypeIndex].ToString();


                        dtgMeasurementpoint.Rows.Add(
                            null,
                            null,
                            item.IsDcuCodeNull() ? string.Empty : item.DcuCode,
                            item.IsMeterCodeNull() ? string.Empty : item.MeterCode,
                            mpTypeText,
                            item.IsMeterTypeNull() ? string.Empty : item.MeterType,
                            item.MeasurementPointCode,
                            item.IsMeasurementPointNameNull() ? string.Empty : item.MeasurementPointName,
                            item.IsMeasurementPointAddressNull() ? string.Empty : item.MeasurementPointAddress,
                            item.IsMeasurementPointGroupNameNull() ? string.Empty : item.MeasurementPointGroupName,
                            item.IsDeleted ? Constant.DeletedText : Constant.ActiveText,
                            item.IsLastOperationTimeNull() ? string.Empty : item.LastOperationTime.ToString("dd/MM/yyyy HH:mm:ss"),
                            item.IsCreatedDateNull() ? string.Empty : item.CreatedDate.ToString("dd/MM/yyyy HH:mm:ss"),
                            item.IsEditedDateNull() ? string.Empty : item.EditedDate.ToString("dd/MM/yyyy HH:mm:ss"),
                            item.MeasurementPointId,
                            item.IsMeasurementPointMeterIdNull() ? -1 : item.MeasurementPointMeterId,
                            null,
                            null
                            );

                        dtgMeasurementpoint.Rows[rowIndex].Cells[clStatusMp.Index].Style.ForeColor = item.IsDeleted ? Color.Red : Color.Green;

                        // Đang hoạt động
                        if (item.MeasurementPointType == 1)
                            dtgMeasurementpoint.Rows[rowIndex].Cells[clTypeMp.Index].Style.ForeColor = Color.Green;
                        // Thanh lý
                        else if (item.MeasurementPointType == 0)
                            dtgMeasurementpoint.Rows[rowIndex].Cells[clTypeMp.Index].Style.ForeColor = Color.Red;

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if (keyData == Keys.Enter)
            //    btSearchMp_Click(null, null);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btCreateMp_Click(object sender, EventArgs e)
        {
            AddMeasurementPoint addMeasurementPoint = new AddMeasurementPoint();
            addMeasurementPoint.ShowDialog();
        }

        private void btSearchMp_Click(object sender, EventArgs e)
        {
            this.SearchMp();
        }

        private void SearchMp()
        {
            dtgMeasurementpoint.Rows.Clear();
            mpCode = null;
            groupId = null;
            contactId = null;
            mpType = null;
            dcuCode = null;
            meterCode = null;
            isDeleted = null;
            fromDate = null;
            todate = null;

            if (!string.IsNullOrWhiteSpace(txtMpCode.Text))
                mpCode = txtMpCode.Text;

            if (cboGroup.SelectedIndex > 0)
                groupId = cboGroup.SelectedValue.ToString();

            if (cboContract.SelectedIndex > 0)
                contactId = cboContract.SelectedValue.ToString();

            // Chưa đăng ký
            if (cboMpType.SelectedIndex == 1)
                mpType = "3";
            // Đang hoạt động
            else if (cboMpType.SelectedIndex == 2)
                mpType = "1";
            // Thanh lý
            else if (cboMpType.SelectedIndex == 3)
                mpType = "0";

            if (!string.IsNullOrWhiteSpace(txtDcuCode.Text))
                dcuCode = txtDcuCode.Text;

            if (!string.IsNullOrWhiteSpace(txtMeterCode.Text))
                meterCode = txtMeterCode.Text;

            // Hoạt động
            if (cboStatus.SelectedIndex == 1)
                isDeleted = "0";
            // Đã xoá
            else if (cboStatus.SelectedIndex == 2)
                isDeleted = "1";

            if (dtCreateFrom.Value != DateTime.MinValue)
                fromDate = dtCreateFrom.Text;
            if (dtCreateTo.Value != DateTime.MinValue)
                todate = dtCreateTo.Text;

            if (bgwSearch == null)
            {
                bgwSearch = new BackgroundWorker();
                bgwSearch.RunWorkerCompleted += bgwSearch_RunWorkerCompleted;
                bgwSearch.DoWork += bgwSearch_DoWork;
            }

            if (!bgwSearch.IsBusy)
                bgwSearch.RunWorkerAsync();

            if (waitting == null)
                waitting = new Waitting();
            waitting.ShowDialog();
        }

        private void Searching()
        {
            try
            {
                this.measurementPointInfoTableAdapter.FillByConditions(this.measurementPointInfoDataTable,
                    mpCode,
                    dcuCode,
                    meterCode,
                    groupId,
                    contactId,
                    mpType,
                    isDeleted,
                    fromDate,
                    todate
                    );
                Invoke(new Action(() =>
                   {
                       ucBreakPage.CreatePage(this.measurementPointInfoDataTable.Rows.Count);
                   }));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeasurementPointManagement.Searching - Tải dữ liệu cho Searching không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tìm kiếm thông tin. Chi tiết lỗi kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void bgwSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            Searching();
        }

        void bgwSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwSearch.Dispose();
            bgwSearch = null;
            waitting.CloseWaiting();
        }

        private void dtgMeasurementpoint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            measurementPointId = long.Parse(dtgMeasurementpoint.Rows[e.RowIndex].Cells[clMpId.Index].Value.ToString());

            measurementPointMeterId = long.Parse(dtgMeasurementpoint.Rows[e.RowIndex].Cells[clMpmId.Index].Value.ToString());

            if (e.ColumnIndex == clEdit.Index)
                this.EditMeasurementPoint(e.RowIndex);
            else if (e.ColumnIndex == clDelete.Index)
                this.DeleteMeasurementPoint(e.RowIndex);
            else if (e.ColumnIndex == clAddMeter.Index)
                this.AddMeterInfo(e.RowIndex);
            else if (e.ColumnIndex == clChangeMp.Index)
                this.ChangeMeasurementPoint(e.RowIndex);
        }

        private void ChangeMeasurementPoint(int currentRowIndex)
        {
            if (currentRowIndex == -1)
                return;

            ChangeMeasurementPointMeter changeMeasurementPointMeter = new ChangeMeasurementPointMeter(this.measurementPointId, this.measurementPointMeterId);
            changeMeasurementPointMeter.ShowDialog();
        }

        private void AddMeterInfo(int currentRowIndex)
        {
            if (currentRowIndex == -1)
                return;

            UpdateMeasurementPointMeter updateMeasurementPointMeter = new UpdateMeasurementPointMeter(this.measurementPointId, this.measurementPointMeterId);
            updateMeasurementPointMeter.ShowDialog();
        }

        private void DeleteMeasurementPoint(int currentRowIndex)
        {
            if (currentRowIndex == -1)
                return;

            MeasurementPointDataSet.MeasurementPointInfoDataTable measurementPointInfoDataTableCheck = new MeasurementPointDataSet.MeasurementPointInfoDataTable();

            // Xử lý xoá: Điểm đo mà không có dữ liệu cho phép xoá
            // Điểm đo có dữ liệu không cho phép xoá
            try
            {
                this.measurementPointInfoTableAdapter.FillByMeasurementPointId(measurementPointInfoDataTableCheck, measurementPointId);

                // Điểm đo có công tơ
                // Và điểm đo có dữ liệu
                if (measurementPointInfoDataTableCheck.Rows.Count > 0 && !measurementPointInfoDataTableCheck.First().IsLastOperationTimeNull())
                {
                    MessageBox.Show("Điểm đo đang có dữ liệu. Bạn không thể xoá được", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                // Điểm đo chưa có dữ liệu, cho phép xoá khỏi cơ sở dữ liệu
                if (measurementPointInfoDataTableCheck.First().IsLastOperationTimeNull())
                {
                    var rst = MessageBox.Show("Bạn có muốn xoá điểm đo: " + dtgMeasurementpoint.Rows[currentRowIndex].Cells[clMpCode.Index].Value.ToString() + " này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rst != DialogResult.Yes)
                        return;

                    this.measurementPointTableAdapter.FillByMeasurementPointId(this.measurementPointDataTable, measurementPointId);

                    int deleteIndex = 0;

                    for (int i = 0; i < this.measurementPointDataTable.Rows.Count; i++)
                    {
                        this.measurementPointDataTable[deleteIndex].Delete();

                        deleteIndex++;
                    }

                    this.measurementPointTableAdapter.Update(this.measurementPointDataTable);

                    // Log người dùng
                    UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MeasurementPointList);
                    UserSession.Action = SystemResource.User_Action_Delete;
                    UserSession.Notes = "Xoá điểm đo: " + dtgMeasurementpoint.Rows[currentRowIndex].Cells[clMpCode.Index].Value.ToString()
                        + "\nTên điểm: " + dtgMeasurementpoint.Rows[currentRowIndex].Cells[clMpName.Index].Value.ToString()
                        + "\nĐịa chỉ: " + dtgMeasurementpoint.Rows[currentRowIndex].Cells[clAddress.Index].Value.ToString();

                    this.InsertHistories();

                    MessageBox.Show("Xoá điểm đo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.SearchMp();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "DeleteMeasurementPoint - this.measurementPointInfoTableAdapter.FillByMeasurementPointId(this.measurementPointInfoDataTable, " + measurementPointId + ") - Lỗi kiểm tra tồn tại điểm đo. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi trong quá trình xử lý dữ liệu. Chi tiết kiểm tra logs", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditMeasurementPoint(int currentRowIndex)
        {
            if (currentRowIndex == -1)
                return;

            UpdateMeasurementPoint updateMeasurementPoint = new UpdateMeasurementPoint(this.measurementPointId, this.measurementPointMeterId);
            updateMeasurementPoint.ShowDialog();
        }

        private void btCleanMp_Click(object sender, EventArgs e)
        {
            txtDcuCode.Text = string.Empty;
            txtMeterCode.Text = string.Empty;
            txtMpCode.Text = string.Empty;
            cboContract.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            cboMpType.SelectedIndex = 0;
            dtCreateFrom.Value = DateTime.MinValue;
            dtCreateTo.Value = DateTime.MinValue;
            cboGroup.SelectedIndex = 0;
        }

        private void dtgMeasurementpoint_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void UCMeasurementPointManagement_Load(object sender, EventArgs e)
        {
            this.LoadGroup();
            this.LoadContract();
        }
    }
}
