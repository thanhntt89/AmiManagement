using System;
using System.Drawing;
using System.Windows.Forms;

namespace ErrorManagement
{
    public partial class UCReporting : UserControl
    {
        public UCReporting()
        {
            InitializeComponent();
            this.dtToDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 0, 0);
        }

        private void UCReporting_Load(object sender, EventArgs e)
        {
            try
            {
                this.getOrgTableAdapter.Fill(this.amiReportDataSet.GetOrg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.getReportingTableAdapter.FillByCondition(this.amiReportDataSet.GetReporting, dtToDate.Value, cboOrg.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgReport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
