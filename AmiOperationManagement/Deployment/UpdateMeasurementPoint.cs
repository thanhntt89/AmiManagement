using System;
using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.MeasurementPointGroupDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.CustomerDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterTypeAmiSysDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.ContractDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointMeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.StationDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.DataConcentratorUnitDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using AmiOperationLib;
using System.Linq;
using OperationDTO.AmiSystemDataSet.MeasurementPointStatusDataSetTableAdapters;
using AmiOperationManagement.Resources;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.LogDeploymentDataSetTableAdapters;

namespace AmiOperationManagement.Deployment
{
    public partial class UpdateMeasurementPoint : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();


        private long measurementPointMeterId = -1;
        private long measurementPointId = -1;

        private MeasurementPointTableAdapter measurementPointTableAdapter = new MeasurementPointTableAdapter();
        private MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTable = new MeasurementPointDataSet.MeasurementPointDataTable();

        private CustomerDataSet.CustomerDataTable customerDataTable = new CustomerDataSet.CustomerDataTable();
        private CustomerTableAdapter customerTableAdapter = new CustomerTableAdapter();

        private MeterDataSet.MeterDataTable meterDataTable = new MeterDataSet.MeterDataTable();
        private MeterTableAdapter meterTableAdapter = new MeterTableAdapter();

        private MeasurementPointGroupDataSet.MeasurementPointGroupDataTable measurementPointGroupDataTable = new MeasurementPointGroupDataSet.MeasurementPointGroupDataTable();


        private ContractDataSet.ContractDataTable contractDataTable = new ContractDataSet.ContractDataTable();
        private ContractTableAdapter contractTableAdapter = new ContractTableAdapter();

        private DataConcentratorUnitDataSet.DataConcentratorUnitDataTable dataConcentratorUnitDataTable = new DataConcentratorUnitDataSet.DataConcentratorUnitDataTable();
        private DataConcentratorUnitTableAdapter dataConcentratorUnitTableAdapter = new DataConcentratorUnitTableAdapter();

        private MeterTypeAmiSysDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeAmiSysDataSet.MeterTypeDataTable();
        private MeterTypeAmiSysTableAdapter meterTypeAmiSysTableAdapter = new MeterTypeAmiSysTableAdapter();

        private MeasurementPointMeterDataSet.MeasurementPointMeterDataTable measurementPointMeterDataTable = new MeasurementPointMeterDataSet.MeasurementPointMeterDataTable();
        private MeasurementPointMeterTableAdapter measurementPointMeterTableAdapter = new MeasurementPointMeterTableAdapter();

        private StationDataSet.StationDataTable stationDataTable = new StationDataSet.StationDataTable();

        private MeasurementPointStatusDataSet.MeasurementPointStatusDataTable measurementPointStatusDataTable = new MeasurementPointStatusDataSet.MeasurementPointStatusDataTable();
        private MeasurementPointStatusTableAdapter measurementPointStatusTableAdapter = new MeasurementPointStatusTableAdapter();

        private MeasurementPointTransaction measurementPointTransaction = new MeasurementPointTransaction();

        private LogDeploymentDataSet.LogDeploymentDataTable logDeploymentDataTable = new LogDeploymentDataSet.LogDeploymentDataTable();
        private LogDeploymentTableAdapter logDeploymentTableAdapter = new LogDeploymentTableAdapter();

        private bool isSaveLog = false;

        public UpdateMeasurementPoint
(long measurementPointId, long measurementPointMeterId)
        {
            InitializeComponent();
            this.measurementPointMeterId = measurementPointMeterId;
            this.measurementPointId = measurementPointId;
            cboLogsType.SelectedItem = itemUpdateMeasurementPoint;
        }

