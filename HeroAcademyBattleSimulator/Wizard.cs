namespace HeroAcademyBattleSimulator;

public class Wizard : Student, ISkillUser
{
    public Wizard(string name, int hp, Stat stats) : base(name, hp, stats)
    {
    }

    public override void Attack()
    {
        int attctPower = Stats.Intelligence * 10;
        Console.WriteLine($"{Name}이(가) {attctPower} 데미지로 공격합니다!");
    }

    public void UseSkill(Student target)
    {
        Console.WriteLine($"마법사 {Name}이(가) {target.Name}에게 파이어볼을 시전합니다.");
    }
}