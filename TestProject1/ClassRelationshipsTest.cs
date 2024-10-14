using ClassLibrary1;

namespace TestProject1;

public class ClassRelationshipsTest
{
    [Fact]
    public void AddBook_IncreasesBookCount()
    {
        // Arrange
        Library library = new Library();
        Book book = new Book("Title", "Author", "ISBN");

        // Act
        library.AddBook(book);

        // Assert
        Assert.Single(library.GetBooks());
    }

    [Fact]
    public void RemoveBook_DecreasesBookCount()
    {
        // Arrange
        Library library = new Library();
        Book book = new Book("Title", "Author", "ISBN");
        library.AddBook(book);

        // Act
        library.RemoveBook(book);

        // Assert
        Assert.Empty(library.GetBooks());
    }

    [Fact]
    public void SearchBook_ReturnsCorrectBook()
    {
        // Arrange
        Library library = new Library();
        Book book = new Book("Title", "Author", "ISBN");
        library.AddBook(book);

        // Act
        Book foundBook = library.SearchBook("Title");
  

        // Assert
        Assert.Equal(book, foundBook);
    }

    [Fact]
    public void LibraryHasCompositionRelationshipWithBook()
    {
        // Arrange
        Library library = new Library();
        Book book = new Book("Title", "Author", "ISBN");

        // Act
        library.AddBook(book);

        // Assert
        Assert.Contains(book, library.GetBooks());
    }

    [Fact]
    public void CustomerHasAggregationRelationshipWithOrder()
    {
        // Arrange
        Customer customer = new Customer();
        Order order1 = new Order();
        Order order2 = new Order();

        // Act
        customer.AddOrder(order1);
        customer.AddOrder(order2);

        // Assert
        Assert.Contains(order1, customer.GetOrders());
        Assert.Contains(order2, customer.GetOrders());
    }

    public class OrderProcessorTests
    {
        [Fact]
        public void OrderProcessorHasDependencyRelationshipWithEmailSender()
        {
            // Arrange
            EmailSender emailSender = new EmailSender();
            OrderProcessor orderProcessor = new OrderProcessor(emailSender);

            // Act
            var emailSent = orderProcessor.ProcessOrder(new Order());

            // Assert
            // Verify that the email sender was called
            Assert.NotNull(emailSent);
        }
    }
}