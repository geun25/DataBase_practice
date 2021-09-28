using AdoNetWindow.Model;
using AdoNetWindow.View;
using Repositories;
using System;
using System.Windows.Forms;

namespace AdoNetWindow
{
    public partial class frmSubjectAdd : ApplicationRoot
    {
        SubjectRepository subjectRepository;
        public frmSubjectAdd()
        {
            InitializeComponent();
            subjectRepository = new SubjectRepository();
        }

        private void frmSubjectAdd_Load(object sender, EventArgs e)
        {
            V_ShowSubject();
        }

        private void V_ShowSubject()
        {
            SubjectView subjectview = new SubjectView();
            subjectview.ShowOnGrid(gridSubject, subjectRepository.GetAll());
        }

        private void btnSubjectAdd_Click(object sender, EventArgs e)
        {
            if (SubjectModelHasError())
                return;
            SubjectAdd();
            V_ShowSubject();
        }

        private void SubjectAdd()
        {
            SubjectModel subjectModel = new SubjectModel
            {
                SubjectName = txtSubjectName.Text.Trim()
            };
            subjectRepository.Add(subjectModel);
        }

        private bool SubjectModelHasError()
        {
            errorProvider1.Clear();
            bool error = false;
            if(txtSubjectName.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txtSubjectName, "과목명을 입력하세요."); ;
                error = true;
            }
            return error;
        }

        private void btnSubjectDelete_Click(object sender, EventArgs e)
        {
            if(gridSubject.Rows.Count == 0 || gridSubject.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 과목을 하나 선택하세요.");
                return;
            }
            SubjectModel subjectModel = gridSubject.SelectedRows[0].DataBoundItem as SubjectModel;
            SubjectDelete(subjectModel.SubjectId);
        }

        private void SubjectDelete(int subjectId)
        {
            subjectRepository.Delete(subjectId);
            V_ShowSubject();
        }
    }
}
