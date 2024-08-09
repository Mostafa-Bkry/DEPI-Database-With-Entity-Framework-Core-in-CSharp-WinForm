using System.ComponentModel.DataAnnotations;

namespace DBModels
{
    public class Topic
    {
        [Key]
        public int Top_Id { get; set; }

        [MaxLength(50)]
        public string? Topic_Name { get; set; }

        public ICollection<Course>? Top_Courses { get; set; }
    }
}
