using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWindow.Model
{
    public class StudentModel
    {
        public int StudentId
        {
            get;
            set;
        }

        public string StudentName
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"[{StudentId}] {StudentName} ({Address})";
        }
    }
}
