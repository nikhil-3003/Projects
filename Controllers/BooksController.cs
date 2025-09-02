using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
public class BooksController : Controller
{
    private readonly BookRepository _bookRepo;

    public BooksController(BookRepository bookRepo)
    {
        _bookRepo = bookRepo;
    }

    public async Task<IActionResult> Index()
    {
        var books = await _bookRepo.GetBooksWithAuthorGenreAsync();
        return View(books);
    }

    [HttpPost]
    public async Task<IActionResult> AddBook(Book book)
    {
        if (ModelState.IsValid)
        {
            await _bookRepo.AddAsync(book);
            return Json(new { success = true, message = "Book added successfully!" });
        }
        return Json(new { success = false, message = "Error adding book" });
    }
}
