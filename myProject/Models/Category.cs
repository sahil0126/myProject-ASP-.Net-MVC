using System.ComponentModel.DataAnnotations;

namespace myProject.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
