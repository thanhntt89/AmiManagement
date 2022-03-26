using System;
using System.Windows.Forms;
using AmiOperationLib;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.DataByMeasurementPointDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using AmiOperationManagement.CustomeUserControl;
using System.Drawing;
using AmiOperationManagement.Main;
using System.ComponentModel;
using OperationDTO.AmiSystemDataSet.ContractDataSetTableAdapters;
using OperationDTO.AmiSystemDataSet.MeasurementPointGroupDataSetTableAdapters;

namespace AmiOperationManagement.Deployment
{
    public partial class SearchingMeasurementPoint : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private DataByMeasurementPointDataSet.MeasurementPointDataTableDataTable measurementPointDataTableDataTable = new DataByMeasurementPointDataSet.MeasurementPointDataTableDataTable();
        private DataMeasurementPointTableAdapter dataMeasurementPointTableAdapter = new DataMeasurementPointTableAdapter();
        private MeasurementPointDataSet.MeasurementPointDataTable measurementPointDataTable = new MeasurementPointDataSet.MeasurementPointDataTable();
        private MeasurementPointTableAdapter measurementPointTableAdapter = new MeasurementPointTableAdapter();

        private MeasurementPointDataSet.MeasurementPointInfoDataTable measurementPointInfoDataTable = new MeasurementPointDataSet.MeasurementPointInfoDataTable();
        private MeasurementPointInfoTableAdapter measurementPointInfoTableAdapter = new MeasurementPointInfoTableAdapter();

        private ContractDataSet.ContractDataTable contractDataTable = new ContractDataSet.ContractDataTable();
        private ContractTableAdapter contractTableAdapter = new ContractTableAdapter();

        private MeasurementPointGroupDataSet.MeasurementPointGroupDataTable measurementPointGroupDataTable = new MeasurementPointGroupDataSet.MeasurementPointGroupDataTable();
        private MeasurementPointGroupTableAdapter measurementPointGroupTableAdapter = new MeasurementPointGroupTableAdapter();

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

        public long measurementPointId = -1;
        public long measurementPointMeterId = -1;

        public bool isOk = false;

        private MeasurementPointEntity measurementPointSelected = new MeasurementPointEntity();

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
                this.measurementPointGroupTableAdapter.Fill(this.measurementPointGroupDataTable);
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

        public SearchingMeasurementPoint()
        {
            InitializeComponent();
            ucBreakPage.NextPageEvent += ucBreakPage_NextPageEvent;
            dtCreateFrom.Value = DateTime.MinValue;
            dtCreateTo.Value = DateTime.MinValue;
            //dtCreateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtCreateTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
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
                            item.MeasurementPointCode,
                            item.IsDcuCodeNull() ? string.Empty : item.DcuCode,
                            item.IsMeterCodeNull() ? string.Empty : item.MeterCode,
                             item.IsMeasurementPointNameNull() ? string.Empty : item.MeasurementPointName,
                            item.IsMeasurementPointAddressNull() ? string.Empty : item.MeasurementPointAddress, mpTypeText,
                            item.IsMeasurementPointGroupNameNull() ? string.Empty : item.MeasurementPointGroupName,
                            item.IsCreatedDateNull() ? string.Empty : item.CreatedDate.ToString("dd/MM/yyyy HH:mm:ss"),
                            item.IsDeleted ? Constant.DeletedText : Constant.ActiveText,
                            item.MeasurementPointId,
                            item.IsMeasurementPointMeterIdNull() ? -1 : item.MeasurementPointMeterId
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
            }));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
                btSearchMp_Click(null, null);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btCreateMp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSearchMp_Click(object sender, EventArgs e)
        {
            this.SearchMp();
        }

        private void SearchMp()
        {
            if (string.IsNullOrWhiteSpace(txtMpCode.Text))
            {
                MessageBox.Show("Bạn phải nhập thông tin điểm đo để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMpCode.Focus();
                return;
            }

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
            if (e.RowIndex == -1 || e.ColumnIndex != clChoose.Index)
                return;
            measurementPointId = long.Parse(dtgMeasurementpoint.Rows[e.RowIndex].Cells[clMpId.Index].Value.ToString());

            measurementPointMeterId = long.Parse(dtgMeasurementpoint.Rows[e.RowIndex].Cells[clMpmId.Index].Value.ToString());
            this.isOk = true;
            this.Close();
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
            this.SearchMp();
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
            // this.LoadGroup();
            //this.LoadContract();
            //btSearchMp_Click(null, null);
        }
    }
}
