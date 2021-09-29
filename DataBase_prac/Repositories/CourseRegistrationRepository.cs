using AdoNetWindow.Model;
using Dapper;
using Libs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CourseRegistrationRepository : ClassRoot, ICourseRegistrationRepository
    {
        public int Add(int student_id, int subject_id, IDbTransaction transaction = null)
        {
            string spName = "SP_CourseRegistration_Add";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value:student_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@SubjectId", value:subject_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@RegistedDate", value:DateTime.Now, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        public int Add(CourseRegistrationModel model, IDbTransaction transaction = null)
        {
            string spName = "SP_CourseRegistration_Add";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: model.StudentId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@SubjectId", value: model.SubjectId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@RegistedDate", value: model.RegistedDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        public int Delete(int student_id, int subject_id, IDbTransaction transaction = null)
        {
            string spName = "SP_CourseRegistration_Delete";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: student_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@SubjectId", value: subject_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        public List<CourseRegistrationModel> GetByUser(int student_id, IDbTransaction transaction = null)
        {
            string spName = "SP_CourseRegistration_GetByUser";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: student_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbInstance.Connection.Query<CourseRegistrationModel>(spName, param: parameters, transaction: transaction, 
                commandType: CommandType.StoredProcedure).ToList();
        }

        public int Update(int student_id, int subject_id, int new_subject_id, DateTime registed_date, IDbTransaction transaction = null)
        {
            string spName = "SP_CourseRegistration_Update";
            var parameters = new DynamicParameters();
            parameters.Add("@StudentId", value: student_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@SubjectId", value: subject_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@NewSubjectId", value: new_subject_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@RegistedDate", value: DateTime.Now, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }
    }
}
