using AdoNetWindow.Model;
using Dapper;
using Libs;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Repositories
{
    public class SubjectRepository : ClassRoot, ISubjectRepository
    {
        public int Add(SubjectModel model, IDbTransaction transaction = null)
        {
            string spName = "SP_Subject_Add";
            var parameters = new DynamicParameters();
            parameters.Add("@SubjectId", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            parameters.Add("@SubjectName", value: model.SubjectName, dbType: DbType.String, direction: ParameterDirection.Input);
            int newId = dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
            model.SubjectId = parameters.Get<int>("@SubjectId");
            return newId;
        }

        public int Delete(int subject_id, IDbTransaction transaction = null)
        {
            string spName = "SP_Subject_Delete";
            var parameters = new DynamicParameters();
            parameters.Add("@SubjectId", value: subject_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        public List<SubjectModel> GetAll(IDbTransaction transaction = null)
        {
            string spName = "SP_Subject_GetAll";
            var parameters = new DynamicParameters();
            return dbInstance.Connection.Query<SubjectModel>(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure).ToList();       
        }

        public SubjectModel GetById(int subject_id, IDbTransaction transaction = null)
        {
            string spName = "SP_Subject_GetAll";
            var parameters = new DynamicParameters();
            parameters.Add("@SubjectId", value: subject_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbInstance.Connection.Query<SubjectModel>(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public int Update(int subject_id, string subject_name, IDbTransaction transaction = null)
        {
            string spName = "SP_Subject_Update";
            var parameters = new DynamicParameters();
            parameters.Add("@SubjectId", value: subject_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@SubjectName", value: subject_name, dbType: DbType.String, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        public int Update(SubjectModel model, IDbTransaction transaction = null)
        {
            string spName = "SP_Subject_Update";
            var parameters = new DynamicParameters();
            parameters.Add("@SubjectId", value: model.SubjectId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@SubjectName", value: model.SubjectName, dbType: DbType.String, direction: ParameterDirection.Input);
            return dbInstance.Connection.Execute(spName, param: parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }
    }
}
