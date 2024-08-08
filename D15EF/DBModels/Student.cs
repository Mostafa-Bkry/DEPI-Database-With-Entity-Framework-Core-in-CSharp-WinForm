using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModels
{
    public class Student
    {
        [Key]
        public int St_Id { get; set; }

        [MaxLength(50)]
        public string? Fname { get; set; }

        [MaxLength(10)]
        public string? Sname { get; set; }

        [MaxLength(100)]
        public string? Address { get; set; }

        public int? Age { get; set; }

        [ForeignKey("StDept")]
        public int? Dept_Id { get; set; }
        public Department? StDept { get; set; }

        [ForeignKey("SuperVisor")]
        public int? St_super { get; set; }
        public Student? SuperVisor { get; set; }

        public ICollection<Student> SuperVisedSts { get; set; }
    }
}
