var libraryBooks = Library.ReadBooksFromFile();

Console.WriteLine("All Library Books:");
Library.DisplayBooks(libraryBooks);

var newBook = new LibraryBook
{
    LibraryCardNumber = 12345,
    SubscriberName = "John Doe",
    IssueDate = DateTime.Now,
    BookGenre = Genre.Fiction,
    ReturnTermInDays = 14,
    Author = "Jane Author",
    Title = "A Great Book",
    PublicationYear = 2022,
    Publisher = "XYZ Publications",
    Price = 19.99
};

libraryBooks.Add(newBook);

Library.SaveBooksToFile(libraryBooks);

string searchAuthor = "Jane Author";
var booksByAuthor = Library.SearchByAuthor(libraryBooks, searchAuthor);

Console.WriteLine($"\nBooks by {searchAuthor}:");
Library.DisplayBooks(booksByAuthor);

string searchPublisher = "XYZ Publications";
var booksByPublisher = Library.SearchByPublisher(libraryBooks, searchPublisher);

Console.WriteLine($"\nBooks by {searchPublisher}:");
Library.DisplayBooks(booksByPublisher);

var additionalBooks = new System.Collections.Generic.List<LibraryBook>
{
    new LibraryBook
    {
        LibraryCardNumber = 67890,
        SubscriberName = "Alice Smith",
        IssueDate = DateTime.Now.AddDays(-7),
        BookGenre = Genre.Romance,
        ReturnTermInDays = 21,
        Author = "John Writer",
        Title = "Love Story",
        PublicationYear = 2021,
        Publisher = "ABC Publishers",
        Price = 15.99
    },
};

Library.AppendBooksToFile(additionalBooks);

Console.WriteLine("\nAll Library Books after appending more books:");
Library.DisplayBooks(Library.ReadBooksFromFile());