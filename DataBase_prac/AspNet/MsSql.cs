using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    public class MsSql : IDatabase
    {
        public string ConnectionString { get; set; }

        public MsSql(string connection_string)
        {
            ConnectionString = connection_string;
        }
    }
}
