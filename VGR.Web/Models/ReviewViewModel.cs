using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VGR.Models;

namespace VGR.Web.Models
{
    public class ReviewViewModel
    {
        public Guid Id { get; set; }
        public string ReviewText { get; set; }
        public string GameName { get; set; }
        public string GamePublisher { get; set; }
        public string ReleaseYear { get; set; }
        public string VideoReview { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<CommentViewModel> CommentViewModels { get; set; } = new List<CommentViewModel>();
    }
}
