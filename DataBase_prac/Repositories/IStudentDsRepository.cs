using AdoNetWindow.Model;
using System.Data;

namespace Repositories
{
    public interface IStudentDsRepository
    {
        int Add(StudentModel model, IDbTransaction transaction = null);
        int Delete(int student_id, IDbTransaction transaction = null);
        int Update(StudentModel model, IDbTransaction transaction = null);
        StudentModel GetById(int student_model, IDbTransaction transaction = null);
        DataSet GetAll(IDbTransaction transaction = null);
    }
}
