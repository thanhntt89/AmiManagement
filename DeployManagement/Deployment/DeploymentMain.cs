using System;
using System.Windows.Forms;
using DeployManagement.Deployment;

namespace DeployManagement
{
    public partial class DeploymentMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        UCCheckMeasurementPoint uCCheckMeasurementPoint = null;
        UCCustomerManagement uCCustomerManagement = null;
        UCDcuManagement uCDcuManagement = null;
        UCMeasurementPointManagement uCMeasurementPointManagement = null;
        UCMessageRevecive uCMessageRevecive = null;
        UCMeterManagement uCMeterManagement = null;

        public DeploymentMain()
        {
            InitializeComponent();          
        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Deploy_Load(object sender, EventArgs e)
        {

        }

        private void tabCheckMeasurementPoint_Click(object sender, EventArgs e)
        {
            pnCheckMeasurementPoint.Controls.Clear();
            if (uCCheckMeasurementPoint == null)
                uCCheckMeasurementPoint = new UCCheckMeasurementPoint();
            uCCheckMeasurementPoint.Dock = DockStyle.Fill;
            pnCheckMeasurementPoint.Controls.Add(uCCheckMeasurementPoint);
                

        }

        private void tabMessageReceive_Click(object sender, EventArgs e)
        {
            pnMessageReceive.Controls.Clear();
            if (uCMessageRevecive == null)
                uCMessageRevecive = new UCMessageRevecive();
            uCMessageRevecive.Dock = DockStyle.Fill;
            pnMessageReceive.Controls.Add(uCMessageRevecive);
        }

        private void tabMpManagement_Click(object sender, EventArgs e)
        {
            pnMpManagement.Controls.Clear();
            if (uCMeasurementPointManagement == null)
                uCMeasurementPointManagement = new UCMeasurementPointManagement();
            uCMeasurementPointManagement.Dock = DockStyle.Fill;
            pnMpManagement.Controls.Add(uCMeasurementPointManagement);
        }

        private void tabDcuManagement_Click(object sender, EventArgs e)
        {
            pnDcuManagement.Controls.Clear();
            if (uCDcuManagement == null)
                uCDcuManagement = new UCDcuManagement();
            uCDcuManagement.Dock = DockStyle.Fill;
            pnDcuManagement.Controls.Add(uCDcuManagement);

        }

        private void tabMeterManagement_Click(object sender, EventArgs e)
        {
            pnMeterManagement.Controls.Clear();
            if (uCMeterManagement == null)
                uCMeterManagement = new UCMeterManagement();
            uCMeterManagement.Dock = DockStyle.Fill;
            pnMeterManagement.Controls.Add(uCMeterManagement);
        }

        private void tabCustomerManagement_Click(object sender, EventArgs e)
        {
            pnCustomerManagement.Controls.Clear();
            if (uCCustomerManagement == null)
                uCCustomerManagement = new UCCustomerManagement();
            uCCustomerManagement.Dock = DockStyle.Fill;
            pnCustomerManagement.Controls.Add(uCCustomerManagement);
        }


    }
}
