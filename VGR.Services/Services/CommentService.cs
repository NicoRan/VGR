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
    public class CommentService : ICommentService
    {
        private readonly VGRDbContext _dbContext;
        private readonly IReviewService _reviewService;

        public CommentService(VGRDbContext dbContext, IReviewService reviewService)
        {
            _dbContext = dbContext;
            _reviewService = reviewService;
        }

        public async Task<Comment> CreateCommentAsync(string emailAddress, string userName, string commentText, Guid reviewId)
        {
            var comment = new Comment
            {
                Id = Guid.NewGuid(),
                EmailAddress = emailAddress,
                UserName = userName,
                CommentText = commentText,
                ReviewId = reviewId,
                CreatedOn = DateTime.UtcNow
            };
            await _dbContext.Comments.AddAsync(comment);
            await _dbContext.SaveChangesAsync();

            return comment;
        }

        public async Task<ICollection<Comment>> GetCommentsByReviewId(Guid id)
        {
            var comments = await _dbContext.Comments.Where(c => c.ReviewId == id).ToListAsync();
            return comments;
        }

    }
}
