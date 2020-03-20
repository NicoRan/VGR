using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VGR.Data.Context;
using VGR.Models;
using VGR.Services.Contracts;
using VGR.Web.Models;

namespace VGR.Web.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly VGRDbContext _context;
        private readonly IReviewService _reviewService;
        private readonly IPowerUserService _powerUserService;
        private readonly UserManager<PowerUser> _userManager;

        public ReviewsController(VGRDbContext context, IReviewService reviewService, IPowerUserService powerUserService, UserManager<PowerUser> userManager)
        {
            _context = context;
            _reviewService = reviewService;
            _powerUserService = powerUserService;
            _userManager = userManager;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            //await _reviewService.GetAllReviewsAsync();
            //return View(await _context.Reviews.ToListAsync());
            var reviews =  await _reviewService.GetAllReviewsAsync();

            var reviewViewModel = new List<CreateReviewViewModel>();

            foreach (var review in reviews)
            {
                reviewViewModel.Add(new CreateReviewViewModel()
                {
                    Id = review.Id,
                    ReviewText = review.ReviewText,
                    GameName = review.GameName,
                    GamePublisher = review.GamePublisher,
                    ReleaseYear = review.ReleaseYear,
                    VideoReview = review.VideoReview,
                    CreatedOn = review.CreatedOn
                });
            }
            return View(reviewViewModel);

        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(Guid id)
        {
            var review = await _reviewService.GetReviewCommentsAsync(id);

            var reviewVM = new ReviewViewModel
            {
                Id = review.Id,
                ReviewText = review.ReviewText,
                ReleaseYear = review.ReleaseYear,
                GameName = review.GameName,
                GamePublisher = review.GamePublisher,
                VideoReview = review.VideoReview,
                CreatedOn = DateTime.UtcNow
            };

            foreach (var comment in review.Comments)
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

                reviewVM.CommentViewModels.Add(newCommentViewModel);
            }
            
            return View(reviewVM);
        }

        // GET: Reviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateReviewViewModel reviewViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(Create());
            }
            //if (ModelState.IsValid)
            //{
            //    review.Id = Guid.NewGuid();
            //    _context.Add(review);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            var userId = _userManager.GetUserId(HttpContext.User);
            await _reviewService.CreateReviewAsync(Guid.Parse(userId),reviewViewModel.ReviewText,reviewViewModel.GameName,reviewViewModel.GamePublisher,reviewViewModel.ReleaseYear,reviewViewModel.VideoReview);

            return View();
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ReviewText,GameName,GamePublisher,ReleaseYear,VideoReview,CreatedOn")] Review review)
        {
            if (id != review.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(review);
        }

        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Reviews
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var review = await _context.Reviews.FindAsync(id);
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(Guid id)
        {
            return _context.Reviews.Any(e => e.Id == id);
        }
    }
}
