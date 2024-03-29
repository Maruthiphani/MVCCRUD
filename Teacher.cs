﻿using System.ComponentModel.DataAnnotations;

namespace CRUDmvc.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherAddress { get; set; }

        public int TeacherAge { get; set; }

        public Subject Subjects { get; set; }
    }
}
