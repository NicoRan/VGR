using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VGR.Models
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string CommentText { get; set; }
        
        public DateTime CreatedOn { get; set; }
        
        public Guid ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
