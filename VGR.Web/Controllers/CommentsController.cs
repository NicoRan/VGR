using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VGR.Data.Context;
using VGR.Models;
using VGR.Services.Contracts;
using VGR.Web.Models;

namespace VGR.Web.Controllers
{
    public class CommentsController : Controller
    {
        private readonly VGRDbContext _context;
        private readonly ICommentService _commentService;

        public CommentsController(VGRDbContext context, ICommentService commentService)
        {
            _context = context;
            _commentService = commentService;
        }

        // GET: Comments
        public async Task<IActionResult> Index()
        {
            var vGRDbContext = _context.Comments.Include(c => c.Review);
            return View(await vGRDbContext.ToListAsync());
        }

        // GET: Comments/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.Review)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        //// GET: Comments/Create
        //public IActionResult Create()
        //{
        //    //ViewData["ReviewId"] = new SelectList(_context.Reviews, "Id");
        //    return View();
        //}
        
        // POST: Comments/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCommentViewModel  createCommentViewModel)
        {
            var stop = 0;
            //if (ModelState.IsValid)
            //{
            //    comment.Id = Guid.NewGuid();
            //    _context.Add(comment);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["ReviewId"] = new SelectList(_context.Reviews, "Id", "GameName", comment.ReviewId);

            await _commentService.CreateCommentAsync(createCommentViewModel.EmailAddress, createCommentViewModel.UserName, createCommentViewModel.CommentText, createCommentViewModel.Id);

            return RedirectToAction("Index");
        }

        // GET: Comments/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["ReviewId"] = new SelectList(_context.Reviews, "Id", "GameName", comment.ReviewId);
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,EmailAddress,UserName,CommentText,CreatedOn,ReviewId")] Comment comment)
        {
            if (id != comment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.Id))
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
            ViewData["ReviewId"] = new SelectList(_context.Reviews, "Id", "GameName", comment.ReviewId);
            return View(comment);
        }

        // GET: Comments/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.Review)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var comment = await _context.Comments.FindAsync(id);
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(Guid id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
    }
}
