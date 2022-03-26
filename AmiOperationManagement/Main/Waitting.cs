using System;
using System.Drawing;
using System.Windows.Forms;

namespace AmiOperationManagement.Main
{
    public partial class Waitting : Form
    {
        public Waitting()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        public int MaxValue { get; set; }

        int index = -1;

        public void ValueChanged(int value)
        {
            Invoke(new Action(() =>
                    {
                        if (value >= this.MaxValue)
                        {
                            this.progress.Value = this.MaxValue;
                            index = 0;
                        }
                        else
                            this.progress.Value = value;
                    }));
        }

        public void CloseWaiting()
        {
            timer.Enabled = false;
            this.Close();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            index += 20;
            ValueChanged(index);
        }

        private void progress_ValueChanged(object sender, System.EventArgs e)
        {
            this.progress.IsRunning = !this.progress.IsRunning;
        }

        private void Waitting_Load(object sender, System.EventArgs e)
        {
            MaxValue = 100;
            timer.Enabled = true;
        }

    }
}
