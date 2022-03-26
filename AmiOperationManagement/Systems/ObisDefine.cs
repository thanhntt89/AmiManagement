using AmiOperationManagement.CustomeUserControl;
using AmiOperationManagement.Resources;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.CommandLineDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ObisTableDataSetTableAdapters;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmiOperationManagement.Systems
{
    public partial class ObisDefine : DevComponents.DotNetBar.Metro.MetroForm
    {
        private UserControlBase controlBase = new UserControlBase();

        private CommandLineDataSet.CommandLineDataTable commandLineDataTable = new CommandLineDataSet.CommandLineDataTable();
        private CommandLineTableAdapter commandLineTableAdapter = new CommandLineTableAdapter();

        private ObisTableDataSet.ObisTableDataTable obisTableDataTable = new ObisTableDataSet.ObisTableDataTable();
        private ObisTableTableAdapter obisTableTableAdapter = new ObisTableTableAdapter();

        public ObisDefine()
        {
            InitializeComponent();
        }

        private void LoadCommand()
        {
            try
            {
                this.commandLineTableAdapter.Fill(this.commandLineDataTable);

                cboCommandLine.DataSource = this.commandLineDataTable;
                cboCommandLine.ValueMember = this.commandLineDataTable.CommandIdColumn.ToString();
                cboCommandLine.DisplayMember = this.commandLineDataTable.CommandNameColumn.ToString();
                this.cboCommandLine.SelectedIndexChanged += new System.EventHandler(this.cboCommandLine_SelectedIndexChanged);
                cboCommandLine_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu từ máy chủ.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadObisByTopicId()
        {
            if (cboCommandLine.SelectedIndex < 0)
                return;

            try
            {
                int commmandId = int.Parse(cboCommandLine.SelectedValue.ToString());

                this.obisTableTableAdapter.FillByCommandId(this.obisTableDataTable, commmandId);

                lblTopics.Text = this.commandLineDataTable.FindByCommandId(commmandId).Topic;

                dtgObis.DataSource = this.obisTableDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu từ máy chủ.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ObisDefine_Load(object sender, EventArgs e)
        {
            LoadCommand();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }

        private void SaveInfo()
        {
            var rst = MessageBox.Show("Bạn có muốn lưu những thông số này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rst != System.Windows.Forms.DialogResult.Yes)
                return;

            try
            {
                this.dtgObis.EndEdit();
                for (int i = 0; i < this.obisTableDataTable.Rows.Count - 1; i++)
                {
                    this.obisTableDataTable[i].CommandId = int.Parse(cboCommandLine.SelectedValue.ToString());
                    this.obisTableDataTable[i].ObisIndex = i + 1;

                    this.obisTableDataTable[i].IsHex = (bool)dtgObis.Rows[i].Cells[IsHexCol.Index].Value;
                }
                this.obisTableTableAdapter.Update(this.obisTableDataTable);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SystemConfig);
                UserSession.Action = SystemResource.User_Action_Update;

                for (int i = 0; i < dtgObis.Rows.Count - 1; i++)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append("Cập nhật OBIS cho cho bản tin : " + cboCommandLine.Text);
                    str.Append(" - OBIS: " + dtgObis.Rows[i].Cells[ObisCodeCol.Index].Value.ToString() + " - Value: " + dtgObis.Rows[i].Cells[ValueCol.Index].Value.ToString());
                    UserSession.Notes = str.ToString();

                    this.controlBase.InsertHistories();
                }

                MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: Không tải được dữ liệu từ máy chủ.\n Chi tiết lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cboCommandLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadObisByTopicId();
        }

        private void dtgObis_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
