using AppConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
