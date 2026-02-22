namespace LibraryLogisticsSystem;

public class LogisticsBox<T> where T : ILoggable
{
    private List<T> _list = new List<T>();

    public void AddItem(T item)
    {
        _list.Add(item);
        Console.WriteLine($"{item.Name}이 박스에 추가되었습니다.");
    }

    public void PrintAllItems()
    {
        for (int i = 0; i < _list.Count; i++)
        {
            Console.WriteLine($"번호:{i+1}, 책이름: {_list[i].Name}, 위치: {_list[i].Location}");
        }
    }
    
}