using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VGR.Models
{
    public class Review
    {
        public Review()
        {
            this.Comments = new List<Comment>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string ReviewText { get; set; }
        
        [Required]
        public string GameName { get; set; }
        
        [Required]
        public string GamePublisher { get; set; }
        
        [Required]
        public string ReleaseYear { get; set; }
        
        [Required]
        public string VideoReview { get; set; }
        
        public DateTime CreatedOn { get; set; }

        //public Guid PowerUserId { get; set; }
        public PowerUser PowerUser { get; set; }

        //public Guid CommentId { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
