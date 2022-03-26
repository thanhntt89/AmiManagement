using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeployManagement
{
    public partial class Login : DevComponents.DotNetBar.Metro.MetroForm
    {
        public bool isLogined;

        public Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.isLogined = true;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.isLogined = false;
            this.Close();
        }
    }
}
