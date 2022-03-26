using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using AmiOperationManagement.CustomeUserControl;

namespace AmiOperationManagement.UserControlCustom
{
    public partial class UCTextMaquee : UserControlBase
    {
        public string TextMarquee { get; set; }

        bool LeftToRight = false;
        int delay = 10; // Milliseconds
        private int xpos = 0, ypos = 0;
        string text = string.Empty;
        private ManualResetEvent PauseUnpauseMarque = new ManualResetEvent(true);
        private Color forcolor = Color.LightBlue;
        private bool isRunning = false;
        public UCTextMaquee()
        {
            InitializeComponent();
            //  this.MarqueLabel.ForeColor = forcolor;
            this.text = this.MarqueLabel.Text;
        }

        public void Start()
        {
            isRunning = true;
            StartMarque();
        }

        public void Stop()
        {
            isRunning = false;
        }

        public void StartRun(string textMaque, Color _color)
        {
            MarqueLabel.Text = text = textMaque;
            this.MarqueLabel.ForeColor = _color;
        }

        private async void StartMarque()
        {
            while (isRunning)
            {
                await Task.Run(() => PauseUnpauseMarque.WaitOne());
                if (xpos <= 0)
                {
                    while (isRunning)
                    {
                        if (string.IsNullOrWhiteSpace(MarqueLabel.Text))
                            break;

                        await Task.Run(() => PauseUnpauseMarque.WaitOne());
                        if (LeftToRight)
                            MarqueLabel.Text = "-" + MarqueLabel.Text + MarqueLabel.Text.Remove(MarqueLabel.Text.Length - 1) + "-";
                        else
                            MarqueLabel.Text = MarqueLabel.Text.Substring(1);
                        await Task.Delay(delay * 10);
                    }

                    this.MarqueLabel.Location = new System.Drawing.Point(this.Width, ypos);
                    xpos = this.Width;
                    this.MarqueLabel.Text = text;
                }

                if (LeftToRight)
                {
                    if (this.Width == xpos)
                    {
                        this.MarqueLabel.Location = new System.Drawing.Point(0, ypos);
                        xpos = 0;

                    }
                    else
                    {
                        this.MarqueLabel.Location = new System.Drawing.Point(xpos, ypos);
                        xpos += 2;
                    }
                }
                else
                {
                    if (xpos > 0)
                    {
                        this.MarqueLabel.Location = new System.Drawing.Point(xpos, ypos);
                        xpos -= 3;
                    }
                }
                await Task.Delay(delay);
            }
        }

        private void UCTextMaquee_SizeChanged(object sender, System.EventArgs e)
        {
            this.MarqueLabel.Top = (this.Height - this.MarqueLabel.Height) / 2;
        }
    }
}
