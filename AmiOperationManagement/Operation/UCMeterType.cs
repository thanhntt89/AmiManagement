using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.MeterTypeDataSetTableAdapters;
using System.Linq;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UCMeterType : UserControlBase
    {
        private MeterTypeDataSet.MeterTypeDataTable meterTypeDataTable = new MeterTypeDataSet.MeterTypeDataTable();
        private MeterTypeTableAdapter meterTypeTableAdapter = new MeterTypeTableAdapter();

        public UCMeterType()
        {
            InitializeComponent();
            this.Display();
        }

        private void Display()
        {
            dtgMeterType.Rows.Clear();
            int count = 0;
            try
            {
                meterTypeTableAdapter.Fill(meterTypeDataTable);
                foreach (MeterTypeDataSet.MeterTypeRow item in meterTypeDataTable.Rows)
                {
                    count++;
                    dtgMeterType.Rows.Add(count, item.MeterTypeId, item.MeterCode, item.Note);
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được thông tin từ cơ sở dữ liệu. Thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgMeterType_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == clEdit.Index)
                this.EditMeterType();
            else if (e.ColumnIndex == clDeleteMeterType.Index)
                this.DeletedMeterType();
        }

        private void DeletedMeterType()
        {
            try
            {
                int idMeterType = int.Parse(dtgMeterType.Rows[dtgMeterType.CurrentRow.Index].Cells[clMeterId.Index].Value.ToString());
                var rst = MessageBox.Show("Bạn có muốn xoá loại công tơ " + dtgMeterType.Rows[dtgMeterType.CurrentRow.Index].Cells[clMeterType.Index].Value.ToString(), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rst != System.Windows.Forms.DialogResult.Yes)
                    return;
                meterTypeTableAdapter.DeleteById(idMeterType);
                Display();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Không thể xoá loại công tơ này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditMeterType()
        {
            int idMeterType = -1;
            try
            {
                idMeterType = int.Parse(dtgMeterType.Rows[dtgMeterType.CurrentRow.Index].Cells[clMeterId.Index].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Không tìm được thông tin của loại Meter này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            var item = meterTypeDataTable.Where(r => r.MeterTypeId.Equals(idMeterType));
            this.DisplayUpdateMeterType(item.First());
        }

        private void DisplayUpdateMeterType(MeterTypeDataSet.MeterTypeRow meterTypeRow)
        {
            UpdateMeterType updateMeterType = new UpdateMeterType(meterTypeRow);
            updateMeterType.ReloadDataEvent += Display;
            updateMeterType.ShowDialog();
        }

        private void btnCreateNew_Click(object sender, System.EventArgs e)
        {
            DisplayUpdateMeterType(null);
        }
    }
}
