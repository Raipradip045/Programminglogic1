namespace Lab7;

class Program
{
    static void Main(string[] args)
    {
        private string title;
        public Book()
        {
            title = "Unknown Title";
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string newTitle)
        {
            title = newTitle;
        }
}
class program
{
    static void Main(string[]args)
    {
        Book book1 = new Book();
        Console.WriteLine($"Title: {book1.GetTitle()}");

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine($"Title:{book1.GetTitle()}");
    }
}

//Problem 2
class Book
{
    private string title;

    public Book()
    {
        title = "Unknown Title";
    }

    public Book(string newTitle)
    {
        title = newTitle;
    }
    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

}

class Program
{
    static void Mian(string[]args)
    {
        Book book2 = new Book("Advanced C#");
        Console.WriteLine($"Title: {book2.GetTitle()}");
    }
}

//Problem 3

class Book 
{
    private string title;
    private string author;

    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }
    public Book(string newTitle, string newAuthor)
    {
        title = newTitle;
        author = newAuthor;
    }
    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }
    public string GetAuthor()
    {
        return author;
    }
    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}
class Program
{
    static void Main(string[]args)
    {
        Book books3 = new Book("advanced C#", "John Doe");
        Console.WriteLine($"Title: {books3.GetTitle()}");
        Console.WriteLine($"Author:{books3.GetAuthor()}");
    }
}

//Problem 4

{
    static void Main(string[]args)
    {
        Book book4 = mew Book();
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");

        Console.WriteLine($"Title:{book4.GetTitle()}");
        Console.WriteLine($"Author:{book4.GetAuthor()}");
    }
}

