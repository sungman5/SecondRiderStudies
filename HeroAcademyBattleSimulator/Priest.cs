namespace HeroAcademyBattleSimulator;

public class Priest : Student
{
    public Priest(string name, int hp, Stat stat) :base (name, hp, stat) { }
    public override void Attack()
    {
        base.Attack();
    }

    public void Heal(Student st)
    {
        st.Hp += 20;
    }
}