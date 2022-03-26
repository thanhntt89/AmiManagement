using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AmiOperationLib;
using OperationDTO.AmiSystemDataSet;
using OperationDTO.AmiSystemDataSet.OrganizationDataSetTableAdapters;

namespace AmiOperationManagement.CustomeUserControl
{
    public partial class UCEvnTreeView : UserControl
    {
        public event EvnTreeViewNodeSeletedHandle EvnTreeViewNodeSeletedEvent;
        private OrganizationDataSet.OrganizationDataTable organizationDataTable = new OrganizationDataSet.OrganizationDataTable();
        private OrganizationTableAdapter organizationTableAdapter = new OrganizationTableAdapter();

        public UCEvnTreeView()
        {
            InitializeComponent();
        }

        public void LoadOrg()
        {
            try
            {
                organizationTableAdapter.Fill(organizationDataTable);

                tvMeasurementPointGroup.Nodes.Clear();

                NodeCustom rootNode = new NodeCustom("EVN-VIETNAM");
                rootNode.ImageIndex = 0;
                rootNode.NodeType = Constant.NodeTypeRoot;
                tvMeasurementPointGroup.Nodes.Add(rootNode);

                foreach (OrganizationDataSet.OrganizationRow item in organizationDataTable.Rows)
                {
                    // Root
                    if (item.IsParentIdNull())
                        continue;

                    // ParentNode
                    if (item.ParentId == 1)
                    {
                        var nodeParent = new NodeCustom(item.Name.ToUpper());
                        nodeParent.NodeType = Constant.NodeTypeOrg;
                        nodeParent.NodeId = item.Id;
                        nodeParent.ImageIndex = 1;
                        nodeParent.Expanded = false;

                        // ChildNode
                        var queryChildNode = organizationDataTable.Where(r => !r.IsParentIdNull() && r.ParentId == item.Id);
                        if (queryChildNode.Count() > 0)
                        {
                            var childNode = new NodeCustom(Constant.NodeTypeOrg);
                            childNode.NodeType = Constant.NodeTypeOrg;
                            nodeParent.Nodes.Add(childNode);
                        }
                        else
                        {
                            // Kiểm tra nếu có MpGroup thì cho vào
                            // Load mp group for each childNode
                            var queryMpgroup = UserSession.MeasurementPointGroupDataTable.Where(r => r.OrgId == item.Id);
                            if (queryMpgroup.Count() > 0)
                            {
                                var mpgroupNode = new NodeCustom(Constant.NodeTypeMpGroup);
                                mpgroupNode.NodeType = Constant.NodeTypeMpGroup;
                                nodeParent.Nodes.Add(mpgroupNode);
                            }
                        }

                        tvMeasurementPointGroup.Nodes[0].Nodes.Add(nodeParent);
                    }
                }

                tvMeasurementPointGroup.Nodes[0].Expand();

            }
            catch (Exception ex)
            {
                Logger.WriteLog(LogLevelL4N.ERROR, "UCEvnTreeView.LoadOrg - Tải dữ liệu điện lực không thành công. Chi tiết lỗi: ", ex);
                MessageBox.Show("Tải dữ liệu điện lực không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tvMeasurementPointGroup_AfterExpand(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            NodeCustom nodeExpand = (NodeCustom)e.Node;
            if (nodeExpand.NodeType == Constant.NodeTypeRoot)
                return;
            if (!nodeExpand.IsExpanded)
            {
                this.LoadOrgChild(nodeExpand);
                this.LoadMeasurementPointGroup(nodeExpand);
            }
        }

        private void LoadOrgChild(NodeCustom orgNode)
        {
            orgNode.Nodes.Clear();
            // ChildNode
            var queryChildNode = organizationDataTable.Where(r => !r.IsParentIdNull() && r.ParentId == orgNode.NodeId);
            foreach (var child in queryChildNode)
            {
                var childNode = new NodeCustom(child.Name.ToUpper());
                childNode.NodeType = Constant.NodeTypeOrg;
                childNode.Expanded = false;
                childNode.NodeId = child.Id;
                childNode.ImageIndex = 2;

                // Load mp group for each childNode
                var queryMpgroup = UserSession.MeasurementPointGroupDataTable.Where(r => r.OrgId == orgNode.NodeId);
                if (queryMpgroup.Count() > 0)
                {
                    var mpgroupNode = new NodeCustom(Constant.NodeTypeMpGroup);
                    mpgroupNode.NodeType = Constant.NodeTypeMpGroup;
                    childNode.Nodes.Add(mpgroupNode);
                }
                orgNode.Nodes.Add(childNode);
            }
        }

        private void LoadMeasurementPointGroup(NodeCustom orgNode)
        {
            var queryMpGroup = UserSession.MeasurementPointGroupDataTable.Where(r => r.OrgId == orgNode.NodeId);
            foreach (var item in queryMpGroup)
            {
                var mpgroupNode = new NodeCustom(item.Name.ToUpper());
                mpgroupNode.NodeType = Constant.NodeTypeMpGroup;
                mpgroupNode.NodeId = item.Id;
                mpgroupNode.ImageIndex = 3;
                orgNode.Nodes.Add(mpgroupNode);
            }
        }

        private void UCEvnTreeView_Load(object sender, EventArgs e)
        {
            LoadOrg();
        }

        private void tvMeasurementPointGroup_AfterNodeSelect(object sender, DevComponents.AdvTree.AdvTreeNodeEventArgs e)
        {
            NodeCustom nodeSelected = (NodeCustom)e.Node;
            if (this.EvnTreeViewNodeSeletedEvent != null)
                this.EvnTreeViewNodeSeletedEvent(nodeSelected);
        }
    }
}
