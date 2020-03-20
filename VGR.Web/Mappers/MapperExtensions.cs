using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VGR.Models;
using VGR.Web.Models;

namespace VGR.Web.Mappers
{
    public static class MapperExtensions
    {

        public static ReviewViewModel ToVM(this Review review)
        {
            var reviewVM = new ReviewViewModel
            {
                Id = review.Id,
                ReviewText = review.ReviewText,
                ReleaseYear = review.ReleaseYear,
                GameName = review.GameName,
                GamePublisher = review.GamePublisher,
                VideoReview = review.VideoReview,
                CreatedOn = review.CreatedOn
            };

            return reviewVM;
        }

        public static CreateReviewViewModel ToCRVM(this Review review)
        {
            var createReview = new CreateReviewViewModel()
            {
                Id = review.Id,
                ReviewText = review.ReviewText,
                GameName = review.GameName,
                GamePublisher = review.GamePublisher,
                ReleaseYear = review.ReleaseYear,
                VideoReview = review.VideoReview,
                CreatedOn = review.CreatedOn
            };

            return createReview;
        }

        public static CommentViewModel ToVM(this Comment comment)
        {
            var newCommentViewModel = new CommentViewModel
            {
                Id = comment.Id,
                EmailAddress = comment.EmailAddress,
                CommentText = comment.CommentText,
                UserName = comment.UserName,
                CreatedOn = comment.CreatedOn,
                ReviewId = comment.ReviewId
            };

            return newCommentViewModel;
        }

        public static ICollection<CommentViewModel> ToVM(this ICollection<Comment> comments)
        {
            return comments.Select(x => ToVM(x)).ToList();
        }

        public static ICollection<CreateReviewViewModel> ToCRVM(this ICollection<Review> review)
        {
            return review.Select(x  =>  x.ToCRVM()).ToList();
        }
    }
}
