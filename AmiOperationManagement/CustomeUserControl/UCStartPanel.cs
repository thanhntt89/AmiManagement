
namespace AmiOperationManagement.CustomeUserControl
{
    public partial class UCStartPanel : UserControlBase
    {
        public string TitlePage = "Trang chủ";
        public UCStartPanel()
        {
            InitializeComponent();           
        }     

        private void UCStartPanel_Load(object sender, System.EventArgs e)
        {
            ucTextMaquee1.TextMarquee = lblInfo.Text;
        }

        public void Start()
        {
            ucTextMaquee1.Start();
        }

        public void Stop()
        {
            ucTextMaquee1.Stop();
        }
    }
}
