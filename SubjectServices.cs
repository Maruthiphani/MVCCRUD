using CRUDmvc.Context;
using CRUDmvc.Models;

namespace CRUDmvc.Services
{
    public class SubjectServices : ISubjectServices
    {
        MVCContext db;

        public SubjectServices(MVCContext _db)
        {
            db = _db;
        }
        public void DeleteASubject(int id)
        {
            Subject subjects = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            if (subjects != null)
            {
                db.Remove(subjects);
                db.SaveChanges();
               
            }
            
        }

        public IEnumerable<Subject> GetAllSubjects()
        {
          //  IEnumerable<Subject> subjects = db.Subjects.Select(s => s).ToList();
            return (db.Subjects.Select(s => s).ToList());
        }
    }
}
