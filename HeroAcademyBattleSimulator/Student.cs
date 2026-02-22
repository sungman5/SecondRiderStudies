namespace HeroAcademyBattleSimulator;

public abstract class Student
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public Stat Stats { get; set; }

    // 1. 델리게이트 변수 선언 (외부에서 알림을 받을 함수를 연결할 곳)
    public BattleAlram.BattleLogger? OnBattleEvent;

    public Student(string name, int hp, Stat stats)
    {
        Name = name;
        Hp = hp;
        Stats = stats;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name}이 기본 공격을 합니다!");
        // 2. 델리게이트 실행 (연결된 함수가 있다면 메시지 전달)
        OnBattleEvent?.Invoke($"{Name}이 기본 공격을 합니다!");
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0 && damage < Hp)
        {
            Hp -= damage;
            Console.WriteLine($"{Name}이(가) {damage} 피해를 입었습니다. 현재 HP: {Hp}");
            OnBattleEvent?.Invoke($"{Name}이(가) {damage} 피해를 입었습니다. 현재 HP: {Hp}");
        }

        if (damage >= Hp)
        {
            Hp = 0;
            Console.WriteLine($"{Name}이(가) {damage} 피해를 입고 사망했습니다.");
            OnBattleEvent?.Invoke($"{Name}이(가) {damage} 피해를 입고 사망했습니다.");
        }
    }
}