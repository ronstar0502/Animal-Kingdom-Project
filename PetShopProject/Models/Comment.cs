using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopProject.Models
{
    public class Comment
    {
        [Key]
        public int commentId{ get; set; }
        [Required]
        public string? CommentText { get; set; }
        public int AnimalId { get; set; }
        public virtual Animal? Animals { get; set; }
        public int Likes { get; set; }
        public DateTime? CommentDate { get; set; }

    }
}
