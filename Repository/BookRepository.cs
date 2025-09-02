using Microsoft.EntityFrameworkCore;
public class BookRepository : GenericRepository<Book>
{
    public BookRepository(LibraryContext context) : base(context) { }

    public async Task<IEnumerable<Book>> GetBooksWithAuthorGenreAsync()
    {
        return await _context.Books
            .Include(b => b.Author)
            .Include(b => b.Genre)
            .ToListAsync();
    }
}
