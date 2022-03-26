using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.ContractDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.CustomerDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.DataConcentratorUnitDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointGroupDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointMeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeterTypeAmiSysDataSetTableAdapters;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AmiOperationManagement.Deployment
{
    public partial class UpdateMeasurementPointMeter : DevComponents.DotNetBar.Metro.MetroForm
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
        private MeasurementPointGroupTableAdapter measurementPointGroupTableAdapter = new MeasurementPointGroupTableAdapter();

        private ContractDataSet.ContractDataTable contractDataTable = new ContractDataSet.ContractDataTable();
        private ContractTableAdapter contractTableAdapter = new ContractTableAdapter();

        private DataConcentratorUnitDataSet.DataConcentratorUnitDataTable dataConcentratorUnitDataTable = new DataConcentratorUnitDataSet.DataConcentratorUnitDataTable();
        private DataConcentratorUnitTableAdapter dataConcentratorUnitTableAdapter = new DataConcentratorUnitTableAdapter();

        private MeterTypeAmiSysDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeAmiSysDataSet.MeterTypeDataTable();
        private MeterTypeAmiSysTableAdapter meterTypeAmiSysTableAdapter = new MeterTypeAmiSysTableAdapter();

        private MeasurementPointMeterDataSet.MeasurementPointMeterDataTable measurementPointMeterDataTable = new MeasurementPointMeterDataSet.MeasurementPointMeterDataTable();
        private MeasurementPointMeterTableAdapter measurementPointMeterTableAdapter = new MeasurementPointMeterTableAdapter();

        private StationDataSet.StationDataTable stationDataTable = new StationDataSet.StationDataTable();

        private MeasurementPointTransaction measurementPointTransaction = new MeasurementPointTransaction();

        public UpdateMeasurementPointMeter(long measurementPointId, long measurementPointMeterId)
        {
            InitializeComponent();

            this.measurementPointMeterId = measurementPointMeterId;
            this.measurementPointId = measurementPointId;
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

                cboDcuCode.SelectedValue = this.measurementPointDataTable.First().IsDcuIdNull() ? -1 : this.measurementPointDataTable.First().DcuId;              
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
            if (this.measurementPointMeterId == -1)
                return;

            try
            {
                this.measurementPointMeterTableAdapter.FillByMeasurementPointMeterId(this.measurementPointMeterDataTable, this.measurementPointMeterId);

                if (this.measurementPointMeterDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Công tơ không còn tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                cboCustomerCode.SelectedValue = this.measurementPointMeterDataTable.First().IsCustomerIdNull() ? -1 : this.measurementPointMeterDataTable.First().CustomerId;
                cboMeterCode.SelectedValue = this.measurementPointMeterDataTable.First().MeterId;
                cboStation.SelectedValue = this.measurementPointMeterDataTable.First().IsStationIdNull() ? -1 : this.measurementPointMeterDataTable.First().StationId;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeasurementPointMeter.LoadMeasurementPointMeter - Lỗi load dữ liệu công tơ this.measurementPointMeterTableAdapter.FillByMeasurementPointMeterId(this.measurementPointMeterDataTable, this.measurementPointMeterId). Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi tải dữ liệu điểm đo từ cơ sở dữ liệu. Chi tiết xem logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadMeter - Tải dữ liệu cho LoadMeter không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin trạm từ cơ sở dữ liệu. Chi tiết lỗi kiểm tra logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMeter()
        {
            try
            {
                // Nếu điểm đo mới chưa gắn đồng hồ                                
                meterTableAdapter.Fill(meterDataTable);

                var newRow = this.meterDataTable.NewMeterRow();
                newRow.Id = -1;
                newRow.MeterId = Constant.SelectText;
                newRow.Serial = Constant.SelectText;
                newRow.MeterTypeId = -1;
                newRow.Status = -1;
                newRow.IsDeleted = false;
                newRow.HisType = -1;
                this.meterDataTable.Rows.InsertAt(newRow, 0);

                cboMeterCode.DataSource = meterDataTable;
                cboMeterCode.DisplayMember = meterDataTable.MeterIdColumn.ColumnName;
                cboMeterCode.ValueMember = meterDataTable.IdColumn.ColumnName;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadMeter - Tải dữ liệu cho LoadMeter không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin Công tơ từ cơ sở dữ liệu. Chi tiết lỗi kiểm tra logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomer()
        {
            try
            {
                this.customerTableAdapter.Fill(this.customerDataTable);

                var newRow = this.customerDataTable.NewCustomerRow();
                newRow.Id = -1;
                newRow.CustomerId = Constant.SELECT_ALL_TEXT;
                newRow.Name = Constant.SELECT_ALL_TEXT;
                newRow.IsDeleted = false;
                this.customerDataTable.Rows.InsertAt(newRow, 0);

                cboCustomerCode.DataSource = this.customerDataTable;
                cboCustomerCode.DisplayMember = this.customerDataTable.CustomerIdColumn.ColumnName;
                cboCustomerCode.ValueMember = this.customerDataTable.IdColumn.ColumnName;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadCustomer - Tải dữ liệu cho LoadCustomer không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin Khách hàng từ cơ sở dữ liệu. Chi tiết lỗi kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadContract()
        {
            try
            {
                contractTableAdapter.Fill(contractDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadContract - Tải dữ liệu cho LoadContract không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin hợp đồng của điểm đo. Chi tiết kiểm tra logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cboContract.DataSource = this.contractDataTable;
            cboContract.DisplayMember = this.contractDataTable.NoteColumn.ColumnName;
            cboContract.ValueMember = this.contractDataTable.IdColumn.ColumnName;
        }

        private void LoadDcuCode()
        {
            try
            {
                //// Chưa có điểm đo mới được tạo
                //if (this.measurementPointMeterId == -1)
                //{
                //    dataConcentratorUnitTableAdapter.GetFreeDcu(dataConcentratorUnitDataTable);
                //}
                //else // Đã có điểm đo tự tạo
                //{
                dataConcentratorUnitTableAdapter.Fill(dataConcentratorUnitDataTable);
                //cboDcuCode.Enabled = false;
                //}
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "AddMeasurementPoint.LoadDcuCode - Tải dữ liệu cho LoadDcuCode không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin thiết bị. Chi tiết lỗi kiểm tra file logs", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newRow = this.dataConcentratorUnitDataTable.NewDataConcentratorUnitRow();
            newRow.Id = -1;
            newRow.DcuId = Constant.SELECT_ALL_TEXT;
            newRow.Status = -1;
            newRow.IsDeleted = false;
            this.dataConcentratorUnitDataTable.Rows.InsertAt(newRow, 0);

            cboDcuCode.DataSource = dataConcentratorUnitDataTable;
            cboDcuCode.DisplayMember = dataConcentratorUnitDataTable.DcuIdColumn.ColumnName;
            cboDcuCode.ValueMember = dataConcentratorUnitDataTable.IdColumn.ColumnName;
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
            cboTypeMeter.Enabled = false;
            cboTypeMeter.SelectedIndex = -1;
        }

        private void LoadMeasurementPointGroup()
        {
            try
            {
                this.measurementPointGroupDataTable = (MeasurementPointGroupDataSet.MeasurementPointGroupDataTable)UserSession.MeasurementPointGroupDataTable.Copy();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeasurementPointMeter.LoadMeasurementPointGroup - Tải dữ liệu cho LoadMeasurementPointGroup không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi lấy thông tin điện lực quản lý điểm đo. Chi tiết kiểm tra logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cboGroupMp.DataSource = this.measurementPointGroupDataTable;
            cboGroupMp.DisplayMember = this.measurementPointGroupDataTable.NameColumn.ColumnName;
            cboGroupMp.ValueMember = this.measurementPointGroupDataTable.IdColumn.ColumnName;
        }

        private void UpdateMeasurementPointMeter_Load(object sender, EventArgs e)
        {
            this.LoadCustomer();
            this.LoadMeter();
            this.LoadContract();
            this.LoadDcuCode();
            this.LoadMeterType();
            this.LoadStation();
            this.LoadMeasurementPointGroup();
            this.LoadMeasurementPoint();
            this.LoadMeasurementPointMeter();
        }

        private void btSaveMp_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void Save()
        {
            // Kiểm tra nếu modem và công tơ khác temp xem đã sử dụng ở đâu chưa? Nếu sử dụng rồi thì không cho thêm mới nữa
            MeasurementPointDataSet.MeasurementPointInfoDataTable measurementPointInfoDataTable = new MeasurementPointDataSet.MeasurementPointInfoDataTable();
            MeasurementPointInfoTableAdapter measurementPointInfoTableAdapter = new MeasurementPointInfoTableAdapter();

            if (cboDcuCode.SelectedIndex < 1)
            {
                MessageBox.Show("Điểm đo chưa có thông tin thiết bị.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDcuCode.Focus();
                return;
            }

            if (cboMeterCode.SelectedIndex < 1)
            {
                MessageBox.Show("Điểm đo chưa có thông tin công tơ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMeterCode.Focus();
                return;
            }

            try
            {
                // Check theo modem
                if (!cboDcuCode.Text.Equals(Constant.DcuTemp))
                {
                    measurementPointInfoTableAdapter.FillByDcuId(measurementPointInfoDataTable, int.Parse(cboDcuCode.SelectedValue.ToString()));
                    var query = measurementPointInfoDataTable.Where(r => r.MeasurementPointId != this.measurementPointId && !r.IsMeasurementPointTypeNull() && r.MeasurementPointType == 1);
                    if (query.Count() > 0)
                    {
                        MessageBox.Show("Không thể sử dụng mã thiết bị: " + cboDcuCode.Text + " do đã được sử dụng ở điểm đo: " + query.First().MeasurementPointCode + " ở trạng thái hoạt động. Bạn hãy chọn mã thiết bị khác hoặc chuyển trạng thái mã điểm đo đang sử dụng thiết bị này sang thanh lý.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboDcuCode.Focus();
                        return;
                    }
                }

                // Check theo meter
                if (!cboMeterCode.Text.Equals(Constant.MeterTemp))
                {
                    measurementPointInfoTableAdapter.FillByMeterId(measurementPointInfoDataTable, int.Parse(cboMeterCode.SelectedValue.ToString()));

                    // Điểm đo phải ở trạng thái không hoạt động Type !=1 mới được sử dụng
                    var query = measurementPointInfoDataTable.Where(r => r.MeasurementPointId != this.measurementPointId && !r.IsMeasurementPointTypeNull() && r.MeasurementPointType == 1);
                    if (query.Count() > 0)
                    {
                        MessageBox.Show("Không thể sử dụng mã công tơ: " + cboMeterCode.Text + " do đã được sử dụng ở điểm đo: " + query.First().MeasurementPointCode + " ở trạng thái hoạt động. Bạn hãy chọn mã công tơ khác hoặc chuyển trạng thái điểm đo đang sử dụng sang thanh lý.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboMeterCode.Focus();
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, " Kiểm tra điều kiện trước khi cập nhật công tơ. Chi tiết lỗi: ", ex);
                MessageBox.Show("Cập nhật không thành công. Xảy ra lỗi trong quá trình xử lý. Chi tiết xem file lgos", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.measurementPointDataTable.First().DcuId = long.Parse(cboDcuCode.SelectedValue.ToString());
            this.measurementPointDataTable.First().EditedDate = DateTime.Now;
            this.measurementPointDataTable.First().EditedUserId = UserSession.UserName;

            // Cập nhật DCU cho điểm đo trong trường hợp tạo mới mpmId
            if (this.measurementPointMeterId == -1)
            {
                // Thêm mới mpm cho mp
                var newRows = this.measurementPointMeterDataTable.NewMeasurementPointMeterRow();

                newRows.MeasurementPointId = this.measurementPointId;
                if (cboCustomerCode.SelectedIndex > 0)
                    newRows.CustomerId = int.Parse(cboCustomerCode.SelectedValue.ToString());
                newRows.MeterId = int.Parse(cboMeterCode.SelectedValue.ToString());
                if (cboStation.SelectedIndex > 0)
                    newRows.StationId = int.Parse(cboStation.SelectedValue.ToString());
                newRows.Status = Constant.Active;
                newRows.StartDate = DateTime.Now;
                newRows.ConnectionStatus = Constant.Active;
                newRows.IsTotalMeter = false;
                newRows.IsDeleted = false;
                newRows.CreatedDate = DateTime.Now;
                newRows.CreatedUserId = UserSession.UserName;

                this.measurementPointMeterDataTable.AddMeasurementPointMeterRow(newRows);
            }
            else // Cập nhật lại khách hàng cho điểm đo
            {
                if (cboCustomerCode.SelectedIndex > 0)
                    this.measurementPointMeterDataTable.First().CustomerId = int.Parse(cboCustomerCode.SelectedValue.ToString());
                else
                    this.measurementPointMeterDataTable.First().SetCustomerIdNull();

                if (cboStation.SelectedIndex > 0)
                    this.measurementPointMeterDataTable.First().StationId = int.Parse(cboStation.SelectedValue.ToString());
                else
                    this.measurementPointMeterDataTable.First().SetStationIdNull();

                this.measurementPointMeterDataTable.First().MeterId = int.Parse(cboMeterCode.SelectedValue.ToString());

                this.measurementPointMeterDataTable.First().EditedDate = DateTime.Now;
                this.measurementPointMeterDataTable.First().EditedUserId = UserSession.UserName;
            }
            try
            {
                this.measurementPointTransaction.AddMeasurementPoint(measurementPointDataTable, measurementPointMeterDataTable, measurementPointTableAdapter, measurementPointMeterTableAdapter);


                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_MeasurementPointList);
                UserSession.Action = SystemResource.User_Action_Update;
                UserSession.Notes = "Cập nhật thông tin điểm đo: "
                    + txtMpCode.Text
                    + "\nTên điểm đo: " + txtMpName.Text
                    + "\nĐiện lực: " + cboGroupMp.Text
                    + "\nHợp đồng: " + cboContract.Text
                    + "\nMã thiết bị: " + cboDcuCode.Text
                    + "\nMã công tơ: " + cboMeterCode.Text
                    + "\nTrạm điện: " + cboStation.Text
                    + "\nKhách hàng: " + cboCustomerCode.Text
                    + "\nĐịa chỉ: " + txtCustomerAdrress.Text
                    ;

                this.controlBase.InsertHistories();

                MessageBox.Show("Cập nhật điểm đo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UpdateMeasurementPointMeter.Save - Lưu thông tin đồng hồ cho điểm đo không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Lưu thông tin đồng hồ cho điểm đo không thành công. Chi tiết kiểm tra logs", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCacelMp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMeterCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTypeMeter.SelectedIndex = -1;
            if (cboMeterCode.SelectedIndex > 0)
            {
                cboTypeMeter.SelectedValue = meterDataTable.FindById(int.Parse(cboMeterCode.SelectedValue.ToString())).MeterTypeId;
            }
        }

        private void cboCustomerCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerAdrress.Text = string.Empty;
            if (cboCustomerCode.SelectedIndex > 0)
            {
                var query = customerDataTable.FindById(int.Parse(cboCustomerCode.SelectedValue.ToString()));

                txtCustomerAdrress.AppendText(query.Name);
                txtCustomerAdrress.AppendText("\n");
                txtCustomerAdrress.AppendText("Địa chỉ: ");
                txtCustomerAdrress.AppendText(query.IsAddressNull() ? string.Empty : query.Address);
            }
        }

        private void UpdateMeasurementPointMeter_FormClosing(object sender, FormClosingEventArgs e)
        {
            MemoryManagement.MinimizeMemory();
        }
    }
}
