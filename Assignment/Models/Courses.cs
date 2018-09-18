using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Courses
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SemesterOffered { get; set; }
        public int? SemesterOffered2 { get; set; }
        public string PrereqCourseCode { get; set; }
        public string Compulsory { get; set; }
    }
}
