// Models/Author.cs
public class Author
{
    public int AuthorId { get; set; }
    public string? Name { get; set; }

    public ICollection<Book> Book { get; set; } = new List<Book>();
}
