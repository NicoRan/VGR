using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VGR.Models;

namespace VGR.Services.Contracts
{
    public interface IReviewService
    {
        Task<Review> CreateReviewAsync(Guid powerUserId, string reviewText, string gameName, string gamePublisher, string releaseYear, string videoReview);

        Task<ICollection<Review>> GetAllReviewsAsync();
        Task<Review> GetReviewAsync(Guid id);
        Task<Review> GetReviewCommentsAsync(Guid id);
    }
}