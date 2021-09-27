using AdoNetWindow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWIndow.View
{
    public class CourseRegistrationView
    {
        public void ShowOnGrid(DataGridView control, List<CourseRegistrationModel> list)
        {
            control.DataSource = list;
            control.Columns["StudentId"].Visible = false;
            control.Columns["SubjectId"].Visible = false;
            control.Columns["StudentName"].HeaderText = "학생명";
            control.Columns["SubjectName"].HeaderText = "과목명";
            control.Columns["RegistedDate"].HeaderText = "등록일";
        }
    }
}
