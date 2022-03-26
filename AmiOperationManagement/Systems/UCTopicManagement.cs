using System;
using System.Drawing;
using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.CommandLineDataSetTableAdapters;

namespace AmiOperationManagement.Systems
{
    public partial class UCTopicManagement : UserControlBase
    {
        private CommandLineDataSet.CommandLineDataTable commandLineDataTable = new CommandLineDataSet.CommandLineDataTable();
        private CommandLineTableAdapter commandLineTableAdapter = new CommandLineTableAdapter();

        public UCTopicManagement()
        {
            InitializeComponent();
        }

        public void LoadTopics()
        {
            try
            {
                this.commandLineTableAdapter.Fill(this.commandLineDataTable);
                this.dtGridTopicInfor.DataSource = this.commandLineDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCTopicManagement_Load(object sender, EventArgs e)
        {
            this.LoadTopics();
        }

        private void Save()
        {
            var rst = MessageBox.Show("Bạn có muốn lưu những thông tin này lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rst != DialogResult.Yes)
                return;
            try
            {
                this.dtGridTopicInfor.EndEdit();
                this.commandLineTableAdapter.Update(this.commandLineDataTable);
                this.LoadTopics();
                MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Lưu dữ liệu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSaveTopic_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnObisDefine_Click(object sender, EventArgs e)
        {
            ObisDefine obisDefine = new ObisDefine();
            obisDefine.ShowDialog();
        }

        private void dtGridTopicInfor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
