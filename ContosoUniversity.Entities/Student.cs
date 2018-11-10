using System;
using System.Collections.Generic;

namespace ContosoUniversity.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}