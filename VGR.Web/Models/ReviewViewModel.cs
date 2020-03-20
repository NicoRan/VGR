using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using VGR.Models;

namespace VGR.Web.Models
{
    public class ReviewViewModel
    {
        public Guid Id { get; set; }

        [DisplayName("Review")]
        public string ReviewText { get; set; }

        [DisplayName("Game Name")]
        public string GameName { get; set; }

        [DisplayName("Game Publisher")]
        public string GamePublisher { get; set; }

        [DisplayName("Release Year")]
        public string ReleaseYear { get; set; }

        [DisplayName("Video Review")]
        public string VideoReview { get; set; }

        [DisplayName("Added On")]
        public DateTime CreatedOn { get; set; }
        public ICollection<CommentViewModel> CommentViewModels { get; set; } = new List<CommentViewModel>();
    }
}
