using OperationDTO;
using System.Windows.Forms;

namespace AmiOperationManagement.CustomeUserControl
{
    public partial class UserControlBase : UserControl
    {
        public string DisplayCode = string.Empty;

        public bool IsReceiveData;

        // Lớp xử lý lưu lịch sử hệ thống
        private SystemHistories systemHistories = new SystemHistories();

        // Hàm lưu lịch sử hệ thống
        public void InsertHistories()
        {
            SystemHistoriesEntity systemInfo = new SystemHistoriesEntity
            {
                UserName = UserSession.UserName,
                FunctionName = UserSession.CurrentFunction,
                Notes = UserSession.Notes,
                Action = UserSession.Action
            };

            try
            {
                this.systemHistories.InsertHistories(systemInfo);
            }
            catch { }
        }

        /// <summary>
        /// Close all COM is opened in form
        /// </summary>
        public virtual void RemoveCOMOpen()
        {
        }

        public virtual void FocusControl()
        {
        }
    }
}
