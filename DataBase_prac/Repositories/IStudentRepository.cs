using AdoNetWindow.Model;
using System.Collections.Generic;
using System.Data;

namespace Repositories
{
    public interface IStudentRepository
    {
        void Add(StudentModel model, IDbTransaction transaction = null);
        int Delete(int student_id, IDbTransaction transaction = null);
        int Update(StudentModel model, IDbTransaction transaction = null);
        StudentModel GetById(int student_model, IDbTransaction transaction = null);
        List<StudentModel> GetAll(IDbTransaction transaction = null);
    }
}
