using System.Collections;
using System.Collections.Generic;

namespace ContosoUniversity.Entities
{
    public class Course
    {
        public int CourseId { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }
    }
}