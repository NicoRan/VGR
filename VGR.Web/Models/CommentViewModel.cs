using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VGR.Web.Models
{
    public class CommentViewModel
    {
        public Guid Id { get; set; }
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        [DisplayName("User")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Comment")]
        public string CommentText { get; set; }
        [DisplayName("Date")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public Guid ReviewId { get; set; }
    }
}
