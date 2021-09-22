using AppConfiguration;
using System.ComponentModel;
using System.Windows.Forms;

namespace AdoNetWindow
{
    public partial class ApplicationRoot : Form
    {
        protected ConfigurationMgr instance;
        public ApplicationRoot()
        {
            InitializeComponent();
            
            // 디자인 모드에서는 동작하지 않도록 함.
            if(LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                instance = ConfigurationMgr.Instance();
        }
    }
}
