using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.CustomerDataSetTableAdapters;
using AmiOperationManagement.Main;
using System.ComponentModel;
using OperationDTO.AmiSystemDataSet.MeasurementPointDataSetTableAdapters;
using AmiOperationManagement.Resources;
using AmiOperationLib;

namespace AmiOperationManagement.Deployment
{
    public partial class UCCustomerManagement : UserControlBase
    {
        private CustomerDataSet.CustomerDataTable customerDataTable = new CustomerDataSet.CustomerDataTable();
        private CustomerTableAdapter customerTableAdapter = new CustomerTableAdapter();
        private Waitting waitting;
        private BackgroundWorker bgwWaiting;
        private int pageNume = 0;
        private int numRow = 0;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.btnsearchCustomer_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public UCCustomerManagement()
        {
            InitializeComponent();
            //dtCreateFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dtCreateTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            ucBreakPage.NextPageEvent += ucBreakPage_NextPageEvent;
        }

        private void DisplayData()
        {
            Invoke(new Action(() =>
            {
                dtgSearchCustomer.Rows.Clear();
                int rowIndex = 0;
                int index = this.pageNume * this.numRow + 1;
                for (int i = 0; i < this.customerDataTable.Rows.Count; i++)
                {
                    if (i + 1 > this.numRow || index > this.customerDataTable.Rows.Count)
                        break;
                    var item = this.customerDataTable[index - 1];
                    try
                    {
                        dtgSearchCustomer.Rows.Add(item.CustomerId, item.Name, item.IsAddressNull() ? string.Empty : item.Address, item.IsMobileNull() ? string.Empty : item.Mobile, item.IsCreatedDateNull() ? string.Empty : item.CreatedDate.ToString("dd/MM/yyyy"), item.IsDeleted ? Constant.DeletedText : Constant.ActiveText, null, null, item.Id);

                        dtgSearchCustomer.Rows[rowIndex].Cells[clIsDeleted.Index].Style.ForeColor = item.IsDeleted ? Color.Red : Color.Green;
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi hiển thị thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    index++;
                    rowIndex++;
                }
            }));
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

        void bgwWaiting_DoWork(object sender, DoWorkEventArgs e)
        {
            DisplayData();
        }

        void bgwWaiting_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgwWaiting.Dispose();
            bgwWaiting = null;
            waitting.CloseWaiting();
            waitting.Dispose();
            waitting = null;
        }           

        private void btnsearchCustomer_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        private void Search()
        {
            dtgSearchCustomer.Rows.Clear();
            string dtFrom = null;
            string dtTo = null;
            bool? IsDeleted = null;

            if (dtCreateFrom.Value != DateTime.MinValue)
                dtFrom = dtCreateFrom.Value.ToString();
            if (dtCreateTo.Value != DateTime.MinValue)
                dtTo = dtCreateTo.Value.ToString();

            if (dtCreateFrom.Value > dtCreateTo.Value)
            {
                MessageBox.Show("Thời gian bắt đầu không được lớn hơn thời gian kết thúc", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboStatus.SelectedIndex == 1)
                IsDeleted = false;
            else if (cboStatus.SelectedIndex == 2)
                IsDeleted = true;

            try
            {
                this.customerTableAdapter.FillByCondition(this.customerDataTable, IsDeleted, txtCustomerCode.Text, txtCustomerName.Text, dtFrom, dtTo);
                ucBreakPage.CreatePage(this.customerDataTable.Rows.Count);
            }
            catch
            {
                MessageBox.Show("Lỗi tìm thông tin khách hàng từ cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dtgSearchCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == clEdit.Index)
                this.EditCustomer();
            else if (e.ColumnIndex == clDelete.Index)
                this.DeletedCustomer();
        }

        private void DeletedCustomer()
        {
            string customerCode = dtgSearchCustomer.Rows[dtgSearchCustomer.CurrentRow.Index].Cells[clCustomerId.Index].Value.ToString();

            try
            {
                long customerId = long.Parse(dtgSearchCustomer.Rows[dtgSearchCustomer.CurrentRow.Index].Cells[clId.Index].Value.ToString());

                var rst = MessageBox.Show("Bạn có muốn xoá khách hàng " + customerCode, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rst != System.Windows.Forms.DialogResult.Yes)
                    return;

                // Kiểm tra xem điểm đo gắn với khách hàng có tồn tại không
                // Nếu tồn tại điểm đo gắn với khách hàng đang hoạt động thì không cho xoá khách hàng
                // Nếu điểm đo gắn với khách hàng ở trạng thái xoá, chuyển trạng thái xoá cho khách hàng
                try
                {
                    MeasurementPointDataSet.MeasurementPointInfoDataTable masurementPointInfoDataTable = new MeasurementPointDataSet.MeasurementPointInfoDataTable();
                    MeasurementPointInfoTableAdapter measurementPointInfoTableAdapter = new MeasurementPointInfoTableAdapter();

                    measurementPointInfoTableAdapter.FillByCustomerId(masurementPointInfoDataTable, customerId);

                    // Khách hàng đang được gắn vào điểm đo
                    if (masurementPointInfoDataTable.Rows.Count > 0)
                    {
                        string measurementPointCode = masurementPointInfoDataTable.First().MeasurementPointCode;

                        // Nếu điểm đo không ở trạng thái xoá thì không cho phép chuyển trạng thái khách hàng sang xoá 
                        if (!masurementPointInfoDataTable.First().IsDeleted)
                        {
                            MessageBox.Show("Không thể chuyển trạng thái xoá ở khách hàng này. Mã khách hàng: " + customerCode + " đang được liên kết với điểm đo " + measurementPointCode + " ở trạng thái hoạt động. ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Chuyển trạng thái khách hàng sang xoá
                        else
                        {
                            this.customerTableAdapter.FillById(this.customerDataTable, customerId);
                            if (this.customerDataTable.Rows.Count > 0)
                            {
                                this.customerDataTable.First().IsDeleted = true;
                                this.customerDataTable.First().EditedDate = DateTime.Now;
                                this.customerDataTable.First().CreatedUserId = UserSession.UserName;

                                this.customerTableAdapter.Update(this.customerDataTable);

                                // Log người dùng
                                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CustomerList);
                                UserSession.Action = SystemResource.User_Action_Update;
                                UserSession.Notes = "Chuyển trạng thái khách hàng mã: " + customerCode + " sang Xoá";

                                this.InsertHistories();

                                MessageBox.Show("Khách hàng có mã: " + customerCode + " được chuyển sang trạng thái thái xoá, do liên kết với điểm đo " + measurementPointCode + " ở trạng thái xoá. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Khách hàng không còn tồn tại trong cơ sở dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.Search();
                            return;
                        }
                    }

                }
                catch
                {
                    return;
                }

                // Xoá khách hàng khỏi cở dữ liệu

                this.customerTableAdapter.FillById(this.customerDataTable, customerId);
                if (this.customerDataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Khách hàng không còn tồn tại trong cơ sở dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Search();
                    return;
                }

                int indexDelete = 0;

                foreach (CustomerDataSet.CustomerRow item in this.customerDataTable.Rows)
                {
                    this.customerDataTable[indexDelete].Delete();
                }

                this.customerTableAdapter.Update(this.customerDataTable);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_CustomerList);
                UserSession.Action = SystemResource.User_Action_Delete;
                UserSession.Notes = "Xoá khách hàng mã: " + customerCode;

                this.InsertHistories();

                MessageBox.Show("Xoá khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Search();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCCustomerManagement.DeletedCustomer - Xoá thông tin khách hàng: " + customerCode + " lỗi. Chi tiết lỗi: ", ex);
                MessageBox.Show("Không thể xoá khách hàng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditCustomer()
        {
            if (dtgSearchCustomer.Rows.Count == 0)
                return;
            string customerId = dtgSearchCustomer.Rows[dtgSearchCustomer.CurrentRow.Index].Cells[clCustomerId.Index].Value.ToString();
            var item = customerDataTable.Where(r => r.CustomerId.Equals(customerId));
            this.UpdateCustomer(item.First());
        }

        private void UpdateCustomer(CustomerDataSet.CustomerRow customerRow)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer(customerRow);
            updateCustomer.ShowDialog();
        }

        private void dtgSearchCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditCustomer();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void dtgSearchCustomer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerCode.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            cboStatus.SelectedIndex = 0;
            dtCreateFrom.Value = DateTime.MinValue;
            dtCreateTo.Value = DateTime.MinValue;
            dtgSearchCustomer.Rows.Clear();
            customerDataTable.Rows.Clear();
            MemoryManagement.MinimizeMemory();
        }
    }
}
