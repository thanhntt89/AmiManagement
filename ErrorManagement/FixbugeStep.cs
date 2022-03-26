using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ErrorManagement
{
    public partial class FixbugeStep : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FixbugeStep()
        {
            InitializeComponent();
        }

        private void dtgFixStep_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void FixbugeStep_Load(object sender, System.EventArgs e)
        {
            try
            {
                this.fixGroupTableAdapter.Fill(this.amiReportDataSet.FixGroup);
                this.errorCodeTableAdapter.Fill(this.amiReportDataSet.ErrorCode);
                int selectIndex = int.Parse(cboForwardTo.SelectedValue.ToString());
                string errorCode = cboErrorCode.SelectedValue.ToString();
                this.fixStepTableAdapter.FillByGroupIdAndErrorCode(this.amiReportDataSet.FixStep,selectIndex, errorCode);               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboForwardTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectIndex = int.Parse(cboForwardTo.SelectedValue.ToString());
                string errorCode = cboErrorCode.SelectedValue.ToString();
                this.fixStepTableAdapter.FillByGroupIdAndErrorCode(this.amiReportDataSet.FixStep, selectIndex, errorCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dtgFixStep.Rows.Count - 1; i++)
                {
                    dtgFixStep.Rows[i].Cells[StepIndexColumn.Index].Value = i + 1;
                }
                this.fixStepBindingSource.EndEdit();
                this.fixStepTableAdapter.Update(this.amiReportDataSet.FixStep);

                MessageBox.Show("Save succsessful", "SUCCSESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgFixStep_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                dtgFixStep.Rows[e.Row.Index - 1].Cells[StepIndexColumn.Index].Value = e.Row.Index;
                dtgFixStep.Rows[e.Row.Index - 1].Cells[FixGroupIdColumn.Index].Value = cboForwardTo.SelectedValue;
                dtgFixStep.Rows[e.Row.Index - 1].Cells[ErrorCodeColumn.Index].Value = cboErrorCode.SelectedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void MoveUp()
        {
            try
            {
                if (currentIndex == 0 || currentIndex == dtgFixStep.Rows.Count)
                    return;

                object curretnIndex = dtgFixStep.Rows[currentIndex].Cells[StepIndexColumn.Index].Value;
                object curretnValue = dtgFixStep.Rows[currentIndex].Cells[FixStepNameColumn.Index].Value;

                object preIndex = dtgFixStep.Rows[currentIndex - 1].Cells[StepIndexColumn.Index].Value;
                object preValue = dtgFixStep.Rows[currentIndex - 1].Cells[FixStepNameColumn.Index].Value;

                dtgFixStep.Rows[currentIndex - 1].Cells[StepIndexColumn.Index].Value = curretnIndex;
                dtgFixStep.Rows[currentIndex - 1].Cells[FixStepNameColumn.Index].Value = curretnValue;

                dtgFixStep.Rows[currentIndex].Cells[StepIndexColumn.Index].Value = preIndex;
                dtgFixStep.Rows[currentIndex].Cells[FixStepNameColumn.Index].Value = preValue;

                dtgFixStep.ClearSelection();

                    dtgFixStep.Rows[currentIndex - 1].Selected = true;
                currentIndex = currentIndex - 1;
            }
            catch { }
        }

        private void MoveDown()
        {
            try
            {
                if (currentIndex + 1 >= dtgFixStep.Rows.Count - 1)
                    return;

                object curretnIndex = dtgFixStep.Rows[currentIndex].Cells[StepIndexColumn.Index].Value;
                object curretnValue = dtgFixStep.Rows[currentIndex].Cells[FixStepNameColumn.Index].Value;

                object preIndex = dtgFixStep.Rows[currentIndex + 1].Cells[StepIndexColumn.Index].Value;
                object preValue = dtgFixStep.Rows[currentIndex + 1].Cells[FixStepNameColumn.Index].Value;

                dtgFixStep.Rows[currentIndex + 1].Cells[StepIndexColumn.Index].Value = curretnIndex;
                dtgFixStep.Rows[currentIndex + 1].Cells[FixStepNameColumn.Index].Value = curretnValue;

                dtgFixStep.Rows[currentIndex].Cells[StepIndexColumn.Index].Value = preIndex;
                dtgFixStep.Rows[currentIndex].Cells[FixStepNameColumn.Index].Value = preValue;

                dtgFixStep.ClearSelection();

                dtgFixStep.Rows[currentIndex + 1].Selected = true;
                currentIndex = currentIndex + 1;              
            }
            catch { }
        }
        int currentIndex = -1;
        private void dtgFixStep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
        }

    }
}