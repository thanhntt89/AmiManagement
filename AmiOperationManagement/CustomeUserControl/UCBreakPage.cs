using AmiOperationLib;
using System;
using System.Windows.Forms;

namespace AmiOperationManagement.CustomeUserControl
{
    public partial class UCBreakPage : UserControl
    {
        public delegate void NextPageHandle(int pageNume, int numRow);
        public event NextPageHandle NextPageEvent;

        private int TotalRows { get; set; }
        private int NumberRowsPerPage = 0;
        private int selectIndex = 0;

        public UCBreakPage()
        {
            InitializeComponent();
            cboNumRowPerPage.SelectedIndex = 0;
        }

        private void UCBreakPage_SizeChanged(object sender, EventArgs e)
        {
            this.panel1.Left = (this.Width - this.panel1.Width) / 2;
            this.panel1.Top = (this.Height - this.panel1.Height) / 2;
        }

        public void CreatePage(int totalRows)
        {
            cboNumRowPerPage.Items.Clear();
            int MaxValue = 0;
            if (totalRows >= 1000)
            {
                cboNumRowPerPage.Items.Add(200);
                cboNumRowPerPage.Items.Add(300);
                cboNumRowPerPage.Items.Add(400);
                MaxValue = 400;
            }
            else
            {
                cboNumRowPerPage.Items.Add(Constant.SELECT_ALL_TEXT);
                cboNumRowPerPage.Items.Add(20);
                cboNumRowPerPage.Items.Add(50);
                cboNumRowPerPage.Items.Add(100);
                cboNumRowPerPage.Items.Add(200);
                MaxValue = 200;
            }

            this.TotalRows = totalRows;
            this.lblTotal.Text = totalRows.ToString();

            cboNumRowPerPage.SelectedIndex = this.TotalRows <= MaxValue ? 0 : cboNumRowPerPage.SelectedIndex = cboNumRowPerPage.FindString(MaxValue.ToString());
            CreatePage();
        }

        private void CreatePage()
        {
            selectIndex = 0;
            cboPages.Items.Clear();

            if (this.TotalRows == 0)
                return;

            if (this.TotalRows < 1000 && cboNumRowPerPage.SelectedIndex == 0)
                this.NumberRowsPerPage = this.TotalRows;
            else
                this.NumberRowsPerPage = int.Parse(cboNumRowPerPage.Items[cboNumRowPerPage.SelectedIndex].ToString());

            int totalPage = this.TotalRows % this.NumberRowsPerPage == 0 ? this.TotalRows / this.NumberRowsPerPage : this.TotalRows / NumberRowsPerPage + 1;
            for (int i = 0; i < totalPage; i++)
            {
                cboPages.Items.Add((i + 1) + " / " + totalPage);
            }

            cboPages.SelectedIndex = 0;
        }

        private void cboNumRowPerPage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CreatePage();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            selectIndex = 0;
            if (cboPages.Items.Count > 0)
                cboPages.SelectedIndex = selectIndex;
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            selectIndex--;
            if (selectIndex < 0)
                selectIndex = 0;
            if (cboPages.Items.Count > 0)
                cboPages.SelectedIndex = selectIndex;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            selectIndex++;
            if (cboPages.Items.Count > 0)
                cboPages.SelectedIndex = selectIndex > cboPages.Items.Count - 1 ? selectIndex = cboPages.Items.Count - 1 : selectIndex;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            selectIndex = cboPages.Items.Count - 1;
            if (cboPages.Items.Count > 0)
                cboPages.SelectedIndex = selectIndex;
        }

        private void cboPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NextPageEvent != null)
                NextPageEvent(cboPages.SelectedIndex, this.NumberRowsPerPage);
        }

    }
}
