using AdoNetWindow.Model;
using Libs;
using Repositories;
using System;
using System.Windows.Forms;

namespace AdoNetWindow
{
    public partial class frmStudentAdd : ApplicationRoot
    {
        //MsSql msql;
        //string ConnectionString;

        IStudentRepository studentRepository;
       
        public frmStudentAdd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentRepository = new StudentRepository();
            V_ShowStudent();
        }

        private void ReadConfiguration()
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //ConnectionString = config.ConnectionStrings.ConnectionStrings["WinConnection"].ToString();
            //msql = new MsSql(ConnectionString);
            //ConfigurationMgr instance = ConfigurationMgr.Instance(); // 인스턴스를 딱 한번만 생성
            //MessageBox.Show(instance.Connection.State.ToString());
            //instance.Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataReader
            //string sql = "select * from tb_student";
            //SqlCommand command = new SqlCommand(sql, (SqlConnection)instance.Connection);
            //SqlDataReader rd = command.ExecuteReader(CommandBehavior.CloseConnection);
            //List<StudentModel> students = new List<StudentModel>();
            //while(rd.Read())
            //    students.Add(GetStudentModel(rd));
            //foreach(StudentModel model in students)
            //    Console.WriteLine(model.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentAdd();
        }

        private void V_ShowStudent()
        {
            gridStudent.DataSource = studentRepository.GetAll();
            gridStudent.Columns["StudentId"].HeaderText = "학생Id";
            gridStudent.Columns["StudentId"].ReadOnly = true;
            gridStudent.Columns["StudentName"].HeaderText = "학생성명";
            gridStudent.Columns["Address"].HeaderText = "주소";
        }

        private void StudentAdd()
        {
            StudentModel studentModel = new StudentModel();
            studentModel.StudentName = txtStudentName.Text.Trim();
            studentModel.Address = txtAddress.Text.Trim();
            studentRepository.Add(studentModel);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridStudent.SelectedRows.Count == 0)
                return;
            //StudentDelete(int.Parse(gridStudent.SelectedRows[0].Cells["StudentId"].Value.ToString()));
            StudentModel studentModel = gridStudent.SelectedRows[0].DataBoundItem as StudentModel;
            StudentDelete(studentModel.StudentId);
        }

        private void StudentDelete(int student_id)
        {
            //studentRepository.Delete(student_id);
            IStudentDeleteHandler studentDeleteHandler = new StudentDeleteHandler();
            try
            {
                studentDeleteHandler.Delete(student_id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            V_ShowStudent();
        }

        private void gridStudent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridStudent.Rows.Count == 0 || gridStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("학생을 한명 선택하세요");
                return;
            }

            StudentModel studentModel = gridStudent.SelectedRows[0].DataBoundItem as StudentModel;
            if (e.ColumnIndex == 1 && e.RowIndex != -1)
                studentRepository.UpdateName(studentModel.StudentId, studentModel.StudentName);
            V_ShowStudent();
        }
    } 
}
