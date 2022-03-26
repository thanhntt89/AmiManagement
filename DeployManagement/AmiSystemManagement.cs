using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeployManagement.History;
using DeployManagement.Operation;
using DeployManagement.User;
using ErrorManagement;

namespace DeployManagement
{
    public partial class AmiSystemManagement : DevComponents.DotNetBar.Metro.MetroForm
    {
        
        public bool checkMpClick;
        public AmiSystemManagement()
        {
            InitializeComponent();
            var a = this.PointToScreen(labelX1.Location);
            a = itemFuntion.PointToClient(a);
            labelX1.Parent = itemFuntion;
            labelX1.Location = a;
            labelX1.BackColor = System.Drawing.Color.Transparent;


        }

        private void itemPanel1_ItemClick(object sender, EventArgs e)
        {

        }

        private void mtOperator_Click(object sender, EventArgs e)
        {
            OperationMain operationMain = new OperationMain();
            operationMain.ShowDialog();
        }

        private void lbFuntionSystem_Click(object sender, EventArgs e)
        {

        }

        private void FunctionManagement_Load(object sender, EventArgs e)
        {

        }

        private void mtUser_Click(object sender, EventArgs e)
        {
            UserMain userMain = new UserMain();
            userMain.ShowDialog();

        }

        private void mtErrorManagement_Click(object sender, EventArgs e)
        {
        }

        private void mtcheckmp_Click(object sender, EventArgs e)
        {
            DeploymentMain deploymentMain = new DeploymentMain();
            deploymentMain.ShowDialog();
        }

        private void btnHistorical_Click(object sender, EventArgs e)
        {
            HistoricalMain historicalMain = new HistoricalMain();
            historicalMain.ShowDialog();
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }
    }
}
