enum Genre
{
    Fiction,
    Mystery,
    ScienceFiction,
    Romance,
    NonFiction
}

struct LibraryBook
{
    public int LibraryCardNumber { get; set; }
    public string SubscriberName { get; set; }
    public DateTime IssueDate { get; set; }
    public Genre BookGenre { get; set; }
    public int ReturnTermInDays { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public string Publisher { get; set; }
    public double Price { get; set; }
}

class Library
{
    private const string FilePath = "library_data.txt";

    public static void SaveBooksToFile(List<LibraryBook> books)
    {
        using (StreamWriter writer = new StreamWriter(FilePath, append: false))
        {
            foreach (var book in books)
            {
                writer.WriteLine($"{book.LibraryCardNumber},{book.SubscriberName},{book.IssueDate},{(int)book.BookGenre}," +
                                 $"{book.ReturnTermInDays},{book.Author},{book.Title},{book.PublicationYear}," +
                                 $"{book.Publisher},{book.Price}");
            }
        }

        Console.WriteLine("Library data has been saved to the file.");
    }

    public static void AppendBooksToFile(List<LibraryBook> books)
    {
        using (StreamWriter writer = new StreamWriter(FilePath, append: true))
        {
            foreach (var book in books)
            {
                writer.WriteLine($"{book.LibraryCardNumber},{book.SubscriberName},{book.IssueDate},{(int)book.BookGenre}," +
                                 $"{book.ReturnTermInDays},{book.Author},{book.Title},{book.PublicationYear}," +
                                 $"{book.Publisher},{book.Price}");
            }
        }

        Console.WriteLine("Library data has been appended to the file.");
    }

    public static List<LibraryBook> ReadBooksFromFile()
    {
        List<LibraryBook> books = new List<LibraryBook>();

        if (File.Exists(FilePath))
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    LibraryBook book = new LibraryBook
                    {
                        LibraryCardNumber = int.Parse(data[0]),
                        SubscriberName = data[1],
                        IssueDate = DateTime.Parse(data[2]),
                        BookGenre = (Genre)Enum.Parse(typeof(Genre), data[3]),
                        ReturnTermInDays = int.Parse(data[4]),
                        Author = data[5],
                        Title = data[6],
                        PublicationYear = int.Parse(data[7]),
                        Publisher = data[8],
                        Price = double.Parse(data[9])
                    };

                    books.Add(book);
                }
            }
        }

        return books;
    }

    public static void DisplayBooks(List<LibraryBook> books)
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Card: {book.LibraryCardNumber}, Name: {book.SubscriberName}, " +
                              $"Issue Date: {book.IssueDate.ToShortDateString()}, Genre: {book.BookGenre}, " +
                              $"Return Term: {book.ReturnTermInDays} days, Author: {book.Author}, " +
                              $"Title: {book.Title}, Year: {book.PublicationYear}, Publisher: {book.Publisher}, " +
                              $"Price: {book.Price:C}");
        }
    }

    public static List<LibraryBook> SearchByLibraryCardNumber(List<LibraryBook> books, int cardNumber)
    {
        return books.FindAll(book => book.LibraryCardNumber == cardNumber);
    }

    public static List<LibraryBook> SearchByAuthor(List<LibraryBook> books, string author)
    {
        return books.FindAll(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
    }

    public static List<LibraryBook> SearchByPublisher(List<LibraryBook> books, string publisher)
    {
        return books.FindAll(book => book.Publisher.Equals(publisher, StringComparison.OrdinalIgnoreCase));
    }

    static void Main()
    {
        // Example of usage:

        // Reading existing data from the file
        List<LibraryBook> libraryBooks = ReadBooksFromFile();

        // Displaying all books
        Console.WriteLine("All Library Books:");
        DisplayBooks(libraryBooks);

        // Adding a new book
        LibraryBook newBook = new LibraryBook
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

        // Saving all books back to the file
        SaveBooksToFile(libraryBooks);

        // Searching for books by author
        string searchAuthor = "Jane Author";
        List<LibraryBook> booksByAuthor = SearchByAuthor(libraryBooks, searchAuthor);

        Console.WriteLine($"\nBooks by {searchAuthor}:");
        DisplayBooks(booksByAuthor);

        // Searching for books by publisher
        string searchPublisher = "XYZ Publications";
        List<LibraryBook> booksByPublisher = SearchByPublisher(libraryBooks, searchPublisher);

        Console.WriteLine($"\nBooks by {searchPublisher}:");
        DisplayBooks(booksByPublisher);

        // Appending more books to the file
        List<LibraryBook> additionalBooks = new List<LibraryBook>
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
            // Add more books as needed
        };

        AppendBooksToFile(additionalBooks);

        // Displaying all books after appending
        Console.WriteLine("\nAll Library Books after appending more books:");
        DisplayBooks(ReadBooksFromFile());
    }
}
