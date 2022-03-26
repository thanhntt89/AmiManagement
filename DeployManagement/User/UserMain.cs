using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeployManagement.User
{
    public partial class UserMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        public UserMain()
        {
            InitializeComponent();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            CreateNewAccount createNewAccount = new CreateNewAccount();
            createNewAccount.ShowDialog();
        }
    }
}