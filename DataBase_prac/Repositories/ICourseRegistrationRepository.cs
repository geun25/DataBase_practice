using AdoNetWindow.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICourseRegistrationRepository
    {
        int Add(int student_id, int subject_id, IDbTransaction transaction = null);
        int Add(CourseRegistrationModel model, IDbTransaction transaction = null);
        int Delete(int student_id, int subject_id, IDbTransaction transaction = null);
        int Update(int student_id, int subject_id, int new_subject_id, DateTime registed_date, IDbTransaction transaction = null);
        List<CourseRegistrationModel> GetByUser(int student_id, IDbTransaction transaction = null);
    }
}
