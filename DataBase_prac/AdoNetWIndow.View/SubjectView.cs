using AdoNetWindow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWindow.View
{
    /// <summary>
    /// DataGridView, Combobox, ListBox, TreeView 등에 Binding하는 함수를 공유
    /// </summary>
    public class SubjectView
    {
        public void ShowOnGrid(DataGridView control, List<SubjectModel> list)
        {
            control.DataSource = list;
            control.Columns["SubjectId"].HeaderText = "과목코드";
            control.Columns["SubjectId"].ReadOnly = true;
            control.Columns["SubjectName"].HeaderText = "과목명";
        }
    }
}
