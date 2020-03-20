using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rotativa;
using Rotativa.AspNetCore;
using VGR.Data.Context;
using VGR.Models;
using VGR.Services.Contracts;
using VGR.Web.Mappers;
using VGR.Web.Models;

namespace VGR.Web.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService ?? throw new ArgumentNullException(nameof(_commentService));
        }

        [Authorize]
        public async Task<ViewAsPdf> PrintPDF(Guid id)
        {

            var list = await _commentService.GetCommentsByReviewId(id);
            var VMList = list.ToVM();
            
            return new ViewAsPdf("PrintPDF", VMList)
            {

                FileName = "ExportComments.pdf"
            };

        }

        // POST: Comments/Create
        [HttpPost]
        public async Task<IActionResult> Create(CreateCommentViewModel  createCommentViewModel)
        {
            if (!ModelState.IsValid)
            {
                return Redirect($"~/Reviews/Details/{createCommentViewModel.Id}");
            }

            await _commentService.CreateCommentAsync(createCommentViewModel.EmailAddress, createCommentViewModel.UserName, createCommentViewModel.CommentText, createCommentViewModel.Id);

            return Redirect($"~/Reviews/Details/{createCommentViewModel.Id}");
        }
    }
}
