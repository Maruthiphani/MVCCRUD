using System.ComponentModel.DataAnnotations;

namespace CRUDmvc.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }

        public string SubjectTerm { get; set; }

        public int SubjectCredits { get; set; }

        public List<Teacher> SubjectsTeacher { get; set; } = new List<Teacher>();
    }
}
