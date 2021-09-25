using AppConfiguration;

namespace Libs
{
    /// <summary>
    /// db인스턴스 생성
    /// </summary>
    public class ClassRoot
    {
        protected ConfigurationMgr dbInstance;

        public ClassRoot()
        {
            dbInstance = ConfigurationMgr.Instance();
        }
    }
}
