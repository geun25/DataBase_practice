using AppConfiguration;
using System.Windows.Forms;

namespace AdoNetWindow
{
    public partial class ApplicationRoot : Form
    {
        protected ConfigurationMgr instance;
        public ApplicationRoot()
        {
            InitializeComponent();
            instance = ConfigurationMgr.Instance();
        }
    }
}
