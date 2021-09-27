using AdoNetWindow.Model;
using AdoNetWindow.View;
using AdoNetWIndow.View;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWindow
{
    public partial class frmCourseRegistration : Form
    {
        ICourseRegistrationRepository courseRegistrationRepository;
        StudentModel SelectedStudent;

        public frmCourseRegistration()
        {
            InitializeComponent();
            courseRegistrationRepository = new CourseRegistrationRepository();
        }

        private void frmCourseRegistration_Load(object sender, EventArgs e)
        {
            V_ShowStudentOnCombo();
        }

        private void V_ShowStudentOnCombo()
        {
            StudentView studentView = new StudentView();
            List<StudentModel> students = new List<StudentModel>();
            students.Add(new StudentModel { StudentId = -1, StudentName = "--선택하세요--" });
            students.AddRange((new StudentRepository()).GetAll());
            studentView.ShowStudentOnCombo(cbStudent, students);
        }

        private void cbStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedStudent = cbStudent.SelectedItem as StudentModel;
            V_ShowCourseRegistrationOnGrid();
            V_ShowSubject();
        }

        private void V_ShowSubject()
        {
            SubjectView subjectview = new SubjectView();
            List<SubjectModel> subjectModels = (new SubjectRepository()).GetAll();
            subjectview.ShowOnGrid(gridSubject, subjectModels);
        }

        private void V_ShowCourseRegistrationOnGrid()
        {
            CourseRegistrationView courseRegistrationView = new CourseRegistrationView();
            courseRegistrationView.ShowOnGrid(gridCourseResistration, 
                ((new CourseRegistrationRepository()).GetByUser(SelectedStudent.StudentId)));
        }

        private void btnCourseRegistration_Click(object sender, EventArgs e)
        {
            DoCourseRegistration();
            V_ShowCourseRegistrationOnGrid();
        }

        private void DoCourseRegistration()
        {
            foreach(DataGridViewRow dgvr in gridSubject.SelectedRows)
            {
                SubjectModel subjectModel = dgvr.DataBoundItem as SubjectModel;
                RegistASubject(subjectModel);
            }
        }

        private void RegistASubject(SubjectModel subjectModel)
        {
            ICourseRegistrationRepository courseRegistrationRepository = new CourseRegistrationRepository();
            try
            {
                courseRegistrationRepository.Add(SelectedStudent.StudentId, subjectModel.SubjectId);
            }
            catch
            {
                MessageBox.Show($"{subjectModel.SubjectName}은 이미 등록되었습니다.");
            }
        }
    }
}
