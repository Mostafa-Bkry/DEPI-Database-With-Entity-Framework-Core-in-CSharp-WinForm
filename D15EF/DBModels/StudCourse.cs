namespace DBModels
{
    public class StudCourse
    {
        public int Crs_Id { get; set; }
        public int Stud_Id { get; set; }
        public int? Grade { get; set; }

        public Course Crs { get; set; }
        public Student Stud { get; set; }
    }
}
