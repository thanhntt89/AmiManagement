using System.Windows.Forms;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ServerDataSetTableAdapters;
using System.Drawing;
using AmiOperationManagement.Resources;

namespace AmiOperationManagement.Systems
{
    public partial class UCServerList : UserControlBase
    {
        private ServerDataSet.ServerDataTable serverDataTable = new ServerDataSet.ServerDataTable();
        private ServerTableAdapter serverTableAdapter = new ServerTableAdapter();
        public UCServerList()
        {
            InitializeComponent();
            this.Display();
        }

        private void Display()
        {
            dtgServer.Rows.Clear();
            try
            {
                serverTableAdapter.Fill(serverDataTable);
                foreach (ServerDataSet.ServerRow item in serverDataTable.Rows)
                {
                    dtgServer.Rows.Add(item.ServerId, item.ServerName, item.ServerIP, item.Port, item.UserName, item.Password, item.Type);
                }
            }
            catch
            {
                MessageBox.Show("Không lấy được thông tin từ cơ sở dữ liệu. Thử lại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletedServer()
        {
            int idServer = int.Parse(dtgServer.Rows[dtgServer.CurrentRow.Index].Cells[clServerId.Index].Value.ToString());
            try
            {
                var rst = MessageBox.Show("Bạn có muốn xoá địa chỉ " + dtgServer.Rows[dtgServer.CurrentRow.Index].Cells[clServerIp.Index].Value.ToString(), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rst != System.Windows.Forms.DialogResult.Yes)
                    return;
                serverTableAdapter.DeleteById(idServer);

                // Log người dùng
                UserSession.CurrentFunction = UserSession.UserFunctionList.GetFunctionName(SystemResource.UserFunction_Server);
                UserSession.Action = SystemResource.User_Action_Delete;
                UserSession.Notes = "Xoá thông tin server: " + dtgServer.Rows[dtgServer.CurrentRow.Index].Cells[clServerIp.Index].Value.ToString();

                this.InsertHistories();

                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Không thể xoá địa chỉ IP này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditServer()
        {
            int idServer = int.Parse(dtgServer.Rows[dtgServer.CurrentRow.Index].Cells[clServerId.Index].Value.ToString());
            this.DisplayUpdateServer(idServer);
        }

        private void DisplayUpdateServer(int idServer)
        {
            UpdateServer updateServer = new UpdateServer(idServer);
            updateServer.ShowDialog();
        }

        private void dtgServer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.ColumnIndex == clEdit.Index)
                this.EditServer();
            else if (e.ColumnIndex == clDeleteServer.Index)
                this.DeletedServer();
        }

        private void btnCreateNew_Click(object sender, System.EventArgs e)
        {
            DisplayUpdateServer(-1);
        }

        private void dtgServer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
