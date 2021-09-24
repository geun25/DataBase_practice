using AdoNetWindow.Model;
using System.Collections.Generic;
using System.Data;

namespace Repositories
{
    public interface ISubjectRepository
    {
        int Add(SubjectModel model, IDbTransaction transaction = null);
        int Delete(int subject_id, IDbTransaction transaction = null);
        int Update(int subject_id, string subject_name, IDbTransaction transaction = null);
        int Update(SubjectModel model, IDbTransaction transaction = null);
        SubjectModel GetById(int subject_id, IDbTransaction transaction = null);
        List<SubjectModel> GetAll(IDbTransaction transaction = null);

    }
}
