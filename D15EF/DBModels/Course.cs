
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModels
{
    public class Course
    {
        [Key]
        public int Crs_Id { get; set; }

        [MaxLength(50)]
        public string? Crs_Name { get; set; }
        public int? Crs_Duration { get; set; }

        [ForeignKey("Crs_Topic")]
        public int? Topic_Id { get; set; }
        public Topic? Crs_Topic { get; set; }

        public ICollection<InstCourse>? CrsInstructors { get; set; }

        public ICollection<StudCourse>? CrsStudents { get; set; }
    }
}
