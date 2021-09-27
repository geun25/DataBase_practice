using AdoNetWindow.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdoNetWIndow.View
{
    public class StudentView
    {
        public void ShowStudentOnGrid(DataGridView control, List<StudentModel> list)
        {
            control.DataSource = list;
            control.Columns["StudentId"].HeaderText = "학생코드";
            control.Columns["StudentId"].ReadOnly = true;
            control.Columns["StudentName"].HeaderText = "학생명";
        }

        public void ShowStudentOnCombo(ComboBox control, List<StudentModel>list)
        {
            control.DataSource = list;
            control.DisplayMember = "StudentName";
            control.ValueMember = "StudentId";
        }
    }
}
