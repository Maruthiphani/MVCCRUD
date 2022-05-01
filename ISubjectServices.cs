using CRUDmvc.Models;

namespace CRUDmvc.Services
{
    public interface ISubjectServices
    {
        public IEnumerable<Subject> GetAllSubjects();

        public void DeleteASubject(int id);
    }
}
