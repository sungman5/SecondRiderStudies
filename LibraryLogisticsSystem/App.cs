namespace LibraryLogisticsSystem;

public class App
{
    public void Open()
    {
        Console.WriteLine("도서관이 문을 열었슴다.");
        List<BookLocation> _bookLocations = new List<BookLocation>();

        Book myBook1 = new Book("죽은 왕녀를 위한 파반느", 0.8, new BookLocation('A', 3, 1));
        Book myBook2 = new Book("람세스", 1, new BookLocation('B', 1, 2));
        Book myBook3 = new Book("몽테크리스토 백작", 1.2, new BookLocation('C', 5, 1));

        LogisticsBox<Book> _bookBox = new LogisticsBox<Book>();

        _bookBox.AddItem(myBook1);
        _bookBox.AddItem(myBook2);
        _bookBox.AddItem(myBook3);

        

        _bookBox.PrintAllItems();
    }
}