
namespace ClassLibrary1;

public class Library
{
    private List<Book> _listOfBooks = new List<Book>();

    public void AddBook(Book book)
    {
        _listOfBooks.Add(book);
    }
    public Book[] GetBooks()
    {
        return _listOfBooks.ToArray();
    }

    public void RemoveBook(Book book)
    {
        _listOfBooks.Remove(book);
    }

    public Book SearchBook(string title)
    {
        foreach (var book in _listOfBooks)
        {
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                return book; // Return the found book
            }
        }
        Console.WriteLine("Book Not Found");
        return null; // Return null if not found
    }
}

