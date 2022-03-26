using System.Windows.Forms;
using AmiOperationLib;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.MeterTypeDataSetTableAdapters;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UpdateMeterType : DevComponents.DotNetBar.Metro.MetroForm
    {
        public event OperationEventHandle ReloadDataEvent;

        private MeterTypeDataSet.MeterTypeRow meterTypeInfor;
        private MeterTypeTableAdapter meterTypeTableAdapter = new MeterTypeTableAdapter();
        public UpdateMeterType(MeterTypeDataSet.MeterTypeRow meterTypeInfor)
        {
            InitializeComponent();
            this.meterTypeInfor = meterTypeInfor;
        }

        private void UpdateMeterType_Load(object sender, System.EventArgs e)
        {
            if (meterTypeInfor != null)
            {
                txtSymbol.Text = meterTypeInfor.MeterCode.ToString();
                txtMeterType.Text = meterTypeInfor.MeterTypeName.ToString();
                txtNote.Text = meterTypeInfor.Note.ToString();
                this.Text = Constant.HeaderEdit;
            }
            else
                this.Text = Constant.HeaderCreateNew;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (this.Text == Constant.HeaderCreateNew)
                this.CreateNewMeterType();
            else if (this.Text == Constant.HeaderEdit)
                this.EditMeterTypeInfor();
            if (this.ReloadDataEvent != null)
                this.ReloadDataEvent();
        }
        
        private void EditMeterTypeInfor()
        {

            try
            {
                meterTypeTableAdapter.UpdateMeterTypeById(txtSymbol.Text, txtMeterType.Text, txtNote.Text, meterTypeInfor.MeterTypeId);
                MessageBox.Show("Sửa thông tin loại công tơ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Lỗi sửa thông tin loại công tơ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewMeterType()
        {
            try
            {

                meterTypeTableAdapter.InsertMeterType(txtSymbol.Text, txtMeterType.Text, txtNote.Text);
                MessageBox.Show("Tạo loại công tơ mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Lỗi tạo loại công tơ mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}