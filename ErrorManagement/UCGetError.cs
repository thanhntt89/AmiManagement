using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ErrorManagement.Entity;
using AmiOperationLib;

namespace ErrorManagement
{
    public partial class UCGetError : UserControl
    {
        private ClientConnection errorManagement;
        private GatewayInfo gatewaysInfo;
        private UCGetErrorDcu uCGetErrorDcu;
      
        public UCGetError(UCGetErrorDcu UCGetErrorDcu)
        {
            InitializeComponent();
            this.uCGetErrorDcu = UCGetErrorDcu;
            gatewaysInfo = FileUtil.GetGatewayInfo();
            this.lbGateway.Text = gatewaysInfo.BrokerAddress;
            this.errorManagement = new ClientConnection();
            this.dtErrorTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 08, 25, 0);
        }

        private void dtgErrorList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != SolutionColumn.Index)
                return;
            List<ErrorEntity> errorList = new List<ErrorEntity>();
            for (int i = 0; i < dtgErrorList.Rows.Count; i++)
            {
                errorList.Add(new ErrorEntity
                {
                    ErrorId = dtgErrorList.Rows[i].Cells[ErrorIdColumn.Index].Value.ToString(),
                    ErrorName = dtgErrorList.Rows[i].Cells[ErrorNameColumn.Index].Value.ToString(),
                    ErrorCode = dtgErrorList.Rows[i].Cells[ErrorCodeColumn.Index].Value.ToString(),
                    DcuCode = dtgErrorList.Rows[i].Cells[DcuCodeColumn.Index].Value.ToString()
                });
            }

            string currentErrorid = dtgErrorList.Rows[e.RowIndex].Cells[ErrorIdColumn.Index].Value.ToString();

            Solution solution = new Solution(errorManagement);
            solution.ReloadDataEvent += ReloadData;
            solution.errorList = errorList;
            solution.currentErrorId = currentErrorid;
            solution.ShowDialog();

        }

        private void errorManagement_ConnectStatusEvent(bool isConnected, string message)
        {
            try
            {
                MethodInvoker methodInvokerDelegate = delegate()
                {
                    btConnect.Enabled = !isConnected;
                    btDisconnect.Enabled = isConnected;
                    lbStatus.ForeColor = isConnected ? Color.Green : Color.Red;
                    lbStatus.Text = isConnected ? "Connected" : "Disconnect";
                };

                if (this.InvokeRequired)
                    this.Invoke(methodInvokerDelegate);
                else
                    methodInvokerDelegate();
            }
            catch { }
        }

        private void ReloadData()
        {
            btnGetError_Click(null, null);
        }

        private void btnGetError_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'amiReportDataSet.ErrorCode' table. You can move, or remove it, as needed.
            try
            {
                string dcuType = string.Empty;
                if (cboDcuType.SelectedValue != null)
                    dcuType = cboDcuType.SelectedValue.ToString();

                if (dtErrorTime.Value != DateTime.MinValue)
                    this.getErrorListTableAdapter.FillByCondition(this.amiReportDataSet.GetErrorList, chkFixed.Checked ? 1 : 0, dtErrorTime.Value, dcuType);
                else
                    this.getErrorListTableAdapter.FillByDcuTypeAndFixStatus(this.amiReportDataSet.GetErrorList, dcuType, chkFixed.Checked ? 1 : 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCGetError_Load(object sender, EventArgs e)
        {
            try
            {
                this.dcuTypeTableAdapter.Fill(this.amiReportDataSet.DcuType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgErrorList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Printing printing = new Printing();
            printing.ShowDialog();
        }

        private void PrintToExcel()
        {
 
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            errorManagement.ConnectStatusEvent += errorManagement_ConnectStatusEvent;
            errorManagement.Connect();
            //uCGetErrorDcu.ReceiveMessageEvent(errorManagement);
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            if (!btConnect.Enabled)
            {
                if (this.errorManagement != null)
                {
                    this.errorManagement.IsClientClosedByUser = true;
                    this.errorManagement.Disconnect();
                }
            }
        }

        internal void CloseMainForm()
        {
            if (this.errorManagement != null)
                this.errorManagement.ExistThreadDecode();
            if (this.errorManagement != null)
                this.errorManagement.Disconnect();
        }
    }
}
