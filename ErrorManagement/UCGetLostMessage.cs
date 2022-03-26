using System;
using System.Drawing;
using System.Windows.Forms;
using AmiOperationLib;

namespace ErrorManagement
{
    public partial class UCGetLostMessage : UserControl
    {
        private ClientConnection getlost;
        private GatewayInfo gatewaysInfo;
        public UCGetLostMessage()
        {
            InitializeComponent();
            gatewaysInfo = FileUtil.GetGatewayInfo();
            this.getlost = new ClientConnection();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btGetList_Click(object sender, EventArgs e)
        {
            //dtGetLost.Rows.Clear();
            //getlost.getListMessageLost(tbDcuName.Text, tbTimes.Text, dtGetLost);
            //if (dtGetLost.Rows.Count < 1)
            //    MessageBox.Show("Not Data Display", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            dtGetLost.Rows.Clear();
        }

        private void dtGetLost_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
