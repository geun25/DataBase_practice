using AdoNetWindow.Model;
using Repositories;
using System;

namespace AdoNetWindow
{
    public partial class Form1 : ApplicationRoot
    {
        //MsSql msql;
        //string ConnectionString;
        IStudentRepository studentRepository;
       
        public Form1()
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
            studentRepository.Delete(student_id);
            V_ShowStudent();
        }
    } 
}
