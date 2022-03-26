using AmiOperationLib;
using System;
using System.Windows.Forms;

namespace AmiOperationManagement.CustomeUserControl
{
    public partial class UCProgressBarStop : UserControl
    {
        public event StopSendingHandle StopSendingEvent;
        public event DisplayProgressBarHandle DisplayProgressBarEvent;

        public UCProgressBarStop()
        {
            InitializeComponent();
        }

        public void SetTile(string text)
        {
            this.btnStop.Text = text;
            if (text.Equals(Constant.StopSendingText))
            {
                btnStop.Enabled = true;
                prgBar.Maximum = 0;
                prgBar.Value = 0;
            }
            else
            {
                btnStop.Enabled = false;
            }
        }

        public void SetValue(int maxValue, int value)
        {
            Invoke(new Action(() =>
              {
                  if (prgBar.Maximum == 0)
                  {
                      prgBar.Maximum = maxValue;
                  }
                  if (prgBar.Value == maxValue - 1)
                      prgBar.Value = maxValue;
                  else
                      prgBar.Value = value;

                  this.prgBar.Text = String.Format(Constant.ProccessingText, value, maxValue);
              }));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (this.StopSendingEvent != null)
            {
                this.StopSendingEvent();
                if (this.DisplayProgressBarEvent != null)
                    this.DisplayProgressBarEvent(true);
                btnStop.Enabled = false;
                btnStop.Text = Constant.StopingSendingText;
                this.prgBar.Text = Constant.StopProccessingText;
            }
        }
    }
}
