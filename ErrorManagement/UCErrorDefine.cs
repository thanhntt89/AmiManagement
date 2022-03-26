
using System;
using System.Drawing;
using System.Windows.Forms;
namespace ErrorManagement
{
    public partial class UCErrorDefine : DevComponents.DotNetBar.Metro.MetroForm
    {
        public UCErrorDefine()
        {
            InitializeComponent();
        }

        private void dtgErrorDefine_RowPostPaint(object sender, System.Windows.Forms.DataGridViewRowPostPaintEventArgs e)
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

        private void UCErrorDefine_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'amiReportDataSet.ErrorCode' table. You can move, or remove it, as needed.
            try
            {
                this.errorCodeTableAdapter.Fill(this.amiReportDataSet.ErrorCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                this.errorCodeBindingSource.EndEdit();
                this.errorCodeTableAdapter.Update(this.amiReportDataSet.ErrorCode);
                MessageBox.Show("Save succsessful", "SUCCSESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgErrorDefine_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error:" + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
