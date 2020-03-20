using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VGR.Web.Models
{
    public class CreateReviewViewModel
    {
        public Guid Id { get; set; }
        [DisplayName("Review Text")]
        public string ReviewText { get; set; }
        
        [DisplayName("Game Name")]

        public string GameName { get; set; }

        [DisplayName("Game Publisher")]
        public string GamePublisher { get; set; }

        [DisplayName("Release Year")]
        public string ReleaseYear { get; set; }

        [DisplayName("Video Review")]
        public string VideoReview { get; set; }

        [DisplayName("Date Added")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
