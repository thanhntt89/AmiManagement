using System;
using System.Windows.Forms;
using AmiOperationLib;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.MeterDataSetTableAdapters;
using System.Linq;
using AmiOperationManagement.CustomeUserControl;
using System.Drawing;
using AmiOperationManagement.Resources;
using AmiOperationManagement.Main;
using System.ComponentModel;
using OperationDTO.AmiSystemDataSet.MeterTypeAmiSysDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.Operation3PDataSetTableAdapters;

namespace AmiOperationManagement.Deployment
{
    public partial class UCMeterManagement : UserControlBase
    {
        private MeterTableAdapter meterTableAdapter = new MeterTableAdapter();
        private MeterDataSet.MeterDataTable meterDataTable = new MeterDataSet.MeterDataTable();

        private MeterTypeAmiSysDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeAmiSysDataSet.MeterTypeDataTable();
        private MeterTypeAmiSysTableAdapter meterTypeAmiSysTableAdapter = new MeterTypeAmiSysTableAdapter();

        private Waitting waitting;
        private BackgroundWorker bgwWaiting;
        private int pageNume = 0;
        private int numRow = 0;

        private int currentMetertypeIndex = -1;
        private int currentHistypeIndex = -1;
        private int currentIsUsedIndex = -1;
        private int currentIsDeletedIndex = -1;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.btnsearchMeter_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public UCMeterManagement()
        {
            InitializeComponent();
            ucBreakPage.NextPageEvent += ucBreakPage_NextPageEvent;

            //dtCreateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtCreateTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }

        private void LoadMeterType()
        {
            try
            {
                this.meterTypeAmiSysTableAdapter.Fill(this.meterTypeDataTable);


                var newRows = this.meterTypeDataTable.NewMeterTypeRow();
                newRows.Id = -1;
                newRows.MeterTypeId = "-1";
                newRows.Name = Constant.SELECT_ALL_TEXT;
                newRows.Type = -1;
                newRows.IsDeleted = false;
                newRows.ManufactureId = -1;
                newRows.Price = "-1";
                newRows.Country = "-1";
                newRows.PriceType = "-1";
                newRows.Note = "-1";
                newRows.Imax = -1;
                newRows.CreatedUserId = "-1";
                newRows.CreatedDate = DateTime.Now;
                newRows.EditedUserId = "-1";
                newRows.EditedDate = DateTime.Now;

                this.meterTypeDataTable.Rows.InsertAt(newRows, 0);

                cboMeterType.DataSource = this.meterTypeDataTable;
                cboMeterType.ValueMember = this.meterTypeDataTable.IdColumn.ColumnName;
                cboMeterType.DisplayMember = this.meterTypeDataTable.NameColumn.ColumnName;

            }
            catch
            {
                MessageBox.Show("Lỗi không tải được dữ liệu loại công tơ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                dtgSearchMeter.Rows.Clear();

                int index = this.pageNume * this.numRow + 1;
                int rowIndex = 0;

                for (int i = 0; i < this.meterDataTable.Rows.Count; i++)
                {
                    if (i + 1 > this.numRow || index > this.meterDataTable.Rows.Count)
                        break;
                    var item = this.meterDataTable[index - 1];
                    try
                    {
                        string metertype = meterTypeDataTable.Where(r => r.Id == item.MeterTypeId).First().Name;

                        int selectedIndex = -1;

                        // Histype =0 tich luỹ
                        if (item.HisType == 0)
                            selectedIndex = 1;
                        else // Histype = 1 chu kỳ chốt
                            selectedIndex = 2;

                        string histype = cboHistype.Items[selectedIndex].ToString();

                        selectedIndex = -1;
                        // Thiết bị xoá
                        if (item.IsDeleted)
                        {
                            selectedIndex = 2;
                        }
                        else
                        {
                            selectedIndex = 1;
                        }
                        string isDeleted = cboIsDeleted.Items[selectedIndex].ToString();

                        selectedIndex = -1;
                        // Đồng hồ đang sử dụng
                        if (item.Status == 1)
                            selectedIndex = 1;
                        else // Đồng hồ không sử dụng
                            selectedIndex = 2;

                        string isUsed = cboIsUsed.Items[selectedIndex].ToString();

                        dtgSearchMeter.Rows.Add(
                            item.MeterId,
                            item.Serial,
                            metertype,
                            histype,
                            item.IsMultiplierNull() ? string.Empty : item.Multiplier.ToString(),
                            item.IsImaxNull() ? string.Empty : item.Imax.ToString(),
                            isUsed,
                            isDeleted,
                            item.IsCreatedDateNull() ? string.Empty : item.CreatedDate.ToString("dd-MM-yyyy HH:mm:ss"),
                            null,
                            null,
                            item.Id
                            );

                        dtgSearchMeter.Rows[rowIndex].Cells[clIsUsed.Index].Style.ForeColor = item.Status == 1 ? Color.Green : Color.Red;

                        dtgSearchMeter.Rows[rowIndex].Cells[clIsDeleted.Index].Style.ForeColor = item.IsDeleted ? Color.Red : Color.Green;

                        rowIndex++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi hiển thị thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    index++;
                }

                MemoryManagement.MinimizeMemory();
            }));
        }


        private void btnsearchMeter_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        private void Search()
        {
            if (dtCreateTo.Value != DateTime.MinValue)
            {
                if (dtCreateFrom.Value > dtCreateTo.Value)
                {
                    MessageBox.Show("Thời gian bắt đầu không được lớn hơn thời gian kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            dtgSearchMeter.Rows.Clear();

            string lunchDateFrom = null;
            string lunchDateTo = null;
            bool? isDeleted = null;
            int? isUsed = null;

            currentHistypeIndex = cboHistype.SelectedIndex;
            currentIsDeletedIndex = cboIsDeleted.SelectedIndex;
            currentIsUsedIndex = cboIsUsed.SelectedIndex;
            currentMetertypeIndex = cboMeterType.SelectedIndex;

            if (currentIsUsedIndex == 1)
                isUsed = 1;
            else if (currentIsUsedIndex == 2)
                isUsed = 0;

            if (currentIsDeletedIndex == 1)
                isDeleted = false;
            else if (currentIsDeletedIndex == 2)
                isDeleted = true;

            if (dtCreateFrom.Value != DateTime.MinValue)
                lunchDateFrom = dtCreateFrom.Value.ToString();
            if (dtCreateTo.Value != DateTime.MinValue)
                lunchDateTo = dtCreateTo.Value.ToString();

            string meterType = null;
            if (currentMetertypeIndex > 0)
                meterType = cboMeterType.SelectedValue.ToString();

            int? histype = null;
            if (currentHistypeIndex == 1)
                histype = 0;
            else if (currentHistypeIndex == 2)
                histype = 1;

            try
            {
                this.meterTableAdapter.FillByConditions(this.meterDataTable,
                    txtMeterCode.Text == string.Empty ? null : txtMeterCode.Text,
                    meterType,
                    txtSerial.Text == string.Empty ? null : txtSerial.Text,
                    isUsed,
                    isDeleted,
                    txtMultiplier.Text == string.Empty ? null : txtMultiplier.Text,
                    histype,
                    lunchDateFrom,
                    lunchDateTo
                   );

                ucBreakPage.CreatePage(this.meterDataTable.Rows.Count);
            }
            catch
            {
                MessageBox.Show("Lỗi tìm thông tin công tơ từ cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void dtgSearchMeter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == clEdit.Index)
                this.EditMeter(e.RowIndex);
            else if (e.ColumnIndex == clDelete.Index)
                this.DeleteMeter(e.RowIndex);
        }

        private void DeleteMeter(int currentRowIndex)
        {
            long meterId = long.Parse(dtgSearchMeter.Rows[currentRowIndex].Cells[clId.Index].Value.ToString());
            string meterCode = dtgSearchMeter.Rows[currentRowIndex].Cells[clMeterId.Index].Value.ToString();

            var rst = MessageBox.Show("Bạn có muốn xoá công tơ " + meterCode + " khỏi hệ thống", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rst != System.Windows.Forms.DialogResult.Yes)
                return;


            // Kiểm tra công tơ đã được sử dụng ở bảng measurementPointMeter hay chưa
            // Nếu chưa được sử dụng ở đâu cả thì cho phép xoá khỏi database
            // Nếu công tơ gắn với điểm đo ở trạng thái xoá thì chuyển trạng thái công tơ sang xoá
            // Nếu điểm đo ở trạng thái hoạt động không cho chuyển trạng thái công tơ

            MeasurementPointDataSet.MeasurementPointInfoDataTable masurementPointInfoDataTable = new MeasurementPointDataSet.MeasurementPointInfoDataTable();
            MeasurementPointInfoTableAdapter measurementPointInfoTableAdapter = new MeasurementPointInfoTableAdapter();
            try
            {
                measurementPointInfoTableAdapter.FillByMeterId(masurementPointInfoDataTable, meterId);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý measurementPointInfoTableAdapter.FillByMeterId(masurementPointInfoDataTable, meterId) chi tiết: ", ex);
                MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Công tơ đang được gắn vào điểm đo
            if (masurementPointInfoDataTable.Rows.Count > 0)
            {
                string measurementPointCode = masurementPointInfoDataTable.First().MeasurementPointCode;

                // Nếu điểm đo không ở trạng thái xoá thì không cho phép chuyển trạng thái khách hàng sang xoá 
                if (!masurementPointInfoDataTable.First().IsDeleted)
                {
                    MessageBox.Show("Không thể chuyển trạng thái xoá ở công tơ này. Mã công tơ: " + meterCode + " đang được liên kết với điểm đo " + measurementPointCode + " ở trạng thái hoạt động. ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Chuyển trạng thái công tơ sang xoá
                else
                {
                    try
                    {
                        // Kiểm tra tồn tại công tơ trong hệ thống
                        this.meterTableAdapter.FillByMeterId(this.meterDataTable, meterId);
                    }
                    catch (Exception ex)
                    {
                        Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý this.meterTableAdapter.FillByMeterId(this.meterDataTable, meterId) chi tiết: ", ex);
                        MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    if (this.meterDataTable.Rows.Count > 0)
                    {
                        this.meterDataTable.First().IsDeleted = true;
                        this.meterDataTable.First().EditedDate = DateTime.Now;
                        this.meterDataTable.First().EditedUserId = UserSession.UserName;
                        try
                        {
                            // Cập nhật vào database
                            this.meterTableAdapter.Update(this.meterDataTable);
                        }
                        catch (Exception ex)
                        {
                            Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý this.meterTableAdapter.Update(this.meterDataTable) chi tiết: ", ex);
                            MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Log người dùng
                        UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CustomerList);
                        UserSession.Action = SystemResource.User_Action_Update;
                        UserSession.Notes = "Chuyển trạng thái công tơ mã: " + meterCode + " sang Xoá";

                        this.InsertHistories();

                        MessageBox.Show("Công tơ có mã: " + meterCode + " được chuyển sang trạng thái thái xoá, do liên kết với điểm đo " + measurementPointCode + " ở trạng thái xoá. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Công tơ không còn tồn tại trong cơ sở dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Search();
                }

                // Không thực hiện bước tiếp theo
                return;
            }

            // Kiểm tra tồn tại dữ liệu ở các bảng trước khi xoá
            if (!this.CheckDataExistByMeterId(meterId))
            {
                return;
            }

            // Tìm lại công tơ trong database
            try
            {
                this.meterTableAdapter.FillByMeterId(this.meterDataTable, meterId);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý  this.meterTableAdapter.FillByMeterId(this.meterDataTable, meterId) chi tiết: ", ex);
                MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Xoá dữ liệu khỏi table
            for (int i = 0; i < this.meterDataTable.Rows.Count; i++)
            {
                this.meterDataTable[i].Delete();
            }

            // Xoá công tơ ra khỏi database
            try
            {
                this.meterTableAdapter.Update(this.meterDataTable);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CustomerList);
                UserSession.Action = SystemResource.User_Action_Delete;
                UserSession.Notes = "Xoá công tơ mã: " + meterCode;

                this.InsertHistories();

                this.Search();

                MessageBox.Show("Xoá công tơ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý  this.meterTableAdapter.FillByMeterId(this.meterDataTable, meterId) chi tiết: ", ex);
                MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckDataExistByMeterId(long meterId)
        {
            // Kiểm tra công tơ có dữ liệu trong bảng operation hay không?
            // Nếu có dữ liệu trong bảng operation thì không cho xoá
            #region Operation3P
            CheckDataExistOperation3PTableAdapter checkDataExistOperation3PTableAdapter = new CheckDataExistOperation3PTableAdapter();
            MeterDataSet.CheckDataExistOperation3PDataTable checkDataExistOperation3PDataTable = new MeterDataSet.CheckDataExistOperation3PDataTable();

            try
            {
                checkDataExistOperation3PTableAdapter.CheckDataExistByMeterId(checkDataExistOperation3PDataTable, meterId);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý  operation3PTableAdapter.CheckDataExistByMeterId(operation3PDataTable, meterId) chi tiết: ", ex);
                MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            if (checkDataExistOperation3PDataTable.Rows.Count > 0)
            {
                MessageBox.Show("Công tơ đang có dữ liệu bảng Operation3P bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            #endregion

            #region

            //#region LoadProfile3P
            //CheckDataExistLoadProfile3PTableAdapter checkDataExistLoadProfile3PTableAdapter = new CheckDataExistLoadProfile3PTableAdapter();
            //MeterDataSet.CheckDataExistLoadProfile3PDataTable checkDataExistLoadProfile3PDataTable = new MeterDataSet.CheckDataExistLoadProfile3PDataTable();

            //try
            //{
            //    checkDataExistLoadProfile3PTableAdapter.CheckDataExistByMeterId(checkDataExistLoadProfile3PDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý  checkDataExistLoadProfile3PTableAdapter.CheckDataExistByMeterId(checkDataExistLoadProfile3PDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}

            //if (checkDataExistLoadProfile3PDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng LoadProfile3P bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}
            //#endregion

            //#region Historical3P
            //CheckDataExistHistorical3PTableAdapter checkDataExistHistorical3PTableAdapter = new CheckDataExistHistorical3PTableAdapter();
            //MeterDataSet.CheckDataExistHistorical3PDataTable checkDataExistHistorical3PDataTable = new MeterDataSet.CheckDataExistHistorical3PDataTable();

            //try
            //{
            //    checkDataExistHistorical3PTableAdapter.CheckDataExistByMeterId(checkDataExistHistorical3PDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý  checkDataExistHistorical3PTableAdapter.CheckDataExistByMeterId(checkDataExistHistorical3PDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}

            //if (checkDataExistHistorical3PDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng Historical3P bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //#endregion

            //#region Instantaneous3P

            //CheckDataExistInstantaneous3PTableAdapter checkDataExistInstantaneous3PTableAdapter = new CheckDataExistInstantaneous3PTableAdapter();
            //MeterDataSet.CheckDataExistInstantaneous3PDataTable checkDataExistInstantaneous3PDataTable = new MeterDataSet.CheckDataExistInstantaneous3PDataTable();
            //try
            //{
            //    checkDataExistInstantaneous3PTableAdapter.CheckDataExistByMeterId(checkDataExistInstantaneous3PDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý  checkDataExistInstantaneous3PTableAdapter.CheckDataExistByMeterId(checkDataExistInstantaneous3PDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}

            //if (checkDataExistInstantaneous3PDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng Instantaneous3P bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //#endregion

            //#region OperationAlert
            //CheckDataExistOperationAlertTableAdapter checkDataExistOperationAlertTableAdapter = new CheckDataExistOperationAlertTableAdapter();
            //MeterDataSet.CheckDataExistOperationAlertDataTable checkDataExistOperationAlertDataTable = new MeterDataSet.CheckDataExistOperationAlertDataTable();
            //try
            //{
            //    checkDataExistOperationAlertTableAdapter.CheckDataExistByMeterId(checkDataExistOperationAlertDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý   checkDataExistOperationAlertTableAdapter.CheckDataExistByMeterId(checkDataExistOperationAlertDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}

            //if (checkDataExistOperationAlertDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng OperationAlert bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //#endregion

            //#region EventMeter
            //CheckDataExisEventMeterTableAdapter checkDataExisEventMeterTableAdapter = new CheckDataExisEventMeterTableAdapter();
            //MeterDataSet.CheckDataExisEventMeterDataTable checkDataExisEventMeterDataTable = new MeterDataSet.CheckDataExisEventMeterDataTable();
            //try
            //{
            //    checkDataExisEventMeterTableAdapter.CheckDataExistByMeterId(checkDataExisEventMeterDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý   checkDataExisEventMeterTableAdapter.CheckDataExistByMeterId(checkDataExisEventMeterDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}

            //if (checkDataExisEventMeterDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng EventMeter bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //#endregion

            //#region MeterScale

            //CheckDataExistMeterScaleTableAdapter checkDataExistMeterScaleTableAdapter = new CheckDataExistMeterScaleTableAdapter();
            //MeterDataSet.CheckDataExistMeterScaleDataTable checkDataExistMeterScaleDataTable = new MeterDataSet.CheckDataExistMeterScaleDataTable();

            //try
            //{
            //    checkDataExistMeterScaleTableAdapter.CheckDataExistByMeterId(checkDataExistMeterScaleDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý   checkDataExistMeterScaleTableAdapter.CheckDataExistByMeterId(checkDataExistMeterScaleDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}

            //if (checkDataExistMeterScaleDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng MeterScale bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //#endregion

            //#region ChangeMeterHistory

            //CheckDataExistChangeMeterHistoryTableAdapter checkDataExistChangeMeterHistoryTableAdapter = new CheckDataExistChangeMeterHistoryTableAdapter();
            //MeterDataSet.CheckDataExistChangeMeterHistoryDataTable checkDataExistChangeMeterHistoryDataTable = new MeterDataSet.CheckDataExistChangeMeterHistoryDataTable();

            //try
            //{
            //    checkDataExistChangeMeterHistoryTableAdapter.CheckDataExistByMeterId(checkDataExistChangeMeterHistoryDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý   checkDataExistChangeMeterHistoryTableAdapter.CheckDataExistByMeterId(checkDataExistChangeMeterHistoryDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}

            //if (checkDataExistChangeMeterHistoryDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng ChangeMeterHistory bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //#endregion

            //#region ComparitionDataHistorical
            //CheckDataExistComparitionDataHistoricalTableAdapter checkDataExistComparitionDataHistoricalTableAdapter = new CheckDataExistComparitionDataHistoricalTableAdapter();
            //MeterDataSet.CheckDataExistComparitionDataHistoricalDataTable checkDataExistComparitionDataHistoricalDataTable = new MeterDataSet.CheckDataExistComparitionDataHistoricalDataTable();

            //try
            //{
            //    checkDataExistComparitionDataHistoricalTableAdapter.CheckDataExistByMeterId(checkDataExistComparitionDataHistoricalDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý   checkDataExistComparitionDataHistoricalTableAdapter.CheckDataExistByMeterId(checkDataExistComparitionDataHistoricalDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}

            //if (checkDataExistComparitionDataHistoricalDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng ComparitionDataHistorical bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //#endregion

            //#region ComparitionDataOpBegin
            //CheckDataExistComparitionDataOpBeginTableAdapter checkDataExistComparitionDataOpBeginTableAdapter = new CheckDataExistComparitionDataOpBeginTableAdapter();
            //MeterDataSet.CheckDataExistComparitionDataOpBeginDataTable checkDataExistComparitionDataOpBeginDataTable = new MeterDataSet.CheckDataExistComparitionDataOpBeginDataTable();

            //try
            //{
            //    checkDataExistComparitionDataOpBeginTableAdapter.CheckDataExistByMeterId(checkDataExistComparitionDataOpBeginDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý   checkDataExistComparitionDataOpBeginTableAdapter.CheckDataExistByMeterId(checkDataExistComparitionDataOpBeginDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}

            //if (checkDataExistComparitionDataOpBeginDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng ComparitionDataOpBegin bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            //#endregion

            //#region ComparitionDataOpEnd

            //CheckDataExistComparitionDataOpEndTableAdapter checkDataExistComparitionDataOpEndTableAdapter = new CheckDataExistComparitionDataOpEndTableAdapter();
            //MeterDataSet.CheckDataExistComparitionDataOpEndDataTable checkDataExistComparitionDataOpEndDataTable = new MeterDataSet.CheckDataExistComparitionDataOpEndDataTable();

            //try
            //{
            //    checkDataExistComparitionDataOpEndTableAdapter.CheckDataExistByMeterId(checkDataExistComparitionDataOpEndDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý   checkDataExistComparitionDataOpEndTableAdapter.CheckDataExistByMeterId(checkDataExistComparitionDataOpEndDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}
            //if (checkDataExistComparitionDataOpEndDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng ComparitionDataOpEnd bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            //#endregion

            //#region Historical1P
            //CheckDataExistHistorical1PTableAdapter checkDataExistHistorical1PTableAdapter = new CheckDataExistHistorical1PTableAdapter();
            //MeterDataSet.CheckDataExistHistorical1PDataTable checkDataExistHistorical1PDataTable = new MeterDataSet.CheckDataExistHistorical1PDataTable();

            //try
            //{
            //    checkDataExistHistorical1PTableAdapter.CheckDataExistByMeterId(checkDataExistHistorical1PDataTable, meterId);

            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý   checkDataExistHistorical1PTableAdapter.CheckDataExistByMeterId(checkDataExistHistorical1PDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}
            //if (checkDataExistHistorical1PDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng Historical1P bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            //#endregion

            //#region Instantaneous1P
            //CheckDataExistInstantaneous1PTableAdapter checkDataExistInstantaneous1PTableAdapter = new CheckDataExistInstantaneous1PTableAdapter();
            //MeterDataSet.CheckDataExistInstantaneous1PDataTable checkDataExistInstantaneous1PDataTable = new MeterDataSet.CheckDataExistInstantaneous1PDataTable();


            //try
            //{
            //    checkDataExistInstantaneous1PTableAdapter.CheckDataExistByMeterId(checkDataExistInstantaneous1PDataTable, meterId);
            //}
            //catch (Exception ex)
            //{
            //    Logger.WriteLog(LogLevelL4N.ERROR, "UCMeterManagement.DeleteMeter -  lỗi xử lý    checkDataExistInstantaneous1PTableAdapter.CheckDataExistByMeterId(checkDataExistInstantaneous1PDataTable, meterId) chi tiết: ", ex);
            //    MessageBox.Show("Có lỗi trong quá trình xử lý dữ liệu. Bạn hãy kiểm tra log", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return false;
            //}
            //if (checkDataExistInstantaneous1PDataTable.Rows.Count > 0)
            //{
            //    MessageBox.Show("Công tơ đang có dữ liệu bảng Instantaneous1P bạn không thể xoá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}

            //#endregion

            #endregion

            return true;
        }
        
        private void EditMeter(int currentRowIndex)
        {
            long MeterId = long.Parse(dtgSearchMeter.Rows[currentRowIndex].Cells[clId.Index].Value.ToString());
            UpdateMeter updateMeter = new UpdateMeter(MeterId);
            updateMeter.ShowDialog();
        }

        private void btnCreateMeter_Click(object sender, EventArgs e)
        {
            AddMeter addMeter = new AddMeter();
            addMeter.ShowDialog();
        }

        private void dtgSearchMeter_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnCleanMeter_Click(object sender, EventArgs e)
        {
            txtMeterCode.Text = string.Empty;
            txtSerial.Text = string.Empty;
            cboIsUsed.SelectedIndex = 0;
            cboMeterType.SelectedIndex = 0;
            cboIsDeleted.SelectedIndex = 0;
            cboHistype.SelectedIndex = 0;
            dtCreateFrom.Value = DateTime.MinValue;
            dtCreateTo.Value = DateTime.MinValue;
            dtgSearchMeter.Rows.Clear();
            meterDataTable.Clear();
            MemoryManagement.MinimizeMemory();
        }

        private void dtgSearchMeter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            this.EditMeter(e.RowIndex);
        }

        private void UCMeterManagement_Load(object sender, EventArgs e)
        {
            // Log system histories
            this.LoadMeterType();         
        }
    }
}
