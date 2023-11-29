using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Entities
{
    public class Course
    {
        public Course()
        {
            Enrollments = new Collection<Enrollment>();
        }

        public int CourseId { get; set; }

        public int Code { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public int Credits { get; set; }


        public ICollection<Enrollment> Enrollments { get; set; }

        //public virtual ICollection<Instructor> Instructors { get; set; }
    }
}