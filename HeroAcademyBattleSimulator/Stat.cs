namespace HeroAcademyBattleSimulator;

public struct Stat
{
    public int Str { get; set; }
    public int Dex { get; set; }
    public int Intelligence { get; set; }

    public Stat(int str, int dex, int intelligence)
    {
        Str = str;
        Dex = dex;
        Intelligence = intelligence;
    }
}