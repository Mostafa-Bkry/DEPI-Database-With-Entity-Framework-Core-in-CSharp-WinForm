using System.ComponentModel.DataAnnotations;

namespace DBModels
{
    public class InstCourse
    {
        public int Ins_Id { get; set; }
        public int Crs_Id { get; set; }

        [MaxLength(50)]
        public string? Evaluation { get; set; }

        public Course Crs { get; set; }
        public Instructor Inst { get; set; }
    }
}
