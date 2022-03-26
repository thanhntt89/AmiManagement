using System;

namespace AmiOperationManagement.About
{
    public partial class SoftwareAbout : DevComponents.DotNetBar.Metro.MetroForm
    {
        public SoftwareAbout()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}