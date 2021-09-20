using AdoNet;
using AppConfiguration;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace AspNetWindow
{ 
    public partial class Form1 : Form
    {
        MsSql msql;
        string ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadConfiguration();
        }

        private void ReadConfiguration()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionString = config.ConnectionStrings.ConnectionStrings["WinConnection"].ToString();
            msql = new MsSql(ConnectionString);
            ConfigurationMgr instance = ConfigurationMgr.Instance();
            MessageBox.Show(instance.Connection.State.ToString());
            instance.Connection.Close();
        }
    }
}
