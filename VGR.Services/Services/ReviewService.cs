using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGR.Data.Context;
using VGR.Models;
using VGR.Services.Contracts;

namespace VGR.Services.Services
{
    public class ReviewService : IReviewService
    {
        private readonly VGRDbContext _dbContext;
        private readonly IPowerUserService _powerUserService;

        public ReviewService(VGRDbContext dbContext, IPowerUserService powerUserService)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _powerUserService = powerUserService ?? throw new ArgumentNullException(nameof(powerUserService));
        }

        //public async Task<Review> FindReviewAsync(Guid id)
        //{
        //    return await _dbContext.Reviews.FirstOrDefaultAsync(r => r.Id == id);
        //}
        public async Task<Review> CreateReviewAsync(Guid powerUserId, string reviewText, string gameName, string gamePublisher, string releaseYear, string videoReview)
        {
            var powerUser = await _powerUserService.FindUserAsync(powerUserId);
            var videoId = videoReview.Substring(Math.Max(0, videoReview.Length - 11));

            string youtubeAddress = "https://www.youtube.com/embed/" + videoId;
            var review = new Review
            {
                PowerUser = powerUser,
                ReviewText = reviewText,
                GameName = gameName,
                GamePublisher = gamePublisher,
                ReleaseYear = releaseYear,
                VideoReview = youtubeAddress,
                //CreatedOn = DateTime.UtcNow
            };

            await _dbContext.Reviews.AddAsync(review);
            await _dbContext.SaveChangesAsync();

            return review;
        }

        public async Task<Review> GetReviewAsync(Guid id)
        {
            var review = await _dbContext.Reviews.FirstOrDefaultAsync(r => r.Id == id);

            return review;
        }

        public async Task<Review> GetReviewCommentsAsync(Guid id)
        {

            var review = await _dbContext.Reviews
                .Include(r => r.Comments)
                .FirstOrDefaultAsync(r => r.Id == id);

            return review;
        }
        public async Task<ICollection<Review>> GetAllReviewsAsync()
        {
            var listOfReviews = await _dbContext.Reviews
                .OrderByDescending(r => r.CreatedOn)
                .Include(r => r.Comments)
                .ToListAsync();
            
            return listOfReviews;
        }
    }
}
