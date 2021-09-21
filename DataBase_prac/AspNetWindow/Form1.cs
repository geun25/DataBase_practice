using AdoNetWindow.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdoNetWindow
{
    public partial class Form1 : ApplicationRoot
    {

        //MsSql msql;
        //string ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadConfiguration()
        {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //ConnectionString = config.ConnectionStrings.ConnectionStrings["WinConnection"].ToString();
            //msql = new MsSql(ConnectionString);
            //ConfigurationMgr instance = ConfigurationMgr.Instance();
            //MessageBox.Show(instance.Connection.State.ToString());
            //instance.Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataReader
            string sql = "select * from tb_student";
            SqlCommand command = new SqlCommand(sql, (SqlConnection)instance.Connection);
            SqlDataReader rd = command.ExecuteReader(CommandBehavior.CloseConnection);
            List<StudentModel> students = new List<StudentModel>();
            while(rd.Read())
                students.Add(GetStudentModel(rd));
            foreach(StudentModel model in students)
                Console.WriteLine(model.ToString());
        }

        private StudentModel GetStudentModel(SqlDataReader rd)
        {
            StudentModel model = new StudentModel();
            model.StudentId = int.Parse(rd.GetString(1).ToString(); 
            model.StudentName = rd["StudentName"].ToString();
            model.Address = rd["Address"].ToString();
            return model;
        }
    } 
}
