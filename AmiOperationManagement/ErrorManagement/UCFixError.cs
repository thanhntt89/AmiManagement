using AmiOperationLib;
using AmiOperationManagement.CustomeUserControl;
using OperationDTO.AmiOperationDataSet;
using OperationDTO.AmiOperationDataSet.ErrorCodeDataSetTableAdapters;
using OperationDTO.AmiOperationDataSet.ErrorListDataSetTableAdapters;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using DevComponents.AdvTree;

namespace AmiOperationManagement.ErrorManagement
{
    public partial class UCFixError : UserControlBase
    {
        private ErrorCodeDataSet.ErrorCodeDataTable errorCodeDataTable = new ErrorCodeDataSet.ErrorCodeDataTable();
        private ErrorCodeTableAdapter errorCodeTableAdapter = new ErrorCodeTableAdapter();

        private ErrorListDataSet.GetErrorListDataTable getErrorListDataTable = new ErrorListDataSet.GetErrorListDataTable();
        private GetErrorListTableAdapter getErrorListTableAdapter = new GetErrorListTableAdapter();

        public UCFixError()
        {
            InitializeComponent();
            tabControl.SelectedTabIndex = 0;
            dtErrorTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 59, 0);
        }

        private void DisplayErrorInfor(NodeCustom node)
        {
            if (node != null && node.ErrorId != 0)
            {
                this.ucErrorSolution.LoadErrorList(node.ErrorId);
                this.ucModemFixbugHistories.LoadHistorisInfo(node.ErrorId, node.ErrorCode, node.Text);
            }
        }

        private void LoadErrorDefine()
        {
            try
            {
                this.errorCodeTableAdapter.Fill(this.errorCodeDataTable);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCFixError - LoadErrorDefine. Chi tiết:", ex);
                MessageBox.Show("Không tải được dữ liệu hệ thống./nChi tiết lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadErrorSearch()
        {
            tvErrorList.Nodes.Clear();
            NodeCustom nodeCustom = new NodeCustom(Constant.ERROR_LIST_HEADER);
            nodeCustom.ImageExpandedIndex = 0;
            nodeCustom.ImageIndex = 0;
            nodeCustom.ExpandAll();
            nodeCustom.ExpandVisibility = eNodeExpandVisibility.Hidden;
            tvErrorList.Nodes.Add(nodeCustom);

            string dcuType = null;

            try
            {
                if (dtErrorTime.Value != DateTime.MinValue)
                    this.getErrorListTableAdapter.FillByCondition(this.getErrorListDataTable, chkFixed.Checked ? Constant.IsFixed : Constant.IsNotFixed, dtErrorTime.Value, dcuType, -1, null, null);
                else
                    this.getErrorListTableAdapter.FillByCondition(this.getErrorListDataTable, chkFixed.Checked ? Constant.IsFixed : Constant.IsNotFixed, null, dcuType, -1, null, null);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCFixError - LoadErrorSearch. Chi tiết:", ex);
                MessageBox.Show("Không tải được dữ liệu hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load error list 
            foreach (ErrorCodeDataSet.ErrorCodeRow row in this.errorCodeDataTable.Rows)
            {
                var query = this.getErrorListDataTable.Where(r => r.ErrorCode.Equals(row.ErrorCode));

                // Add node level 1
                nodeCustom = new NodeCustom(row.ErrorName + " (" + query.Count() + ")");
                nodeCustom.ImageExpandedIndex = 4;
                nodeCustom.ImageIndex = 3;
                tvErrorList.Nodes[0].Nodes.Add(nodeCustom);

                foreach (var item in query)
                {
                    NodeCustom node = new NodeCustom(item.DcuCode);
                    node.ErrorCode = item.ErrorCode;
                    node.ErrorId = item.ErrorId;
                    node.ImageIndex = chkFixed.Checked ? 2 : 1;
                    node.ImageExpandedIndex = chkFixed.Checked ? 2 : 1;
                    nodeCustom.Nodes.Add(node);
                }
            }
        }

        private void UCFixError_Load(object sender, System.EventArgs e)
        {
            this.LoadErrorDefine();
            btnGetError_Click(null, null);
        }

        private void btnGetError_Click(object sender, EventArgs e)
        {
            this.LoadErrorSearch();
        }

        private void tvErrorList_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            this.DisplayErrorInfor((NodeCustom)e.Node);
        }

    }
}
