using CRUDmvc.Context;
using CRUDmvc.Models;
using CRUDmvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUDmvc.Controllers
{
    public class SubjectController : Controller
    {
        ISubjectServices iss;

        public SubjectController(ISubjectServices _iss)
        {
            iss = _iss;
        }
        public IActionResult Index()
        {
            //IEnumerable<Subject> subjects = db.Subjects.Select(s => s).ToList();
            return View(iss.GetAllSubjects());
        }

        public IActionResult Delete(int id)
        {
            //Subject subjects = db.Subjects.FirstOrDefault(s => s.SubjectId == id);
            //if(subjects != null)
            //{
            //    db.Remove(subjects);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View();
            iss.DeleteASubject(id);
            return RedirectToAction("Index");
        }
    }
}
