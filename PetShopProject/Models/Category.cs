using System.ComponentModel.DataAnnotations;

namespace PetShopProject.Models
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
