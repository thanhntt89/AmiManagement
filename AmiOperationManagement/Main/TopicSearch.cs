using System;

namespace AmiOperationManagement.Main
{
    public partial class TopicSearch : DevComponents.DotNetBar.Metro.MetroForm
    {
        public event SendDataEventHandle SearchTopicEvent;

        public TopicSearch()
        {
            InitializeComponent();          
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == System.Windows.Forms.Keys.Enter)
                btnSearch_Click(null, null);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.SearchTopicEvent != null)
                this.SearchTopicEvent(txtSearchText.Text);
        }

        private void TopicSearch_Load(object sender, EventArgs e)
        {
            txtSearchText.TabIndex = 0;
            txtSearchText.Focus();
        }
    }
}