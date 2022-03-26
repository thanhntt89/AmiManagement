using System;
using System.Drawing;
using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.SystemConfigDataSetTableAdapters;
using AmiOperationManagement.Resources;
using System.Text;
using AmiOperationLib;

namespace AmiOperationManagement.Systems
{
    public partial class UCSystemConfig : UserControlBase
    {
        private SystemConfigDataSet.SystemConfigDataTable systemConfigDataTable = new SystemConfigDataSet.SystemConfigDataTable();
        private SystemConfigTableAdapter systemConfigTableAdapter = new SystemConfigTableAdapter();

        public UCSystemConfig()
        {
            InitializeComponent();
        }

        private void LoadConfigInfo()
        {
            try
            {
                this.systemConfigTableAdapter.Fill(this.systemConfigDataTable);
                this.dtgSystemInfo.DataSource = this.systemConfigDataTable;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCSystemConfig - LoadConfigInfo Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCSystemConfig_Load(object sender, EventArgs e)
        {
            this.LoadConfigInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.systemConfigTableAdapter.Update(this.systemConfigDataTable);
                
                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_SystemConfig);
                UserSession.Action = SystemResource.User_Action_Update;

                for (int i = 0; i < dtgSystemInfo.Rows.Count; i++)
                {
                    StringBuilder str = new StringBuilder();

                    str.Append("Thông số cấu hình: " + this.systemConfigDataTable[i].Notes + " - Giá trị: " + this.systemConfigDataTable[i].Value);
                    UserSession.Notes = str.ToString();
                    this.InsertHistories();
                }

                MessageBox.Show("Lưu thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadConfigInfo();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCSystemConfig - btnSave_Click Chi tiết lỗi: ", ex);
                MessageBox.Show("Lỗi: Không tải được dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgSystemInfo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
