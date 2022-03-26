using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeployManagement.Operation
{
    public partial class OperationMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        UCErrorDCU uCErrorDCU = null;
        UCControlDCU uCControlDCU = null;
        UCGetLostMessage uCGetLostMessage = null;
        UCFirmware uCFirmware = null;
        UCServer uCServer = null;
        UCMeterType uCMeterType = null;
        UCTopicManagement uCTopicManagement = null;

        public OperationMain()
        {
            InitializeComponent();
        }

        private void superTabOperation_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {

        }

        private void applicationButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabFailModem_Click(object sender, EventArgs e)
        {

        }

        private void tabFailModem_Click_1(object sender, EventArgs e)
        {
            pnErrorDCU.Controls.Clear();
            if (uCErrorDCU == null)
                uCErrorDCU = new UCErrorDCU();
            uCErrorDCU.Dock =  DockStyle.Fill;
            pnErrorDCU.Controls.Add(uCErrorDCU);
        }

        private void tabGetLostMessage_Click(object sender, EventArgs e)
        {
            pnGetLostMessage.Controls.Clear();
            if (uCGetLostMessage == null)
                uCGetLostMessage = new UCGetLostMessage();
            uCGetLostMessage.Dock = DockStyle.Fill;
            pnGetLostMessage.Controls.Add(uCGetLostMessage);
        }

        private void tabControlDCU_Click(object sender, EventArgs e)
        {
            pnControlDCU.Controls.Clear();
            if (uCControlDCU == null)
                uCControlDCU = new UCControlDCU();
            uCControlDCU.Dock = DockStyle.Fill;
            pnControlDCU.Controls.Add(uCControlDCU);
        }

        private void subtabMeterType_Click(object sender, EventArgs e)
        {
            pnMeterType.Controls.Clear();
            if (uCMeterType == null)
                uCMeterType = new UCMeterType();
            uCMeterType.Dock = DockStyle.Fill;
            pnMeterType.Controls.Add(uCMeterType);
        }

        private void subtabFirmware_Click(object sender, EventArgs e)
        {
            pnFirmware.Controls.Clear();
            if (uCFirmware == null)
                uCFirmware = new UCFirmware();
            uCFirmware.Dock = DockStyle.Fill;
            pnFirmware.Controls.Add(uCFirmware);
        }

        private void subtabTopicManangement_Click(object sender, EventArgs e)
        {
            pnTopic.Controls.Clear();
            if (uCTopicManagement == null)
                uCTopicManagement = new UCTopicManagement();
            uCTopicManagement.Dock = DockStyle.Fill;
            pnTopic.Controls.Add(uCTopicManagement);
        }

        private void subtabServer_Click(object sender, EventArgs e)
        {
            pnServer.Controls.Clear();
            if (uCServer == null)
                uCServer = new UCServer();
            uCServer.Dock = DockStyle.Fill;
            pnServer.Controls.Add(uCServer);
        }
    }
}