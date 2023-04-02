using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopProject.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string? ImageName { get; set; }
        [Required]
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required]
        public ICollection<Comment>? Comments { get; set; } = new List<Comment>();
        
    }
}
