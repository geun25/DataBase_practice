using AppConfiguration;

namespace Libs
{
    public class ClassRoot
    {
        protected ConfigurationMgr dbInstance;

        public ClassRoot()
        {
            dbInstance = ConfigurationMgr.Instance();
        }
    }
}
