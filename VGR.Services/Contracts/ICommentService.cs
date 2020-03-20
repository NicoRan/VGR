using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VGR.Models;

namespace VGR.Services.Contracts
{
    public interface ICommentService
    {
        Task<Comment> CreateCommentAsync(string emailAddress, string userName, string commentText, Guid reviewId);
        Task<ICollection<Comment>> GetCommentsByReviewId(Guid id);
    }
}