using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Data;

namespace LibraryManagementSystem.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookRepository _repository;

        public BooksController(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            _repository = new BookRepository(connectionString);
        }

        // GET: Books
        public IActionResult Index()
        {
            try
            {
                var books = _repository.GetAllBooks();
                return View(books);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error connecting to database: " + ex.Message;
                return View(new List<Book>());
            }
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repository.AddBook(book);
                    TempData["SuccessMessage"] = "Book added successfully!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error adding book: " + ex.Message);
                }
            }
            return View(book);
        }

        // GET: Books/Edit/5
        public IActionResult Edit(int id)
        {
            var book = _repository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repository.UpdateBook(book);
                    TempData["SuccessMessage"] = "Book updated successfully!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error updating book: " + ex.Message);
                }
            }
            return View(book);
        }

        // GET: Books/Delete/5
        public IActionResult Delete(int id)
        {
            try
            {
                _repository.DeleteBook(id);
                TempData["SuccessMessage"] = "Book deleted successfully!";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Error deleting book: " + ex.Message;
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