        private void LoadMeasurementPoint()
        {
            try
            {
                this.measurementPointTableAdapter.FillByMeasurementPointId(this.measurementPointDataTable, this.measurementPointId);

                if (this.measurementPointDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Điểm đo không còn tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                txtMpCode.Text = this.measurementPointDataTable.First().MeasurementPointId;
                txtMpName.Text = this.measurementPointDataTable.First().Name;
                cboGroupMp.SelectedValue = this.measurementPointDataTable.First().MeasurementPointGroupId;
                cboContract.SelectedValue = this.measurementPointDataTable.First().IsTakeOverBillNull() ? -1 : this.measurementPointDataTable.First().TakeOverBill;

                //cboDcuCode.SelectedValue = this.measurementPointDataTable.First().IsDcuIdNull() ? -1 : this.measurementPointDataTable.First().DcuId;
                cboTypeMeter.SelectedValue = this.measurementPointDataTable.First().MeterTypeId;
                cboIsDeleted.SelectedIndex = this.measurementPointDataTable.First().IsDeleted ? 1 : 0;

                cboMpType.SelectedValue = this.measurementPointDataTable.First().Type;

                txtMpAddress.Text = this.measurementPointDataTable.First().IsAddressNull() ? string.Empty : this.measurementPointDataTable.First().Address;
                txtNotes.Text = this.measurementPointDataTable.First().IsNoteNull() ? string.Empty : this.measurementPointDataTable.First().Note;

                lblDcuCode.Text = LoadDcuCodeById(this.measurementPointDataTable.First().IsDcuIdNull() ? -1 : this.measurementPointDataTable.First().DcuId);

            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeasurementPointMeter.LoadMeasurementPoint - Lỗi load dữ liệu điểm đo  this.measurementPointTableAdapter.FillByMeasurementPointId(this.measurementPointDataTable, this.measurementPointId). Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tải dữ liệu điểm đo từ cơ sở dữ liệu. Chi tiết xem logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadMeasurementPointMeter()
        {
            try
            {
                this.measurementPointMeterTableAdapter.FillByMeasurementPointMeterId(this.measurementPointMeterDataTable, this.measurementPointMeterId);

                if (this.measurementPointMeterDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Công tơ không còn tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                CustomerDataSet.CustomerDataTable customer = LoadCustomerById(this.measurementPointMeterDataTable.First().IsCustomerIdNull() ? -1 : this.measurementPointMeterDataTable.First().CustomerId);
                if (customer != null)
                {
                    lblCustomerCode.Text = customer.First().CustomerId;
                    txtCustomerAdrress.AppendText(customer.First().IsNameNull() ? string.Empty : customer.First().Name);
                    txtCustomerAdrress.AppendText("\n");
                    txtCustomerAdrress.AppendText("Địa chỉ: ");
                    txtCustomerAdrress.AppendText(customer.First().IsAddressNull() ? string.Empty : customer.First().Address);
                }

                MeterDataSet.MeterDataTable meter = LoadMeterCodeById(this.measurementPointMeterDataTable.First().MeterId);
                if (meter != null)
                {
                    lblMeterCode.Text = meter.First().MeterId;
                }

                cboStation.SelectedValue = this.measurementPointMeterDataTable.First().IsStationIdNull() ? -1 : this.measurementPointMeterDataTable.First().StationId;
                cboMpmStatus.SelectedItem = this.measurementPointMeterDataTable.First().Status == 1 ? itemActive : itemDeactive;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeasurementPointMeter.LoadMeasurementPointMeter - Lỗi load dữ liệu công tơ this.measurementPointMeterTableAdapter.FillByMeasurementPointMeterId(this.measurementPointMeterDataTable, this.measurementPointMeterId). Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tải dữ liệu điểm đo từ cơ sở dữ liệu. Chi tiết xem logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private string LoadDcuCodeById(long dcucid)
        {
            try
            {
                dataConcentratorUnitTableAdapter.FillByDcuId(dataConcentratorUnitDataTable, dcucid);
                if (dataConcentratorUnitDataTable.Rows.Count > 0)
                    return dataConcentratorUnitDataTable.First().DcuId;
                else
                    return null;

            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "LoadDcuCodeById(long " + dcucid + ") - Tải dữ liệu cho LoadDcuCode không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin thiết bị. Chi tiết lỗi kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private MeterDataSet.MeterDataTable LoadMeterCodeById(long meterId)
        {
            try
            {
                // Nếu điểm đo mới chưa gắn đồng hồ                                
                meterTableAdapter.FillByMeterId(meterDataTable, meterId);
                if (meterDataTable.Rows.Count > 0)
                {
                    return meterDataTable;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, " LoadMeterCodeById(long" + meterId + ") - Tải dữ liệu cho LoadMeter không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin Công tơ từ cơ sở dữ liệu. Chi tiết lỗi kiểm tra logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private CustomerDataSet.CustomerDataTable LoadCustomerById(long customerId)
        {
            try
            {
                this.customerTableAdapter.FillById(this.customerDataTable, customerId);
                if (this.customerDataTable.Rows.Count > 0)
                    return this.customerDataTable;
                else
                    return null;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "LoadCustomerById(long " + customerId + ") - Tải dữ liệu cho LoadCustomer không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin Khách hàng từ cơ sở dữ liệu. Chi tiết lỗi kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void LoadStatus()
        {
            try
            {
                measurementPointStatusTableAdapter.Fill(measurementPointStatusDataTable);

                cboMpType.DataSource = measurementPointStatusDataTable;
                cboMpType.DisplayMember = measurementPointStatusDataTable.TypeNameColumn.ColumnName;
                cboMpType.ValueMember = measurementPointStatusDataTable.TypeIdColumn.ColumnName;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadStatus - Tải dữ liệu cho LoadStatus không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin trạng thái điểm đo. Chi tiết lỗi xem file logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadStation()
        {
            try
            {
                this.stationDataTable = (StationDataSet.StationDataTable)UserSession.StationDataTable.Copy();

                var newRows = this.stationDataTable.NewStationRow();

                newRows.Id = -1;
                newRows.Name = Constant.SELECT_ALL_TEXT;
                newRows.OrgId = -1;
                newRows.StationCode = "-1";
                newRows.StationId = "-1";
                newRows.IsDeleted = false;
                this.stationDataTable.Rows.InsertAt(newRows, 0);

                cboStation.DataSource = this.stationDataTable;
                cboStation.ValueMember = this.stationDataTable.IdColumn.ColumnName;
                cboStation.DisplayMember = this.stationDataTable.NameColumn.ColumnName;

                cboStation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboStation.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadMeter - Tải dữ liệu cho LoadMeter không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin trạm từ cơ sở dữ liệu. Chi tiết lỗi kiểm tra logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void LoadContract()
        {
            try
            {
                contractTableAdapter.Fill(contractDataTable);

                var newRows = this.contractDataTable.NewContractRow();

                newRows.Id = -1;
                newRows.Note = Constant.SELECT_ALL_TEXT;
                newRows.ContractId = "-1";

                this.contractDataTable.Rows.InsertAt(newRows, 0);

                cboContract.DataSource = this.contractDataTable;
                cboContract.DisplayMember = this.contractDataTable.NoteColumn.ColumnName;
                cboContract.ValueMember = this.contractDataTable.IdColumn.ColumnName;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadContract - Tải dữ liệu cho LoadContract không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin hợp đồng của điểm đo. Chi tiết kiểm tra logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadMeterType()
        {
            try
            {
                meterTypeAmiSysTableAdapter.Fill(meterTypeDataTable);
                cboTypeMeter.DataSource = this.meterTypeDataTable;
                cboTypeMeter.DisplayMember = this.meterTypeDataTable.NameColumn.ColumnName;
                cboTypeMeter.ValueMember = this.meterTypeDataTable.IdColumn.ColumnName;
                cboTypeMeter.Enabled = false;
                cboTypeMeter.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadMeterType - Tải dữ liệu cho LoadMeterType không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin loại công tơ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTypeMeter.Focus();
                this.Close();
            }
        }

        private void LoadMeasurementPointGroup()
        {
            try
            {
                measurementPointGroupDataTable = UserSession.MeasurementPointGroupDataTable;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeasurementPointMeter.LoadMeasurementPointGroup - Tải dữ liệu cho LoadMeasurementPointGroup không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin điện lực quản lý điểm đo. Chi tiết kiểm tra logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cboGroupMp.DataSource = measurementPointGroupDataTable;
            cboGroupMp.DisplayMember = this.measurementPointGroupDataTable.NameColumn.ColumnName;
            cboGroupMp.ValueMember = this.measurementPointGroupDataTable.IdColumn.ColumnName;
        }

        private void UpdateMeasurementPoint_Load(object sender, EventArgs e)
        {
            this.LoadStatus();
            this.LoadContract();
            this.LoadMeterType();
            this.LoadStation();
            this.LoadMeasurementPointGroup();
            this.LoadMeasurementPoint();
            this.LoadMeasurementPointMeter();
        }

        private bool Validation()
        {
            if (cboGroupMp.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn điện lực cho điểm đo", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGroupMp.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(lblDcuCode.Text))
            {
                MessageBox.Show("Thiết bị không tồn tại không thể cập nhật", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblDcuCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMpCode.Text))
            {
                MessageBox.Show("Mã điểm đo không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMpCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMpName.Text))
            {
                MessageBox.Show("Tên điểm đo không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMpName.Focus();
                return false;
            }

            isSaveLog = false;

            if (!string.IsNullOrWhiteSpace(txtDeployUser.Text) || !string.IsNullOrWhiteSpace(txtStatusFail.Text) || !string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !string.IsNullOrWhiteSpace(txtNote.Text) || !string.IsNullOrWhiteSpace(txtOldDcuCode.Text) || !string.IsNullOrWhiteSpace(txtOldMeterCode.Text)
                )
            {
                isSaveLog = true;
                if (string.IsNullOrWhiteSpace(txtDeployUser.Text))
                {
                    MessageBox.Show("Người đi triển khai không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDeployUser.Focus();
                    tabControl.SelectedTab = tabLogs;
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtStatusFail.Text))
                {
                    MessageBox.Show("Tình trạng lỗi không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStatusFail.Focus();
                    tabControl.SelectedTab = tabLogs;
                    return false;
                }
            }

            MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTableCheck = new MeasurementPointDataSet.MeasurementPointDataTable();

            // Kiểm tra xem mã điểm đo này đã tồn tại hay chưa?
            try
            {
                this.measurementPointTableAdapter.FillByMeasurementPointCode(measurementPointDataTableCheck, txtMpCode.Text);
                // Điểm đo đã tồn tại trong cơ sở dữ liệu
                if (measurementPointDataTableCheck.Rows.Count > 0)
                {
                    if (measurementPointDataTableCheck.First().Id != this.measurementPointId)
                    {
                        MessageBox.Show("Mã điểm đo đã tồn tại. Bạn phải nhập vào mã khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMpCode.Focus();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private void Save()
        {
            if (!Validation())
                return;
            this.EditMeasurementPoint();
        }

        private void EditMeasurementPoint()
        {
            try
            {
                measurementPointDataTable.First().MeasurementPointGroupId = long.Parse(cboGroupMp.SelectedValue.ToString());
                measurementPointDataTable.First().MeasurementPointId = txtMpCode.Text;
                if (cboContract.SelectedIndex > 0)
                    measurementPointDataTable.First().TakeOverBill = long.Parse(cboContract.SelectedValue.ToString());
                else
                    measurementPointDataTable.First().SetTakeOverBillNull();

                measurementPointDataTable.First().Name = txtMpName.Text;
                measurementPointDataTable.First().Type = int.Parse(cboMpType.SelectedValue.ToString());
                measurementPointDataTable.First().Note = txtNotes.Text;
                measurementPointDataTable.First().Address = txtMpAddress.Text;
                measurementPointDataTable.First().IsDeleted = cboIsDeleted.SelectedIndex == 0 ? false : true;
                measurementPointDataTable.First().EditedDate = DateTime.Now;
                measurementPointDataTable.First().EditedUserId = UserSession.UserName;

                // MeasurementPointMeter Info
                if (cboStation.SelectedIndex > 0)
                    this.measurementPointMeterDataTable.First().StationId = int.Parse(cboStation.SelectedValue.ToString());
                else
                    this.measurementPointMeterDataTable.First().SetStationIdNull();
                this.measurementPointMeterDataTable.First().Status = cboMpmStatus.SelectedItem.Equals(itemActive) ? 1 : 0;
                
                this.measurementPointMeterDataTable.First().EditedDate = DateTime.Now;
                this.measurementPointMeterDataTable.First().EditedUserId = UserSession.UserName;

                this.measurementPointTransaction.AddMeasurementPoint(measurementPointDataTable, measurementPointMeterDataTable, measurementPointTableAdapter, measurementPointMeterTableAdapter);


                // Logs triển khai
                if (isSaveLog)
                {
                    var newRows = this.logDeploymentDataTable.NewLogDeploymentRow();
                    newRows.User = UserSession.UserName;
                    newRows.Action = cboLogsType.SelectedItem == itemUpdateMeasurementPoint ? Constant.UpdateMeasurementPointText : Constant.CreatedMeasurementPointText;
                    newRows.MeasurementPointId = txtMpCode.Text;
                    newRows.Name = txtMpName.Text;

                    newRows.NewDcuCode = lblDcuCode.Text;
                    newRows.NewMeterCode = lblMeterCode.Text;


                    if (!string.IsNullOrWhiteSpace(txtOldDcuCode.Text))
                        newRows.OldDcuCode = txtOldDcuCode.Text;

                    if (!string.IsNullOrWhiteSpace(txtOldMeterCode.Text))
                        newRows.OldMeterCode = txtOldMeterCode.Text;

                    newRows.UserDeploy = txtDeployUser.Text;
                    newRows.Phone = txtPhoneNumber.Text;
                    newRows.StatusMeasurementPoint = txtStatusFail.Text;
                    newRows.Note = txtNote.Text;
                    newRows.CreateDate = DateTime.Now;

                    this.logDeploymentDataTable.AddLogDeploymentRow(newRows);

                    this.logDeploymentTableAdapter.Update(this.logDeploymentDataTable);
                }

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CreateMeasurementPoint);
                UserSession.Action = SystemResource.User_Action_Add;

                string logsType = cboLogsType.SelectedItem == itemNewMeasurementPoint ? itemNewMeasurementPoint.Text : itemUpdateMeasurementPoint.Text;

                UserSession.Notes = logsType + ": "
                    + txtMpCode.Text
                    + "\nTên điểm: " + txtMpName.Text
                    + "\nĐịa chỉ: " + txtMpAddress.Text
                    + "\nLoại điểm: " + cboMpType.Text
                    + "\nKhách hàng: " + lblCustomerCode.Text
                    + "\nĐịa chỉ: " + txtCustomerAdrress.Text
                    + "\nTrạm: " + cboStation.Text
                    + "\nModem: " + lblDcuCode.Text
                    + "\nCông tơ: " + lblMeterCode.Text
                    + "\nLoại công tơ: " + cboTypeMeter.Text
                    + "\nGhi chú: " + txtNotes.Text;

                controlBase.InsertHistories();
                MessageBox.Show("Cập nhật thông tin điểm đo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.CreateNewMeasurementPoint - Lỗi tạo điểm đo mới. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tạo điểm đo mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveMp_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void btCacelMp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}