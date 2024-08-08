
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModels
{
    public class Instructor
    {
        [Key]
        public int Ins_Id { get; set; }

        [MaxLength(50)]
        public string? Ins_Name { get; set; }

        [MaxLength(50)]
        public string? Ins_Degree { get; set; }

        public double? Salary { get; set; }

        [ForeignKey("InsDept")]
        public int? Dept_Id { get; set; }

        public Department? InsDept { get; set; }
    }
}
