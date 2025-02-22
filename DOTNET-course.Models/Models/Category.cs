using System.ComponentModel.DataAnnotations;

namespace DOTNET_course.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Range(0, 100)]
        public int DisplayOrder { get; set; }
    }
}
