namespace HeroAcademyBattleSimulator;

public class ItemBag<T>
{
    private List<T> _bag = new List<T>();

    public void Add(T item)
    {
        _bag.Add(item);
        Console.WriteLine($"{item}을 가방에 담았습니다.");
    }

    public void Remove(T item)
    {
        if (_bag.Contains(item))
        {
            _bag.Remove(item);
            Console.WriteLine($"{item}을 가방에서 꺼냈습니다.");
        }
        else
        {
            Console.WriteLine("가방에 해당 아이템이 없습니다.");
        }
    }
}