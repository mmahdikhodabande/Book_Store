using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Book_store.Data;
using Book_store.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Book_store.Controllers
{
    public class BookController : Controller
    {
        private readonly BookStoreContext _context;
        private const int PageSize = 1;

        public BookController(BookStoreContext context)
        {
            _context = context;
        }

        // GET: Book
        public async Task<IActionResult> Index(int pageIndex = 1)
        {
            IQueryable<Book> query = _context.Books.OrderBy(u => u.Book_ID);
            var Books = await PaginationModel<Book>.CreateAsync(query, pageIndex, PageSize);
            //var books = await _context.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
            //var viewModel = new UsersBooksViewModel
            //{
            //    Users = users,
            //    Books = books
            //};
            return View(Books);
        }

        // GET: Book/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(m => m.Book_ID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Book/Create
        public IActionResult Create()
        {
            ViewData["Author_ID"] = new SelectList(_context.Authors, "Author_ID", "Author_ID");
            ViewData["Publisher_ID"] = new SelectList(_context.Publishers, "Publisher_ID", "Publisher_ID");
            return View();
        }

        // POST: Book/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Book_ID,Title,Author_ID,Publisher_ID,Price,Description,PublishDate,Cover_Image,PageCount")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Author_ID"] = new SelectList(_context.Authors, "Author_ID", "Author_ID", book.Author_ID);
            ViewData["Publisher_ID"] = new SelectList(_context.Publishers, "Publisher_ID", "Publisher_ID", book.Publisher_ID);
            return View(book);
        }

        // GET: Book/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["Author_ID"] = new SelectList(_context.Authors, "Author_ID", "Author_ID", book.Author_ID);
            ViewData["Publisher_ID"] = new SelectList(_context.Publishers, "Publisher_ID", "Publisher_ID", book.Publisher_ID);
            return View(book);
        }

        // POST: Book/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Book_ID,Title,Author_ID,Publisher_ID,Price,Description,PublishDate,Cover_Image,PageCount")] Book book)
        {
            if (id != book.Book_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Book_ID))
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
            ViewData["Author_ID"] = new SelectList(_context.Authors, "Author_ID", "Author_ID", book.Author_ID);
            ViewData["Publisher_ID"] = new SelectList(_context.Publishers, "Publisher_ID", "Publisher_ID", book.Publisher_ID);
            return View(book);
        }

        // GET: Book/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(m => m.Book_ID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Book/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Book_ID == id);
        }
    }
}
