using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWindow.Model
{
    public class CourseRegistrationModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public DateTime RegistedDate { get; set; }
    }
}
