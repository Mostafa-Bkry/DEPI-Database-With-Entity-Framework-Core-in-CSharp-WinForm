using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBModels
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }

        [MaxLength(50)]
        public string? Dept_Name { get; set; }

        [MaxLength(100)]
        public string? Dept_Desc { get; set; }

        [MaxLength(50)]
        public string? Dept_Location { get; set; }

        [ForeignKey("Manager")]
        public int? Dept_Manager { get; set; }
        public Instructor? Manager { get; set; }

        public DateTime? Manager_HireDate { get; set; }

        public ICollection<Student> DeptStudents { get; set; }

        public ICollection<Instructor> DeptInstructors { get; set; }
    }
}
