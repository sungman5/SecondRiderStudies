namespace HeroAcademyBattleSimulator;

public class Knight : Student, ISkillUser
{
    private int _hp;
    
    public Knight(string name, int hp, Stat stats) : base(name, hp, stats)
    {
    }

    public override void Attack()
    {
        int attctPower = Stats.Str * 10;
        Console.WriteLine($"{Name}이(가) {attctPower} 데미지로 공격합니다!");
    }
    
    public void UseSkill(Student target)
    {
        Console.WriteLine($"Knight {target.Name}이(가) 방패치기를 시전합니다.");
    }
}