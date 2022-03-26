using System;
using System.Drawing;
using System.Windows.Forms;
using AmiOperationLib;

namespace ErrorManagement
{
    public partial class UCGetErrorDcu : UserControl
    {
        private ClientConnection errorMana;
        private GatewayInfo gatewaysInfo;
        public UCGetErrorDcu()
        {
            InitializeComponent();

        }
        public void ReceiveMessageEvent(ClientConnection errormanagement)
        {
            //this.errorMana = errormanagement;
            //errorMana.receiveMessageEventFlashFail += errorMana_receiveMessageEventFlashFail;
        }
        private void errorMana_receiveMessageEventFlashFail(string[] topic, byte[] message)
        {
            try
            {
                MethodInvoker methodInvokerDelegate = delegate()
                {
                    string flashFail = null, firmwareFail = null, otherFail = null, waDcu = null, wrongPending = null;
                    string metertype = topic[2];
                    string dcuCode = null;
                    dcuCode = topic[4];
                    if (topic[3].Equals("TEST1"))
                    {
                        byte[] data = message;
                        if (data[2] > 0)
                            wrongPending = "Lỗi";
                        if (data[1] != 0) flashFail = "Lỗi";
                        else if (data[1] > 1) firmwareFail = "Lỗi";
                        if (data[4] > data[3]) otherFail = "Lỗi";

                        for (int i = 0; i < dtErrorDcuFlash.Rows.Count - 1; i++)
                        {
                            try
                            {
                                if (dcuCode.Equals(dtErrorDcuFlash.Rows[i].Cells[0].Value.ToString()))
                                    return;
                            }
                            catch { return; }
                        }
                    }
                    if (topic[3].Equals("WaDcu"))
                    {
                        waDcu = "WaDcu";
                        for (int i = 0; i < dtErrorDcuFlash.Rows.Count - 1; i++)
                        {
                            try
                            {
                                if (dcuCode.Equals(dtErrorDcuFlash.Rows[i].Cells[0].Value.ToString()) &&
                                    dtErrorDcuFlash.Rows[i].Cells[3].Value.ToString() != null &&
                                    waDcu.Equals(dtErrorDcuFlash.Rows[i].Cells[3].Value.ToString()))
                                    return;
                            }
                            catch { return; }
                        }
                    }
                    if ((flashFail != null) || (firmwareFail != null) || (otherFail != null) || (waDcu != null) || (wrongPending != null))
                        dtErrorDcuFlash.Rows.Add(dcuCode, metertype, flashFail, waDcu, otherFail, wrongPending);

                };
                if (this.InvokeRequired)
                    this.Invoke(methodInvokerDelegate);
                else
                    methodInvokerDelegate();
            }
            catch (Exception ex)
            {
                return;
            }

            MemoryManagement.MinimizeMemory();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchValue = tbSearch.Text;

            dtErrorDcuFlash.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dtErrorDcuFlash.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Không có giá trị nào");
            }
        }

        private void btCleanUC_Click(object sender, EventArgs e)
        {
            dtErrorDcuFlash.Rows.Clear();
        }

        private void dtErrorDcuFlash_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    string dcuId = Convert.ToString(dtErrorDcuFlash.Rows[e.RowIndex].Cells[0].Value);
                    string meterType = Convert.ToString(dtErrorDcuFlash.Rows[e.RowIndex].Cells[1].Value);
                    if (dtErrorDcuFlash.CurrentCell.ColumnIndex.Equals(6))
                    {
                        //this.errorMana.resetDcu(dcuId);

                        MessageBox.Show("Send OK", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dtErrorDcuFlash.CurrentCell.ColumnIndex.Equals(8))
                    {
                        //this.errorMana.updateFirmware(dcuId, meterType);

                        MessageBox.Show("Send OK", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (dtErrorDcuFlash.CurrentCell.ColumnIndex.Equals(7))
                    {
                        //this.errorMana.eraseFlash(dcuId);

                        MessageBox.Show("Send OK", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex) { }
        }

        private void dtErrorDcuFlash_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
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
            catch (Exception ex) { }
        }
    }
}
