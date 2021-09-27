using AdoNetWindow.Model;
using Dapper;
using Libs;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Repositories
{
    public class StudentRepository : ClassRoot, IStudentRepository
    {
        public StudentRepository()
        {

        }

        //public int Add(StudentModel model, IDbTransaction transaction = null)
        //{
        //    StringBuilder qry = new StringBuilder();
        //    qry.Append($" INSERT INTO TB_Student (StudentName, Address)");
        //    qry.Append($" Values('{model.StudentName}', '{model.Address}')");
        //    qry.Append($" SELECT SCOPE_IDENTITY()");

        //    SqlCommand command = new SqlCommand(qry.ToString(), (SqlConnection)dbInstance.Connection);
        //    model.StudentId = int.Parse(command.ExecuteScalar().ToString());
        //    return model.StudentId;
        //}

        //public int Add(StudentModel model, IDbTransaction transaction = null)
        //{
        //    StringBuilder qry = new StringBuilder();
        //    qry.Append($" INSERT INTO TB_Student (StudentName, Address)");
        //    qry.Append($" Values('{model.StudentName}', '{model.Address}')");
        //    qry.Append($" SELECT SCOPE_IDENTITY()");

        //    SqlCommand command = new SqlCommand("SP_Student_Add", (SqlConnection)dbInstance.Connection);
        //    command.CommandType = CommandType.StoredProcedure;

        //    SqlParameter paramStudentName = new SqlParameter();
        //    paramStudentName.ParameterName = "@StudentName";
        //    paramStudentName.SqlDbType = SqlDbType.VarChar;
        //    paramStudentName.Value = model.StudentName;
        //    command.Parameters.Add(paramStudentName);

        //    SqlParameter paramAddress = new SqlParameter("@Address", SqlDbType.VarChar);
        //    paramAddress.Value = model.Address;
        //    command.Parameters.Add(paramAddress);

        //    object newId = command.ExecuteScalar();
        //    model.StudentId = int.Parse(newId.ToString());
        //    return model.StudentId;
        //}

        // Dapper 사용
        public void Add(StudentModel model, IDbTransaction transaction = null)
        {
            string spName = "SP_Student_Add";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            parameters.Add("@StudentName", value: model.StudentName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Address", value: model.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            int newId = dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
            model.StudentId = parameters.Get<int>("@StudentId");
        }

        //public int Delete(int student_id, IDbTransaction transaction = null)
        //{
        //    StringBuilder qry = new StringBuilder();
        //    qry.Append($" DELETE TB_Student WHERE StudentId = {student_id}");
        //    SqlCommand command = new SqlCommand(qry.ToString(), (SqlConnection)dbInstance.Connection);
        //    return command.ExecuteNonQuery();
        //}

        public int Delete(int student_id, IDbTransaction transaction = null)
        {
            string spName = "SP_Student_Delete";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        //public DataSet GetAll(IDbTransaction transaction = null)
        //{
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    StringBuilder qry = new StringBuilder();
        //    qry.Append($" SELECT StudentId, StudentName, Address");
        //    qry.Append($" FROM TB_Student ORDER BY StudentName");
        //    da.SelectCommand = new SqlCommand(qry.ToString(), (SqlConnection)dbInstance.Connection);
        //    da.Fill(ds);
        //    return ds;
        //}

        public List<StudentModel> GetAll(IDbTransaction transaction = null)
        {
            string spName = "SP_Student_GetAll";
            var parameters = new DynamicParameters();
            return dbInstance.Connection.Query<StudentModel>(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure).ToList();
        }

        public StudentModel GetById(int student_id, IDbTransaction transaction = null)
        {
            string spName = "SP_Student_GetById";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: student_id, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            return dbInstance.Connection.Query<StudentModel>(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public int Update(StudentModel model, IDbTransaction transaction = null)
        {
            string spName = "SP_Student_Update";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@StudentName", value: model.StudentName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Address", value: model.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        public int UpdateName(int student_id, string student_name, IDbTransaction transaction = null)
        {
            string spName = "SP_Student_UpdateName";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: student_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@StudentName", value: student_name, dbType: DbType.String, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
    }

        /// <summary>
        /// Dapper를 사용해서 불필요한 함수를 생략 가능
        /// </summary>
        /// <param name="rd"></param>
        /// <returns></returns>
        //private List<StudentModel> GetStudentModel(SqlDataReader rd)
        //{
        //    List<StudentModel> studentLists = new List<StudentModel>();
        //    while(rd.Read())
        //    {
        //        StudentModel model = new StudentModel();
        //        model.StudentId = int.Parse(rd["StudentId"].ToString());
        //        model.StudentName = rd["StudentName"].ToString();
        //        model.Address = rd["Address"].ToString();
        //        studentLists.Add(model);
        //    }
        //    rd.Close();
        //    return studentLists;
        //}
    }
}
