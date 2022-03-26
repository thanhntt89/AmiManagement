using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ErrorManagement
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        UCGetError uCGetError = null;
        UCReporting uCReporting = null;
        UCGetErrorDcu UCGetErrorDcu = null;
        UCGetLostMessage UCGetLostMessage = null;

        public MainForm()
        {
            InitializeComponent();
            ErrorDCU_Click(null, null);
            mnError_Click(null, null);
        }

        private void mnError_Click(object sender, EventArgs e)
        {
            panelEx1.Controls.Clear();
            if (uCGetError == null)
                uCGetError = new UCGetError(UCGetErrorDcu);
            uCGetError.Dock = DockStyle.Fill;
            panelEx1.Controls.Add(uCGetError);
        }

        private void mnRerpoting_Click(object sender, EventArgs e)
        {
            panelEx1.Controls.Clear();
            if (uCReporting == null)
                uCReporting = new UCReporting();
            uCReporting.Dock = DockStyle.Fill;
            panelEx1.Controls.Add(uCReporting);
        }

        private void mnErrorDefine_Click(object sender, EventArgs e)
        {
            UCErrorDefine ucErrorDefine = new UCErrorDefine();
            ucErrorDefine.ShowDialog();
        }

        private void mnFixbugeErrorStep_Click(object sender, EventArgs e)
        {
            FixbugeStep fixbugeStep = new FixbugeStep();
            fixbugeStep.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            uCGetError.CloseMainForm();           
            Process currentProcess = Process.GetCurrentProcess();
            currentProcess.Kill();

        }

        private void ErrorDCU_Click(object sender, EventArgs e)
        {
            panelEx1.Controls.Clear();
            if (UCGetErrorDcu == null)
                UCGetErrorDcu = new UCGetErrorDcu();
            UCGetErrorDcu.Dock = DockStyle.Fill;
            panelEx1.Controls.Add(UCGetErrorDcu);

        }

        private void LostMessage_Click(object sender, EventArgs e)
        {
            panelEx1.Controls.Clear();
            if (UCGetLostMessage == null)
                UCGetLostMessage = new UCGetLostMessage();
            UCGetLostMessage.Dock = DockStyle.Fill;
            panelEx1.Controls.Add(UCGetLostMessage);
        }

    }
}