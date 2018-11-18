namespace ContosoUniversity.Entities
{
    public class Enrollment
    {
        public Enrollment()
        {
            Course = new Course();
            Student = new Student();
        }

        public int EnrollmentId { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public string Grade { get; set; }


        public Course Course { get; set; }

        public Student Student { get; set; }
    }
}