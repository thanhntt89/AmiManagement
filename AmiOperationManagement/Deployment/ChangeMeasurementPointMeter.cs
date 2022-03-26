using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.LogDeploymentDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.CustomerDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.DataConcentratorUnitDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointMeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterTypeAmiSysDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.Operation3PDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmiOperationManagement.Deployment
{
    public partial class ChangeMeasurementPointMeter : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private long currentMeasurementPointMeterId = -1;
        private long currentMeasurementPointId = -1;
        private long currentDucId = -1;
        private long currentMeterId = -1;

        private long oldMeasurementPointMeterId = -1;
        private long oldMeasurementPointId = -1;

        private long meterTempId = -1;
        private long dcuTempId = -1;

        private CustomerDataSet.CustomerDataTable customerDataTable = new CustomerDataSet.CustomerDataTable();
        private CustomerTableAdapter customerTableAdapter = new CustomerTableAdapter();

        private MeterDataSet.MeterDataTable meterDataTable = new MeterDataSet.MeterDataTable();
        private MeterTableAdapter meterTableAdapter = new MeterTableAdapter();

        private DataConcentratorUnitDataSet.DataConcentratorUnitDataTable dataConcentratorUnitDataTable = new DataConcentratorUnitDataSet.DataConcentratorUnitDataTable();
        private DataConcentratorUnitTableAdapter dataConcentratorUnitTableAdapter = new DataConcentratorUnitTableAdapter();

        private MeterTypeAmiSysDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeAmiSysDataSet.MeterTypeDataTable();
        private MeterTypeAmiSysTableAdapter meterTypeAmiSysTableAdapter = new MeterTypeAmiSysTableAdapter();

        private MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTable = new MeasurementPointDataSet.MeasurementPointDataTable();
        private MeasurementPointTableAdapter measurementPointTableAdapter = new MeasurementPointTableAdapter();

        private MeasurementPointMeterDataSet.MeasurementPointMeterDataTable measurementPointMeterDataTable = new MeasurementPointMeterDataSet.MeasurementPointMeterDataTable();
        private MeasurementPointMeterTableAdapter measurementPointMeterTableAdapter = new MeasurementPointMeterTableAdapter();

        private MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTableCombox = new MeasurementPointDataSet.MeasurementPointDataTable();

        private Operation3PDataSet.Operation3PDataTable updateMeasurementPointMeterOperation3PDataTable = new Operation3PDataSet.Operation3PDataTable();

        private Operation3PDataSet.Operation3PDataTable operation3PDataTable = new Operation3PDataSet.Operation3PDataTable();
        private Operation3PTableAdapter operation3PTableAdapter = new Operation3PTableAdapter();


        private Operation3PDataSet.UpdateMeasurementPointMeterForOperation3PDataTable updateMeasurementPointMeterForOperation3PDataTable = new Operation3PDataSet.UpdateMeasurementPointMeterForOperation3PDataTable();
        private UpdateMeasurementPointMeterForOperation3PTableAdapter updateMeasurementPointMeterForOperation3PTableAdapter = new UpdateMeasurementPointMeterForOperation3PTableAdapter();


        private MeasurementPointTransaction measurementPointTransaction = new MeasurementPointTransaction();
        private MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTableOld = new MeasurementPointDataSet.MeasurementPointDataTable();
        private MeasurementPointMeterDataSet.MeasurementPointMeterDataTable measurementPointMeterDataTableOld = new
            MeasurementPointMeterDataSet.MeasurementPointMeterDataTable();

        private LogDeploymentDataSet.LogDeploymentDataTable logDeploymentDataTable = new LogDeploymentDataSet.LogDeploymentDataTable();
        private LogDeploymentTableAdapter logDeploymentTableAdapter = new LogDeploymentTableAdapter();

        private bool isSaveLog = false;

        public ChangeMeasurementPointMeter(long measurementPointId, long measurementPointMeterId)
        {
            InitializeComponent();

            this.currentMeasurementPointId = measurementPointId;
            this.currentMeasurementPointMeterId = measurementPointMeterId;
        }

        private void LoadMeasurementPointById()
        {
            try
            {
                this.measurementPointTableAdapter.FillByMeasurementPointId(this.measurementPointDataTable, this.currentMeasurementPointId);

                if (this.measurementPointDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Điểm đo không còn tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // DucId hiện tại
                this.currentDucId = this.measurementPointDataTable.First().IsDcuIdNull() ? -1 : this.measurementPointDataTable.First().DcuId;

                txtMpCode.Text = this.measurementPointDataTable.First().MeasurementPointId;
                txtMpName.Text = this.measurementPointDataTable.First().Name;
                txtDcuCode.Text = this.LoadDcuCodeById(this.currentDucId);
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
            if (this.currentMeasurementPointMeterId == -1)
                return;

            try
            {
                this.measurementPointMeterTableAdapter.FillByMeasurementPointMeterId(this.measurementPointMeterDataTable, this.currentMeasurementPointMeterId);

                if (this.measurementPointMeterDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Công tơ không còn tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Meter hiện tại
                this.currentMeterId = this.measurementPointMeterDataTable.First().MeterId;

                MeterDataSet.MeterDataTable meter = LoadMeterCodeById(this.currentMeterId);
                if (meter != null)
                {
                    txtMeterCode.Text = meter.First().MeterId;
                    cboTypeMeter.SelectedValue = meter.First().MeterTypeId;
                }
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

        private void LoadMeterType()
        {
            try
            {
                meterTypeAmiSysTableAdapter.Fill(meterTypeDataTable);

            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadMeterType - Tải dữ liệu cho LoadMeterType không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin loại công tơ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTypeMeter.Focus();
                return;
            }

            cboTypeMeter.DataSource = this.meterTypeDataTable;
            cboTypeMeter.DisplayMember = this.meterTypeDataTable.NameColumn.ColumnName;
            cboTypeMeter.ValueMember = this.meterTypeDataTable.IdColumn.ColumnName;
            cboTypeMeter.SelectedIndex = -1;

            // Load old metertyoe
            BindingSource bsToStatuses = new BindingSource();
            bsToStatuses.DataSource = meterTypeDataTable;

            cboOldMeterType.DataSource = bsToStatuses;
            cboOldMeterType.DisplayMember = this.meterTypeDataTable.NameColumn.ColumnName;
            cboOldMeterType.ValueMember = this.meterTypeDataTable.IdColumn.ColumnName;
            cboOldMeterType.SelectedIndex = -1;
        }

        private void ChangeMeasurementPointMeter_Load(object sender, EventArgs e)
        {
            this.LoadMeterType();
            this.LoadMeasurementPointById();
            this.LoadMeasurementPointMeter();
            btnSearch_Click(null, null);
        }

        private void btSaveMp_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtOldMpCode.Text) || this.measurementPointDataTableOld.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn điểm đo thay thế", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra nếu 2 điểm đo này có mã giống nhau không cho cấp nhật
            if (this.currentMeasurementPointId == this.oldMeasurementPointId)
            {
                MessageBox.Show("Điểm đo thay thế không được giống điểm đo hiện tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOldDcuCode.Text))
            {
                MessageBox.Show("Điểm đo không có thiết bị", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOldMeterCode.Text))
            {
                MessageBox.Show("Điểm đo không có công tơ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            isSaveLog = false;

            if (!string.IsNullOrWhiteSpace(txtDeployUser.Text) || !string.IsNullOrWhiteSpace(txtStatusFail.Text) || !string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || !string.IsNullOrWhiteSpace(txtNote.Text))
            {
                isSaveLog = true;
                if (string.IsNullOrWhiteSpace(txtDeployUser.Text))
                {
                    MessageBox.Show("Người đi triển khai không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDeployUser.Focus();
                    tabControl2.SelectedTab = tabLogs;
                    return false;
                }
                if (string.IsNullOrWhiteSpace(txtStatusFail.Text))
                {
                    MessageBox.Show("Tình trạng lỗi không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStatusFail.Focus();
                    tabControl2.SelectedTab = tabLogs;
                    return false;
                }
            }

            if (this.measurementPointDataTable.Count == 0)
            {
                MessageBox.Show("Điểm đo " + txtMpCode.Text + " không còn tồn tại. Cập nhật không thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void SaveData()
        {
            if (!Validation())
                return;

            // Lấy về meterIdTemp và dcuTempId
            try
            {
                meterTableAdapter.FillByMeterCode(meterDataTable, Constant.MeterTemp);
                if (meterDataTable.Rows.Count > 0)
                {
                    this.meterTempId = meterDataTable.First().Id;
                }
                else
                {
                    MessageBox.Show("Lỗi thay điểm không thành công. Không tìm thấy công tơ MeterTemp để sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "  meterTableAdapter.FillByMeterCode(meterDataTable," + Constant.MeterTemp + ");. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi trong quá trình xử lý. Không tìm thấy mã công tơ MeterTemp. Chi tiết kiểm tra logs", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dataConcentratorUnitTableAdapter.FillByDcuCode(dataConcentratorUnitDataTable, Constant.DcuTemp);
                if (dataConcentratorUnitDataTable.Rows.Count > 0)
                {
                    this.dcuTempId = dataConcentratorUnitDataTable.First().Id;
                }
                else
                {
                    MessageBox.Show("Lỗi thay điểm không thành công. Không tìm thấy thiết bị DcuTemp để sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "dataConcentratorUnitTableAdapter.FillByDcuCode(dataConcentratorUnitDataTable," + Constant.DcuTemp + ");. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi trong quá trình xử lý. Không tìm thấy mã thiết bị DcuTemp. Chi tiết kiểm tra logs", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update bảng MeasuerementPoint thay thế DcuId cũ bằng DcuId mới
            this.measurementPointDataTableOld.First().DcuId = this.currentDucId;

            this.measurementPointDataTableOld.First().EditedDate = DateTime.Now;
            this.measurementPointDataTableOld.First().EditedUserId = UserSession.UserName;

            // Update date bảng MeasuerementPointMeter thay MeterId cũ bằng MeterId mới
            this.measurementPointMeterDataTableOld.First().MeterId = this.currentMeterId;

            this.measurementPointMeterDataTableOld.First().EditedDate = DateTime.Now;
            this.measurementPointMeterDataTableOld.First().EditedUserId = UserSession.UserName;

            // Update trường MeasuerementPointMeterId của điểm đo cũ vào dữ liệu điểm đo mới lên theo  MeasuerementPointMeterId mới và meterid trong bản tin operation 
            this.updateMeasurementPointMeterForOperation3PTableAdapter.FillByMeasurementPointMeterIdAndMeterId(this.updateMeasurementPointMeterForOperation3PDataTable, this.currentMeasurementPointMeterId, this.currentMeterId);

            // Thay dữ liệu điểm đo của công tơ hiện tại vào cho điểm đo cũ
            for (int i = 0; i < this.updateMeasurementPointMeterForOperation3PDataTable.Rows.Count; i++)
            {
                this.updateMeasurementPointMeterForOperation3PDataTable[i].NewMeasurementPointMeterId = this.oldMeasurementPointMeterId;
            }

            // Tìm công tơ ở điểm đo mới theo mpmId ở bảng operation bản tin cuối cùng
            // Lấy về mã công tơ để cập nhật lại cho điểm đo này
            // Chuyển dcuId ở điểm này sang null
            // Nếu tìm thấy meterId thì điểm đo để nguyên trạng thái
            // Nếu ko tìm thấy meterId thì chuyển sang trạng thái xoá
            this.operation3PTableAdapter.GetMeterIdOldByMeasurementPointMeterIdAndCurrentMeterId(this.operation3PDataTable, this.currentMeasurementPointMeterId, this.currentMeterId);

            // Nếu điểm đo mới tồn tại công tớ cũ gần nhất ở bản tin operation thì update lại công tơ cho nó
            if (this.operation3PDataTable.Count > 0)
            {
                this.measurementPointDataTable.First().SetDcuIdNull();
                this.measurementPointMeterDataTable.First().MeterId = this.operation3PDataTable.First().MeterId;
                this.measurementPointDataTable.First().IsDeleted = false;
            }
            else
            {
                this.measurementPointDataTable.First().IsDeleted = true;
                this.measurementPointDataTable.First().DcuId = this.dcuTempId;
                this.measurementPointMeterDataTable.First().MeterId = this.meterTempId;
            }

            // Chuyển thông tin điểm đo mới sang xoá và chuyển các meter vs dcu sang temp
            this.measurementPointDataTable.First().EditedDate = DateTime.Now;
            this.measurementPointDataTable.First().EditedUserId = UserSession.UserName;

            try
            {
                this.measurementPointTransaction.ChangeMeasurementPoint(this.measurementPointDataTableOld, this.measurementPointMeterDataTableOld, this.updateMeasurementPointMeterForOperation3PDataTable, this.measurementPointDataTable, this.measurementPointMeterDataTable, this.measurementPointTableAdapter, this.measurementPointMeterTableAdapter, this.operation3PTableAdapter, this.updateMeasurementPointMeterForOperation3PTableAdapter);

                // Logs triển khai
                if (isSaveLog)
                {
                    var newRows = this.logDeploymentDataTable.NewLogDeploymentRow();
                    newRows.User = UserSession.UserName;
                    newRows.Action = Constant.UpdateMeasurementPointText;
                    newRows.MeasurementPointId = txtOldMpCode.Text;
                    newRows.Name = txtOldMpName.Text;
                    newRows.OldDcuCode = string.IsNullOrWhiteSpace(txtOldDcuCode.Text) ? null : txtOldDcuCode.Text;
                    newRows.OldMeterCode = txtOldMeterCode.Text;
                    newRows.NewDcuCode = txtDcuCode.Text;
                    newRows.NewMeterCode = txtMeterCode.Text;
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
                UserSession.Action = SystemResource.User_Action_Update;
                UserSession.Notes = "Điểm đo: "
                    + txtOldMpCode.Text
                    + "\nTên điểm: " + txtOldMpName.Text
                    + "\nMã thiết bị:" + txtOldDcuCode.Text
                    + "\nMã công tơ:" + txtOldMeterCode.Text
                    + "\nThay bằng"
                     + "\nMã thiết bị mới:" + txtDcuCode.Text
                    + "\nMã công tơ mới:" + txtMeterCode.Text
                    ;

                controlBase.InsertHistories();
                MessageBox.Show("Cập nhật thông tin điểm đo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "ChangeMeasurementPointMeter.SaveData - Lỗi cập nhật điểm đo. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi trong quá trình cập nhật đo. Chi tiết xem logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCacelMp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchingMeasurementPoint searchingMeasurementPoint = new SearchingMeasurementPoint();
            searchingMeasurementPoint.ShowDialog();
            btSaveMp.Focus();
            if (!searchingMeasurementPoint.isOk)
                return;

            this.oldMeasurementPointId = searchingMeasurementPoint.measurementPointId;
            this.oldMeasurementPointMeterId = searchingMeasurementPoint.measurementPointMeterId;
            this.LoadMeasuremnetPointInfo();
        }

        private void LoadMeasuremnetPointInfo()
        {
            txtOldCustomerCode.Text = string.Empty;
            txtOldCustomerAddress.Text = string.Empty;
            txtOldMeterCode.Text = string.Empty;
            txtOldDcuCode.Text = string.Empty;
            cboOldMeterType.SelectedIndex = -1;
            txtOldMpCode.Text = string.Empty;
            txtOldMpAddress.Text = string.Empty;
            txtOldMpName.Text = string.Empty;

            try
            {
                this.measurementPointTableAdapter.FillByMeasurementPointId(this.measurementPointDataTableOld, this.oldMeasurementPointId);

                if (this.measurementPointDataTableOld.Rows.Count == 0)
                {
                    MessageBox.Show("Điểm đo không còn tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtOldMpCode.Text = this.measurementPointDataTableOld.First().MeasurementPointId;
                txtOldMpName.Text = this.measurementPointDataTableOld.First().Name;
                txtOldMpAddress.Text = this.measurementPointDataTableOld.First().IsAddressNull() ? string.Empty : measurementPointDataTableOld.First().Address;
                txtOldDcuCode.Text = LoadDcuCodeById(this.measurementPointDataTableOld.First().IsDcuIdNull() ? -1 : this.measurementPointDataTableOld.First().DcuId);
                cboTypeMeter.SelectedValue = this.measurementPointDataTableOld.First().MeterTypeId;

                // Load MeasurementPointMeter
                this.measurementPointMeterTableAdapter.FillByMeasurementPointMeterId(this.measurementPointMeterDataTableOld, this.oldMeasurementPointMeterId);

                if (this.measurementPointMeterDataTableOld.Rows.Count == 0)
                {
                    MessageBox.Show("Công tơ ở điểm đo không còn tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CustomerDataSet.CustomerDataTable customer = LoadCustomerById(this.measurementPointMeterDataTableOld.First().IsCustomerIdNull() ? -1 : this.measurementPointMeterDataTableOld.First().CustomerId);
                if (customer != null)
                {
                    txtOldCustomerCode.Text = customer.First().CustomerId;
                    txtOldCustomerAddress.Text = customer.First().IsAddressNull() ? string.Empty : customer.First().Address;
                }

                MeterDataSet.MeterDataTable meter = LoadMeterCodeById(this.measurementPointMeterDataTableOld.First().MeterId);
                if (meter != null)
                {
                    txtOldMeterCode.Text = meter.First().MeterId; ;
                    cboOldMeterType.SelectedValue = meter.First().MeterTypeId;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeasurementPointMeter.LoadMeasurementPoint - Lỗi load dữ liệu điểm đo  this.measurementPointTableAdapter.FillByMeasurementPointId(this.measurementPointDataTable, this.measurementPointId). Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tải dữ liệu điểm đo từ cơ sở dữ liệu. Chi tiết xem logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ChangeMeasurementPointMeter_FormClosing(object sender, FormClosingEventArgs e)
        {
            MemoryManagement.MinimizeMemory();
        }

    }
}
