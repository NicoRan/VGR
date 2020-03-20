using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using VGR.Models;
using VGR.Services.Contracts;
using VGR.Web.Mappers;
using VGR.Web.Models;

namespace VGR.Web.Controllers
{
    public class ReviewsController : Controller
    {
        
        private readonly IReviewService _reviewService;
        private readonly UserManager<PowerUser> _userManager;

        public ReviewsController(IReviewService reviewService, UserManager<PowerUser> userManager)
        {
            _reviewService = reviewService ?? throw new ArgumentNullException(nameof(_reviewService));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(_userManager));
        }

        public async Task<IActionResult> Index()
        {
           
            var reviews =  await _reviewService.GetAllReviewsAsync();
            var reviewViewModel = reviews.ToCRVM(); 
            
            return View(reviewViewModel);

        }

        public async Task<IActionResult> Details(Guid id)
        {
            var review = await _reviewService.GetReviewCommentsAsync(id);
            var reviewVM = review.ToVM();
           
            var newCommentsVM = review.Comments.ToVM();
            reviewVM.CommentViewModels = newCommentsVM;
            return View(reviewVM);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateReviewViewModel reviewViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            var userId = _userManager.GetUserId(HttpContext.User);
            await _reviewService.CreateReviewAsync(Guid.Parse(userId),reviewViewModel.ReviewText,reviewViewModel.GameName,reviewViewModel.GamePublisher,reviewViewModel.ReleaseYear,reviewViewModel.VideoReview);

            return Redirect("~/Reviews");
        }


    }
}
